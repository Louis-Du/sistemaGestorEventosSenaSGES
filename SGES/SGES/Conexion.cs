using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SGES
{
    internal class Conexion
    {
        SqlConnection con;  // Variable para la conexión a la base de datos

        public SqlConnection Conectar()
        {
            try
            {
                // Cadena de conexión: Data Source indica el servidor/instancia, Initial Catalog la base de datos.
                con = new SqlConnection("Data Source=DESKTOP-HFUIK0O\\SQLEXPRESS;Initial Catalog=SGES;Integrated Security=True");
                con.Open(); // Abrir la conexión
            }
            catch (Exception e)
            {
                // Mostrar cualquier error que ocurra al intentar conectar.
                MessageBox.Show(e.Message); // Mostrar mensaje de error en caso de excepción
            }
            return con; // Retornar la conexión (puede ser null si la apertura falló)
        }

        public void Desconectar()
        {
            con.Close(); // Cerrar la conexión si está abierta
        }
    }
}