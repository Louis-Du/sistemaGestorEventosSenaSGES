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
    class Conexion
    {
        SqlConnection con;
        public SqlConnection Conectar()
        {
            try
            {
                con = new SqlConnection("Data Source=.\\SQLEXPRESS01; Initial Catalog=SGES3; Integrated Security=True");
                con.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return con;
        }

        public void Cerrar()
        {
            con.Close();
        }
    }
}
