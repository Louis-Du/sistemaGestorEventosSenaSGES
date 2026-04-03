using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGES
{
    internal class Consultas
    {
        // Conexión reutilizable
        private readonly Conexion cn = new Conexion();

        // Si quieres conservar este estado:
        private Boolean Estado_conexion = false;

        public Boolean Iniciar_sesion(int idUser, string contraseñaUser, FormLogin login)
        {
            DataSet ds = new DataSet();

            try
            {
                ds.Tables.Clear();

                // 🔹 BUSCAR EN USUARIO (ADMIN)
                using (SqlCommand query = new SqlCommand(
                    "SELECT idUser, tipoUser FROM Usuario WHERE idUser=@idUser AND contraseñaUser=@contraseñaUser",
                    cn.Conectar()))
                {
                    query.Parameters.AddWithValue("@idUser", idUser);
                    query.Parameters.AddWithValue("@contraseñaUser", contraseñaUser);

                    using (SqlDataAdapter da = new SqlDataAdapter(query))
                    {
                        da.Fill(ds, "Usuario");
                    }
                }

                if (ds.Tables["Usuario"].Rows.Count > 0)
                {
                    string tipo = ds.Tables["Usuario"].Rows[0]["tipoUser"].ToString().Trim();
                    if (tipo == "Administrador")
                    {
                        MessageBox.Show("Bienvenido(a) Administrador!");
                        Estado_conexion = true;

                        FormAdmin frm = new FormAdmin();
                        frm.Show();

                        login.Hide(); // 🔥 ocultas el login

                        return true;
                    }
                }

                // 🔹 BUSCAR EN APRENDIZ
                ds.Tables.Clear();

                using (SqlCommand query2 = new SqlCommand(
                    "SELECT idApr, tipoUser FROM Aprendiz WHERE idApr=@idUser AND contraseñaUser=@contraseñaUser",
                    cn.Conectar()))
                {
                    query2.Parameters.AddWithValue("@idUser", idUser);
                    query2.Parameters.AddWithValue("@contraseñaUser", contraseñaUser);

                    using (SqlDataAdapter da2 = new SqlDataAdapter(query2))
                    {
                        da2.Fill(ds, "Aprendiz");
                    }
                }

                if (ds.Tables["Aprendiz"].Rows.Count > 0)
                {
                    string tipo = ds.Tables["Aprendiz"].Rows[0]["tipoUser"].ToString().Trim();
                    if (tipo == "Aprendiz")
                    {
                        MessageBox.Show("Bienvenido(a) Aprendiz!");
                        Estado_conexion = true;

                        FormAprendiz frm = new FormAprendiz();
                        frm.Show();

                        login.Hide();

                        return true;

                    }
                }

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

        public DataSet ConsultarEventos()
        {
            DataSet ds = new DataSet();

            try
            {
                /*
                 * Palabras claves:
                 * - using
                 * - Fill
                 * - SqlDataAdapter
                 */
                using (SqlCommand consulta = new SqlCommand("SELECT * FROM Eventos", cn.Conectar())) // Consulta los eventos registrados en la base de datos
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(consulta))
                    {
                        da.Fill(ds, "Eventos"); // Ejecuta la consulta
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

            return ds;
        }

        public void InsertarEvento(int idEvent, string nombreEvent, string tipoEvent, DateTime fechaHoraEvent, int idUser)
        {
            try
            {
                string query =
                    "INSERT INTO Eventos (idEvento, nombreEvento, tipoEvento, fechaEvento, horaEvento, idUser) " +
                    "VALUES (@idEvent, @nombreEvent, @tipoEvent, @fechaEvent, @horaEvent, @idUser)"; // Asigna en una variable la consulta a realizar

                using (SqlCommand cmd = new SqlCommand(query, cn.Conectar())) // Consulta la variable query
                {
                    cmd.Parameters.AddWithValue("@idEvent", idEvent);
                    cmd.Parameters.AddWithValue("@nombreEvent", nombreEvent);
                    cmd.Parameters.AddWithValue("@tipoEvent", tipoEvent);
                    cmd.Parameters.AddWithValue("@fechaEvent", fechaHoraEvent.Date);
                    cmd.Parameters.AddWithValue("@horaEvent", fechaHoraEvent.TimeOfDay);
                    cmd.Parameters.AddWithValue("@idUser", idUser);

                    cmd.ExecuteNonQuery();
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
        }

        public DataSet ConsultarAprendicesRegistrados(int idEvento)
        {
            DataSet ds = new DataSet();

            try
            {
                string query =
                    "SELECT a.idApr, a.nombreApr, a.emailApr " +
                    "FROM Inscripciones i " +
                    "JOIN Aprendiz a ON i.idApr = a.idApr " +
                    "WHERE i.idEvento = @idEvento"; // Asigna en una variable los aprendices registrados a un evento

                using (SqlCommand cmd = new SqlCommand(query, cn.Conectar()))  // Consulta la variable query
                {
                    cmd.Parameters.AddWithValue("@idEvento", idEvento);

                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(ds, "Aprendices");
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

            return ds;
        }

        // Función para eliminar eventos
        public void EliminarEvento(int idEvento)
        {
            if (VerificarInscriptos(idEvento) > 0)
            {
                DialogResult result = MessageBox.Show("¡Cuidado!: Hay aprendices inscriptos a este evento. ¿De verdad deseas eliminarlo?", "SGDF", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    // En caso de que acepte eliminar el evento a pesar de tener inscriptos se eliminan los inscriptos y el evento
                    string eliminarInscripcion = "DELETE FROM Inscripciones WHERE idEvento = @idEvento";
                    using (SqlCommand consulta1 = new SqlCommand(eliminarInscripcion, cn.Conectar()))
                    {
                        consulta1.Parameters.AddWithValue("@idEvento", idEvento);
                        consulta1.ExecuteNonQuery();
                    }

                    // Eliminamos el evento
                    string eliminarEvento = "DELETE FROM Eventos WHERE idEvento = @idEvento";
                    using (SqlCommand consulta2 = new SqlCommand(eliminarEvento, cn.Conectar()))
                    {
                        consulta2.Parameters.AddWithValue("@idEvento", idEvento);
                        consulta2.ExecuteNonQuery();
                    }
                    MessageBox.Show("¡Evento eliminado con éxito!");
                }
            }
            else
            {
                string eliminarEvento = "DELETE FROM Eventos WHERE idEvento = @idEvento";
                using (SqlCommand consulta = new SqlCommand(eliminarEvento, cn.Conectar()))
                {
                    consulta.Parameters.AddWithValue("@idEvento", idEvento);
                    consulta.ExecuteNonQuery();
                }
                MessageBox.Show("¡Evento eliminado con éxito!");
            }
        }

        // Función para everificar existencia de inscriptos para eliminarlos
        public int VerificarInscriptos(int idEvento)
        {
            DataSet ds = new DataSet();
            int count = 0;

            try
            {
                // Primero validamos si existe alguna inscripción en el evento
                string verificarInscripciones = "SELECT COUNT(1) FROM Inscripciones WHERE idEvento = @idEvento";

                using (SqlCommand consulta = new SqlCommand(verificarInscripciones, cn.Conectar()))
                {
                    consulta.Parameters.AddWithValue("@idEvento", idEvento);
                    count = Convert.ToInt32(consulta.ExecuteScalar());
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
            return count;
        }
    }
}