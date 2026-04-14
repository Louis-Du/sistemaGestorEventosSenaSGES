using System;
using System.Data;
using System.Windows.Forms;

namespace SGES
{

    // FORMULARIO APRENDIZ: MUESTRA LOS EVENTOS DISPONIBLES Y PERMITE REGISTRARSE EN ELLOS
    public partial class FormAprendiz : Form
    {
        private readonly FormLogin login; // REFERENCIA AL FORMULARIO DE LOGIN PARA POSIBLES INTERACCIONES FUTURAS
        private readonly int idApr; //ID DEL APRENDIZ OBTENIDO EN LOGIN, SE USA PARA REGISTRAR INSCRIPCIONES CON SU ID

        // CONSTRUCTORES: SE DEJAN LOS SOBRECARGADOS PORQUE SOLO ES PARA PRUEBAS
        //{
        //    InitializeComponent();
        //}

        //public FormAprendiz(FormLogin login)
        //{
        //    InitializeComponent(); 
        //    this.login = login;
        //}

        // CONSTRUCTOR PRINCIPAL: RECIBE ID DEL APRENDIZ (OBTENIDO EN LOGIN) Y REFERENCIA AL FORMULARIO DE LOGIN
        public FormAprendiz(int idApr, FormLogin login)
        {
            InitializeComponent(); // obligatorio para evitar null refs en controles
            this.idApr = idApr;
            this.login = login;
        }

        // CARGA DE EVENTOS EN EL DATAGRIDVIEW
        private void FormAprendiz_Load(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            DataSet ds = consulta.ConsultarEventos();
            // Filtrar eventos solo con inscripción vigente
            DataTable eventos = ds.Tables["Eventos"];
            DateTime ahora = DateTime.Now;
            var eventosDisponibles = eventos.AsEnumerable()
                .Where(r =>
                    r.Field<DateTime>("fechaHoraInicioInscripcion") <= ahora &&
                    r.Field<DateTime>("fechaHoraFinInscripcion") >= ahora
                );
            DataTable dtFiltrado = eventosDisponibles.Any() ? eventosDisponibles.CopyToDataTable() : eventos.Clone();
            dataGridViewAprend.AutoGenerateColumns = false;
            dataGridViewAprend.DataSource = dtFiltrado;
            idEvento.DataPropertyName = "idEvento";
            Nombre.DataPropertyName = "nombreEvento";
            categoriaEvento.DataPropertyName = "categoriaEvento";
            cantIntegrantes.DataPropertyName = "cantIntegrantes";
            Tipo.DataPropertyName = "tipoEvento";
            fechaHoraInicio.DataPropertyName = "fechaHoraInicio";
            FechaHoraFin.DataPropertyName = "fechaHoraFin"; 

            dataGridViewAprend.DataSource = ds.Tables["Eventos"];
            dataGridViewAprend.SelectionChanged += dataGridViewAprend_SelectionChanged;
            ActualizarBotonesSegunCategoria();
        }

