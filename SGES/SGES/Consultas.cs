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
                using (SqlCommand consulta = new SqlCommand("SELECT * FROM Eventos", cn.Conectar()))
                {
                    consulta.CommandType = CommandType.Text;

                    using (SqlDataAdapter da = new SqlDataAdapter(consulta))
                    {
                        da.Fill(ds, "Eventos");
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
                    "VALUES (@idEvent, @nombreEvent, @tipoEvent, @fechaEvent, @horaEvent, @idUser)";

                using (SqlCommand cmd = new SqlCommand(query, cn.Conectar()))
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
                    "WHERE i.idEvento = @idEvento";

                using (SqlCommand cmd = new SqlCommand(query, cn.Conectar()))
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
        public void ActualizarContraseña(int idUser, string newPassword)
        {
            try
            {
                using (SqlConnection con = cn.Conectar())
                {
                    // 🔹 Usuario
                    string query1 = "UPDATE Usuario SET contraseñaUser = @newPassword WHERE idUser = @idUser";

                    using (SqlCommand cmd1 = new SqlCommand(query1, con))
                    {
                        cmd1.Parameters.Add("@idUser", SqlDbType.Int).Value = idUser;
                        cmd1.Parameters.Add("@newPassword", SqlDbType.VarChar).Value = newPassword;

                        int filas = cmd1.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada correctamente");
                            return;
                        }
                    }

                    // 🔹 Aprendiz
                    string query2 = "UPDATE Aprendiz SET contraseñaUser = @newPassword WHERE idApr = @idUser";

                    using (SqlCommand cmd2 = new SqlCommand(query2, con))
                    {
                        cmd2.Parameters.Add("@idApr", SqlDbType.Int).Value = idUser;
                        cmd2.Parameters.Add("@pass", SqlDbType.VarChar).Value = newPassword;

                        int filas = cmd2.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Contraseña actualizada correctamente");
                            return;
                        }
                    }

                    MessageBox.Show("No se encontró el usuario");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.Desconectar();
            }
        }

        public bool VerificarUsuario(int idUser, string emailUser) // Método para recuperar cuenta
        {
            try
            {
                using (SqlConnection con = cn.Conectar())
                {
                    // 🔹 Buscar en Usuario
                    string query1 = "SELECT 1 FROM Usuario WHERE idUser=@idUser AND emailUser=@emailUser";
                    using (SqlCommand cmd = new SqlCommand(query1, con))
                    {
                        cmd.Parameters.Add("@idUser", SqlDbType.Int).Value = idUser;
                        cmd.Parameters.Add("@emailUser", SqlDbType.VarChar).Value = emailUser;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                                return true;
                        }
                    }

                    // 🔹 Buscar en Aprendiz
                    string query2 = "SELECT 1 FROM Aprendiz WHERE idApr=@id AND emailApr=@emailUser";

                    using (SqlCommand cmd2 = new SqlCommand(query2, con)) // Reutiliza la misma conexión para evitar abrir y cerrar múltiples veces
                    {
                        cmd2.Parameters.Add("@id", SqlDbType.Int).Value = idUser;
                        cmd2.Parameters.Add("@emailUser", SqlDbType.VarChar).Value = emailUser;

                        using (SqlDataReader reader2 = cmd2.ExecuteReader()) // Ejecuta la consulta para el aprendiz
                        {
                            if (reader2.Read())
                                return true;
                        }
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

            return false;
        }
    }
    
}