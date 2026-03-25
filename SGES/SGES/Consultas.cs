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

        public Boolean Iniciar_sesion(int idUser, string contraseñaUser)
        {
            try
            {
                ds.Tables.Clear(); // limpiar el DataSet antes de cada consulta

                // 🔹 BUSCAR EN USUARIO (ADMIN)
                SqlCommand query = new SqlCommand(
                    "SELECT idUser, tipoUser FROM Usuario WHERE idUser=@idUser AND contraseñaUser=@contraseñaUser",
                    cn.Conectar());

                query.Parameters.AddWithValue("@idUser", idUser);
                query.Parameters.AddWithValue("@contraseñaUser", contraseñaUser);

                SqlDataAdapter da = new SqlDataAdapter(query);
                da.Fill(ds, "Usuario");

                if (ds.Tables["Usuario"].Rows.Count > 0)
                {
                    string tipo = ds.Tables["Usuario"].Rows[0]["tipoUser"].ToString().Trim();

                    if (tipo == "Administrador")
                    {
                        MessageBox.Show("Bienvenido(a) Administrador!");
                        new FormAdmin().Show();
                        Estado_conexion = true;
                        return true;
                    }
                }

                // 🔹 BUSCAR EN APRENDIZ
                ds.Tables.Clear();

                SqlCommand query2 = new SqlCommand(
                    "SELECT idApr, tipoUser FROM Aprendiz WHERE idApr=@idUser AND contraseñaUser=@contraseñaUser",
                    cn.Conectar());

                query2.Parameters.AddWithValue("@idUser", idUser);
                query2.Parameters.AddWithValue("@contraseñaUser", contraseñaUser);

                SqlDataAdapter da2 = new SqlDataAdapter(query2);
                da2.Fill(ds, "Aprendiz");

                if (ds.Tables["Aprendiz"].Rows.Count > 0)
                {
                    string tipo = ds.Tables["Aprendiz"].Rows[0]["tipoUser"].ToString().Trim();

                    if (tipo == "Aprendiz")
                    {
                        MessageBox.Show("Bienvenido(a) Aprendiz!");
                        new FormAprendiz().Show();
                        Estado_conexion = true;
                        return true;
                    }
                }

                // 🔹 NO ENCONTRADO
                MessageBox.Show("Usuario o contraseña incorrectos");
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
