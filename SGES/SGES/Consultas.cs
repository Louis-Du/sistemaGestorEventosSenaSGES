using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace SGES
{
    class Consultas
    {
        Conexion cn = new Conexion();
        SqlDataAdapter da = new SqlDataAdapter();

        SqlCommand consulta;

        public DataSet ConsultarEventos()
        {
            DataSet ds = new DataSet();

            consulta = new SqlCommand("SELECT * FROM Eventos", cn.Conectar());
            consulta.CommandType = CommandType.Text;

            da = new SqlDataAdapter(consulta);
            da.Fill(ds, "Eventos");

            return ds;
        }

        public void InsertarEvento(int idEvent, string nombreEvent, string tipoEvent, DateTime fechaHoraEvent, int idUser)
        {
            Conexion cn = new Conexion();
            string query = "INSERT INTO Eventos (idEvento, nombreEvento, tipoEvento, fechaEvento, horaEvento, idUser)" + "VALUES (@idEvent, @nombreEvent, @tipoEvent, @fechaEvent, @horaEvent, @idUser)";
            SqlCommand cmd = new SqlCommand(query, cn.Conectar());

            cmd.Parameters.AddWithValue("@idEvent", idEvent);
            cmd.Parameters.AddWithValue("@nombreEvent", nombreEvent);
            cmd.Parameters.AddWithValue("@tipoEvent", tipoEvent);
            cmd.Parameters.AddWithValue("@fechaEvent", fechaHoraEvent.Date);
            cmd.Parameters.AddWithValue("@horaEvent", fechaHoraEvent.TimeOfDay);
            cmd.Parameters.AddWithValue("@idUser", idUser);

            cmd.ExecuteNonQuery();

        }

        public DataSet ConsultarAprendicesRegistrados(int idEvento)
        {
            DataSet ds = new DataSet();

            Conexion cn = new Conexion();
            {
                string query = "SELECT a.idApr, a.nombreApr, a.emailApr " +
                               "FROM Inscripciones i " +
                               "JOIN Aprendiz a ON i.idApr = a.idApr " +
                               "WHERE i.idEvento = @idEvento";

                SqlCommand cmd = new SqlCommand(query, cn.Conectar());
                cmd.Parameters.AddWithValue("@idEvento", idEvento);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "Aprendices");
            }

            return ds;
        }


    }
}