        // BOTÓN PARA VOLVER AL LOGIN (CIERRE DE SESIÓN)
        private void btnVolver_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea volver al login?", "Confirmar cierre de sesión", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                FormLogin form = new FormLogin();
                form.ShowDialog();
            }
        }

        private void dataGridViewAprend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // MANEJO DE CLICKS (NO SE UTILIZA)
        }

        // ACTUALIZA EL ESTADO DE LOS BOTONES SEGÚN LA CATEGORÍA DEL EVENTO SELECCIONADO
        private void dataGridViewAprend_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarBotonesSegunCategoria();
        }

        // SI EL EVENTO ES INDIVIDUAL SOLO HABILITA EL REGISTRO INDIVIDUAL; SI ES GRUPAL SOLO HABILITA EL REGISTRO GRUPAL
        private void ActualizarBotonesSegunCategoria()
        {
            btnRegistrarme.Enabled = false;
            btnRegGrupo.Enabled = false;

            if (dataGridViewAprend.CurrentRow == null) return;

            string categoriaEvento = string.Empty;

            if (dataGridViewAprend.CurrentRow.DataBoundItem is DataRowView drv && drv.Row.Table.Columns.Contains("categoriaEvento"))
            {
                categoriaEvento = drv["categoriaEvento"]?.ToString() ?? string.Empty;
            }
            else if (dataGridViewAprend.Columns.Contains("categoriaEvento"))
            {
                categoriaEvento = dataGridViewAprend.CurrentRow.Cells["categoriaEvento"].Value?.ToString() ?? string.Empty;
            }

            if (categoriaEvento == "Individual")
            {
                btnRegistrarme.Enabled = true;
            }
            else if (categoriaEvento == "Grupal")
            {
                btnRegGrupo.Enabled = true;
            }
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            // BOTON DE REGISTRO

           // LOGICA DE REGISTRO CONSIDERANDO LAS SIGUIENTES CONDICIONALES

            // 1) VERIFICA SI SE TOMO EL ID DEL APRENDIZ DEL INCIO DE SESIÓN (ID APRENDIZ DEBE SER MAYOR A 0)
            if (idApr == 0)
            {
                MessageBox.Show("Identificador del aprendiz no disponible. Asegúrate de iniciar sesión correctamente.");
                return;
            }

            // 2) VALIDAR FILA SELECCIONADA EN EL DATAGRIDVIEW
            if (dataGridViewAprend.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un evento para registrarte.");
                return;
            }

            // 3) OBTENER ID DEL EVENTO DE FORMA ROBUSTA (PRIMERO INTENTAR DESDE DataBoundItem, LUEGO POR NOMBRE DE COLUMNA, Y FINALMENTE POR CELDA)
            object rawIdEvento = null;

            // CAPTURA EL ID DEL EVENTO CON LA FUNCION DE DATABOUNDITEM, SI ESTA ENLAZADO AL DATAGRIDVIEW
            if (dataGridViewAprend.CurrentRow.DataBoundItem is DataRowView drv)
            {
                // VALIDACION DE CONTENIDO DE LA COLUMNA TENGO "IDEVENTO" EN EL DATATABLE
                if (drv.Row.Table.Columns.Contains("idEvento"))
                {
                    rawIdEvento = drv["idEvento"];
                }
            }

            // CONDICIONAL 1: si la columna existe en el DataGridView, obtener por nombre de columna
            if (rawIdEvento == null && dataGridViewAprend.Columns.Contains("idEvento"))
            {
                rawIdEvento = dataGridViewAprend.CurrentRow.Cells["idEvento"].Value;
            }

            // CONDICIONAL 2: usar la primera celda (mantener compatibilidad con diseños simples)
            if (rawIdEvento == null)
            {
                rawIdEvento = dataGridViewAprend.CurrentRow.Cells[0].Value;
            }

            // CONDICIONAL 3: verificar que se obtuvo un valor y que es un entero válido
            if (rawIdEvento == null || !int.TryParse(rawIdEvento.ToString(), out int idEvento))
            {
                MessageBox.Show("No se pudo obtener el identificador del evento seleccionado. Verifica las columnas del DataGridView y el nombre 'idEvento'.");
                return;
            }

            // 4) MENSAJE DE CONFIRMACION Y CON RETURN SI EL USUARIO NO CONFIRMA
            var confirm = MessageBox.Show("¿Deseas registrarte en el evento seleccionado?", "Confirmar inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // 5) LLAMADA A MÉTODO DE REGISTRO EN LA BASE DE DATOS 
            Consultas consulta = new Consultas();
            bool ok = consulta.RegistrarInscripcion(idApr, idEvento);

            // YA EL METODO MUESTRA MENSAJES DE CONFIRMACIÓN O ERROR, ASÍ QUE AQUÍ SOLO SE PUEDE REALIZAR ACCIONES POST-REGISTRO (EJ: DESHABILITAR BOTÓN, REFRESCAR GRID, ETC)
            if (ok)
            {
                // SI EL REGISTRO FUE EXITOSO, REFRESCA EL ESTADO DE LOS BOTONES SEGÚN EL EVENTO ACTUAL
                ActualizarBotonesSegunCategoria();
                // Si quieres refrescar el grid: volver a cargar eventos
                // FormAprendiz_Load(this, EventArgs.Empty);
            }
        }

        /* BOTON DE REGISTRO EN GRUPO MISMA LOGICA DE VALIDACION 
         * AL BOTON DE REGISTRO INDIVIDUAL PERO ABRE UN NUEVO FORMULARIO
         */
        private void btnRegistrarmeEnGrupo_Click(object sender, EventArgs e)
        {
            
            if (dataGridViewAprend.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un evento antes de registrar un grupo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            object rawIdEvento = null;

            if (dataGridViewAprend.CurrentRow.DataBoundItem is DataRowView drv)
            {
                if (drv.Row.Table.Columns.Contains("idEvento"))
                    rawIdEvento = drv["idEvento"];
            }

            if (rawIdEvento == null && dataGridViewAprend.Columns.Contains("idEvento"))
            {
                rawIdEvento = dataGridViewAprend.CurrentRow.Cells["idEvento"].Value;
            }

            if (rawIdEvento == null)
            {
                rawIdEvento = dataGridViewAprend.CurrentRow.Cells[0].Value;
            }

            if (rawIdEvento == null || !int.TryParse(rawIdEvento.ToString(), out int idEventoSeleccionado))
            {
                MessageBox.Show("No se pudo obtener el identificador del evento seleccionado. Verifica la selección y las columnas del grid.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ABRE EL FORMULARIO DE REGISTRO EN GRUPO USANDO LA ID DE EVENTO Y APRENDIZ SELECCIONADOS
            try
            {
                int cantidadIntegrantes = Convert.ToInt32(dataGridViewAprend.CurrentRow.Cells["cantIntegrantes"].Value); // convierte la columna cantIntegrantes en entero

                using (var frm = new FormRegistroGrupo(idEventoSeleccionado, idApr, cantidadIntegrantes))
                {
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo abrir el formulario de registro en grupo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
