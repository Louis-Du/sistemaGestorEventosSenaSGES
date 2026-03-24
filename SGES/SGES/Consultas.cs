using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq.Expressions;

namespace SGES
{
    internal class Consultas
    {
        // Instancia que gestiona la conexión a la base de datos (abrir/cerrar).
        Conexion cn = new Conexion(); // Crear una instancia de la clase Conexion para manejar la conexión a la base de datos
        // DataSet utilizado para almacenar resultados de consultas y poder enlazarlos a controles (ej. DataGridView).
        DataSet ds = new DataSet(); // Crear un DataSet para almacenar los datos obtenidos de la base de datos
        // Variable que indica si el inicio de sesión fue exitoso (true) o no (false).
        Boolean Estado_conexion = false; // Variable para indicar el estado de la conexión

        public Boolean Iniciar_sesion(int idusuario, string passworusuario)
        {
            // Preparar comando SQL para buscar el usuario con el id y contraseña proporcionados.
            // Se usan parámetros para evitar inyección SQL.
            SqlCommand query = new SqlCommand("select idusuario,passworusuario, tipousuario from Usuario where idUser=@idusuario and contraseñaUser=@passworusuario", cn.Conectar());
            query.CommandType = CommandType.Text;
            query.Parameters.AddWithValue("@idusuario", idusuario);
            query.Parameters.AddWithValue("@passworusuario", passworusuario);
            // ExecuteNonQuery no devuelve filas en SELECT, pero aquí el código crea un SqlDataAdapter
            // que rellenará el DataSet; ExecuteNonQuery puede omitirse en este contexto, pero se deja
            // para no cambiar la lógica existente.
            query.ExecuteNonQuery();
            
            
            try
            {
                // Usar SqlDataAdapter para ejecutar el SELECT y llenar el DataSet con los resultados.
                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(ds, "Usuario");
                // Si la consulta devolvió filas, tomar la primera fila (único usuario que cumple los criterios)
                DataRow dr;
                dr = ds.Tables["Usuario"].Rows[0];
                // Comparar los valores recuperados con los ingresados y abrir el formulario correspondiente
                // según el campo `tipousuario` (por ejemplo "permanente" o "temporal").
                // Nota: el operador & funciona pero lo habitual es usar && para AND lógico.
                if (Convert.ToString(idusuario) == dr["idusuario"].ToString() & passworusuario == dr["passworusuario"].ToString() & "permanente" == dr["tipousuario"].ToString())
                {
                    MessageBox.Show("Bienvenido(a)!");
                    // Usuario permanente: abrir el formulario con privilegios/funciones para usuarios permanentes.
                    FormAdmin frm = new FormAdmin();
                    frm.Show();
                    Estado_conexion = true;

                }
                else
                {
                    // Si no es admin, comprobar si es aprendiz y abrir el formulario aprendiz.
                    if (Convert.ToString(idusuario) == dr["idusuario"].ToString() & passworusuario == dr["passworusuario"].ToString() & "temporal" == dr["tipousuario"].ToString())
                    {
                        MessageBox.Show("Bienvenido(a)!");
                        FormAprendiz frm = new FormAprendiz();
                        frm.Show();
                        Estado_conexion = true;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Desconectar();
            }
            return Estado_conexion;
        }
    }
}
