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

                        int idApr = Convert.ToInt32(ds.Tables["Aprendiz"].Rows[0]["idApr"]);
                        FormAprendiz frm = new FormAprendiz(idApr, login);
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

        public void ActualizarEvento(int idEvent, string nombreEvent, string tipoEvent, DateTime fechaHoraEvent)
        {
            try
            {
                string query =
                    "UPDATE Eventos SET nombreEvento = @nombreEvent, tipoEvento = @tipoEvent, fechaEvento = @fechaEvent, horaEvento = @horaEvent " +
                    "WHERE idEvento = @idEvent"; // Asigna en una variable la consulta a realizar
                using (SqlCommand cmd = new SqlCommand(query, cn.Conectar())) // Consulta la variable query
                {
                    cmd.Parameters.AddWithValue("@idEvent", idEvent);
                    cmd.Parameters.AddWithValue("@nombreEvent", nombreEvent);
                    cmd.Parameters.AddWithValue("@tipoEvent", tipoEvent);
                    cmd.Parameters.AddWithValue("@fechaEvent", fechaHoraEvent.Date);
                    cmd.Parameters.AddWithValue("@horaEvent", fechaHoraEvent.TimeOfDay);
                    
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

        /// <summary>
        /// Comprueba si el aprendiz tiene alguna inscripción que solape con el evento indicado.
        /// </summary>
        public bool TieneConflicto(int idApr, int idEvento)
        {
            try
            {
                DataTable dt = new DataTable();
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT fechaEvento, horaEvento, ISNULL(duracionMinutos, 60) AS duracionMinutos FROM Eventos WHERE idEvento = @idEvento",
                    cn.Conectar()))
                {
                    cmd.Parameters.AddWithValue("@idEvento", idEvento);
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }

                if (dt.Rows.Count == 0) return false;

                DateTime fecha = Convert.ToDateTime(dt.Rows[0]["fechaEvento"]);
                TimeSpan hora = (TimeSpan)dt.Rows[0]["horaEvento"];
                int duracion = Convert.ToInt32(dt.Rows[0]["duracionMinutos"]);

                DateTime inicioNuevo = fecha.Date + hora;
                DateTime finNuevo = inicioNuevo.AddMinutes(duracion);

                string sql =
                    "SELECT COUNT(1) FROM Inscripciones i " +
                    "JOIN Eventos e ON i.idEvento = e.idEvento " +
                    "WHERE i.idApr = @idApr AND e.idEvento <> @idEvento " +
                    "AND NOT (DATEADD(minute, ISNULL(e.duracionMinutos, 60), CAST(e.fechaEvento AS DATETIME) + CAST(e.horaEvento AS DATETIME)) <= @inicioNuevo " +
                    "OR CAST(e.fechaEvento AS DATETIME) + CAST(e.horaEvento AS DATETIME) >= @finNuevo)";

                using (SqlCommand cmd2 = new SqlCommand(sql, cn.Conectar()))
                {
                    cmd2.Parameters.AddWithValue("@idApr", idApr);
                    cmd2.Parameters.AddWithValue("@idEvento", idEvento);
                    cmd2.Parameters.AddWithValue("@inicioNuevo", inicioNuevo);
                    cmd2.Parameters.AddWithValue("@finNuevo", finNuevo);

                    int count = Convert.ToInt32(cmd2.ExecuteScalar());
                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true; // por seguridad, tratar error como conflicto
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

        /// <summary>
        /// Registra la inscripción tras validar duplicado y conflicto de horarios.
        /// Genera idInscrip con MAX+1 dentro de una transacción para reducir collisions.
        /// Mantiene ids manuales por decisión de rama.
        /// </summary>
        public bool RegistrarInscripcion(int idApr, int idEvento, string modalidad = "Presencial", int idGrupo = 1)
        {
            try
            {
                // 1) Duplicado (comprobación rápida)
                using (SqlCommand chk = new SqlCommand("SELECT COUNT(1) FROM Inscripciones WHERE idApr = @idApr AND idEvento = @idEvento", cn.Conectar()))
                {
                    chk.Parameters.AddWithValue("@idApr", idApr);
                    chk.Parameters.AddWithValue("@idEvento", idEvento);
                    int existe = Convert.ToInt32(chk.ExecuteScalar());
                    if (existe > 0)
                    {
                        MessageBox.Show("Ya estás inscrito en este evento.");
                        return false;
                    }
                }

                // 2) Conflicto horario
                if (TieneConflicto(idApr, idEvento))
                {
                    MessageBox.Show("No puedes inscribirte: el evento entra en conflicto con otra inscripción.");
                    return false;
                }

                // 3) Generar nuevo idInscrip y insertar dentro de una transacción
                int nuevoId = 0;
                string insert = "INSERT INTO Inscripciones (idInscrip, fechaInscrip, modalidadInscrip, idApr, idEvento, idGrupo) " +
                                "VALUES (@idInscrip, @fechaInscrip, @modalidad, @idApr, @idEvento, @idGrupo)";

                // Abrimos conexión manualmente para controlar la transacción
                SqlConnection conn = cn.Conectar();
                using (SqlTransaction tran = conn.BeginTransaction())
                {
                    try
                    {
                        using (SqlCommand maxCmd = new SqlCommand("SELECT ISNULL(MAX(idInscrip), 0) + 1 FROM Inscripciones", conn, tran))
                        {
                            nuevoId = Convert.ToInt32(maxCmd.ExecuteScalar());
                        }

                        using (SqlCommand cmdIns = new SqlCommand(insert, conn, tran))
                        {
                            cmdIns.Parameters.AddWithValue("@idInscrip", nuevoId);
                            cmdIns.Parameters.AddWithValue("@fechaInscrip", DateTime.Now.Date);
                            cmdIns.Parameters.AddWithValue("@modalidad", modalidad);
                            cmdIns.Parameters.AddWithValue("@idApr", idApr);
                            cmdIns.Parameters.AddWithValue("@idEvento", idEvento);
                            cmdIns.Parameters.AddWithValue("@idGrupo", idGrupo);

                            cmdIns.ExecuteNonQuery();
                        }

                        tran.Commit();
                    }
                    catch (Exception)
                    {
                        try { tran.Rollback(); } catch { /* ignored */ }
                        throw;
                    }
                }

                MessageBox.Show("Inscripción realizada correctamente.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                cn.Desconectar();
            }
        }
    }
}