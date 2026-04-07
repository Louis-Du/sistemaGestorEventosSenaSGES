using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SGES
{

    // FORMULARIO DE REGISTRO GRUPAL: CARGA APRENDICES DISPONIBLES, ARMA EL GRUPO Y ENVÍA EL REGISTRO FINAL
    public partial class FormRegistroGrupo : Form
    {
        private readonly int idEvento; // ID DEL EVENTO SELECCIONADO DESDE FORMAPRENDIZ
        private readonly int idAprActual; // ID DEL APRENDIZ QUE INICIÓ SESIÓN Y CUENTA COMO MIEMBRO DEL GRUPO
        private readonly DataTable dtGrupo; // TABLA TEMPORAL EN MEMORIA QUE GUARDA LOS COMPAÑEROS SELECCIONADOS

        public FormRegistroGrupo()
        {
            InitializeComponent();

            // VALORES POR DEFECTO PARA EVITAR ERRORES SI EL FORMULARIO SE ABRE SIN PARÁMETROS
            this.idEvento = 0;
            this.idAprActual = 0;

            // TABLA TEMPORAL QUE ALIMENTA EL DATAGRIDVIEW DE APRENDICES SELECCIONADOS
            dtGrupo = new DataTable();
            dtGrupo.Columns.Add("idApr", typeof(int));
            dtGrupo.Columns.Add("nombreApr", typeof(string));
            dtGrupo.Columns.Add("emailApr", typeof(string));

            // ENLAZA dtGrupo AL DATAGRIDVIEW DE LA DERECHA PARA MOSTRAR A LOS APRENDICES AGREGADOS
            var dgvMembers = this.Controls.Find("dataGridViewSelec", true).FirstOrDefault() as DataGridView;
            if (dgvMembers != null)
            {
                dgvMembers.AutoGenerateColumns = false;
                dgvMembers.DataSource = dtGrupo;
                dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        // CONSTRUCTOR PRINCIPAL: RECIBE EL ID DEL EVENTO Y EL ID DEL APRENDIZ ACTUAL DESDE FORMAPRENDIZ
        public FormRegistroGrupo(int idEvento, int idAprActual) : this()
        {
            this.idEvento = idEvento;
            this.idAprActual = idAprActual;
        }

        // CARGA EL LISTADO DE APRENDICES DISPONIBLES PARA EL EVENTO SELECCIONADO
        private void FormRegistroGrupo_Load(object sender, EventArgs e)
        {
            try
            {
                Consultas consulta = new Consultas();
                DataSet ds = consulta.ConsultarAprendicesDisponibles(idEvento, idAprActual);

                // ACEPTA EL NOMBRE DE TABLA DEVUELTO POR CONSULTAS PARA EVITAR ERRORES DE ENLACE
                string tabla = ds.Tables.Contains("Disponibles") ? "Disponibles" :
                               ds.Tables.Contains("Aprendices") ? "Aprendices" : null;

                if (tabla == null)
                {
                    MessageBox.Show("No se obtuvieron aprendices disponibles.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dataGridViewGrupo.AutoGenerateColumns = false;
                dataGridViewGrupo.DataSource = ds.Tables[tabla];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error cargando aprendices disponibles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BOTÓN VOLVER: CIERRA ESTE FORMULARIO Y REGRESA AL ANTERIOR
        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // AGREGA UN APRENDIZ DISPONIBLE AL DATAGRIDVIEW DE SELECCIONADOS
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1) VALIDAR QUE EXISTA UNA FILA SELECCIONADA EN EL GRID DE DISPONIBLES
            if (dataGridViewGrupo.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un aprendiz.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idApr;
            string nombreApr = string.Empty;
            string emailApr = string.Empty;

            // 3) PRIMER INTENTO: OBTENER LOS DATOS DESDE DATABOUNDITEM SI LA FILA ESTÁ ENLAZADA A UN DATATABLE
            if (dataGridViewGrupo.CurrentRow.DataBoundItem is DataRowView drv)
            {
                // VALIDACIÓN DE EXISTENCIA DE LA COLUMNA idApr EN EL ORIGEN DE DATOS
                if (!drv.Row.Table.Columns.Contains("idApr"))
                {
                    MessageBox.Show("La fuente no contiene la columna 'idApr'. Revisa el DataTable.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                idApr = Convert.ToInt32(drv["idApr"]);
                nombreApr = drv["nombreApr"]?.ToString() ?? string.Empty;
                emailApr = drv["emailApr"]?.ToString() ?? string.Empty;
            }
            else
            {
                // 4) FALLBACK: SI NO HAY DATABOUNDITEM, BUSCAR LOS DATOS DIRECTAMENTE EN LAS COLUMNAS VISIBLES DEL GRID
                DataGridViewCell cell = null;

                // BUSCAR LA COLUMNA QUE CONTIENE EL ID DEL APRENDIZ
                foreach (DataGridViewColumn col in dataGridViewGrupo.Columns)
                {
                    if (string.Equals(col.DataPropertyName, "idApr", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(col.Name, "idApr", StringComparison.OrdinalIgnoreCase))
                    {
                        cell = dataGridViewGrupo.CurrentRow.Cells[col.Index];
                        break;
                    }
                }

                // SI NO SE ENCUENTRA LA COLUMNA, USAR LA PRIMERA CELDA COMO ÚLTIMO RECURSO
                if (cell == null) cell = dataGridViewGrupo.CurrentRow.Cells[0];

                if (cell?.Value == null || !int.TryParse(cell.Value.ToString(), out idApr))
                {
                    MessageBox.Show("No se pudo leer el identificador del aprendiz seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // INTENTAR LEER TAMBIÉN NOMBRE Y CORREO PARA MOSTRARLOS EN EL GRID DE SELECCIONADOS
                var colNombre = dataGridViewGrupo.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => string.Equals(c.DataPropertyName, "nombreApr", StringComparison.OrdinalIgnoreCase) || string.Equals(c.Name, "nombreApr", StringComparison.OrdinalIgnoreCase));
                var colEmail = dataGridViewGrupo.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => string.Equals(c.DataPropertyName, "emailApr", StringComparison.OrdinalIgnoreCase) || string.Equals(c.Name, "emailApr", StringComparison.OrdinalIgnoreCase));

                if (colNombre != null) nombreApr = dataGridViewGrupo.CurrentRow.Cells[colNombre.Index].Value?.ToString() ?? string.Empty;
                if (colEmail != null) emailApr = dataGridViewGrupo.CurrentRow.Cells[colEmail.Index].Value?.ToString() ?? string.Empty;
            }

            // 5) EVITAR DUPLICADOS EN EL DATAGRIDVIEW DE SELECCIONADOS
            bool existe = dtGrupo.AsEnumerable().Any(r => r.Field<int>("idApr") == idApr);
            if (existe)
            {
                MessageBox.Show("Este aprendiz ya fue agregado al grupo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 6) AGREGAR EL APRENDIZ A LA TABLA TEMPORAL dtGrupo Y REFLEJARLO EN EL GRID DERECHO
            dtGrupo.Rows.Add(idApr, nombreApr, emailApr);
        }

        // QUITA UN APRENDIZ DEL GRUPO TEMPORAL ANTES DE REGISTRARLO EN BASE DE DATOS
        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // TOMAR LA SELECCIÓN DESDE EL GRID DE APRENDICES AGREGADOS
            var dgvMembers = this.Controls.Find("dataGridViewSelec", true).FirstOrDefault() as DataGridView;

            int? idAprSeleccionado = null;

            if (dgvMembers != null && dgvMembers.CurrentRow != null)
            {
                if (dgvMembers.CurrentRow.DataBoundItem is DataRowView drv)
                {
                    idAprSeleccionado = Convert.ToInt32(drv["idApr"]);
                }
                else
                {
                    object raw = dgvMembers.CurrentRow.Cells["dgSelApr"].Value;
                    if (raw != null && int.TryParse(raw.ToString(), out int idtmp))
                        idAprSeleccionado = idtmp;
                }
            }
            else if (dataGridViewGrupo.CurrentRow != null)
            {
                // FALLBACK: SI NO HAY SELECCIÓN EN EL GRID DERECHO, USAR LA DEL GRID IZQUIERDO
                if (dataGridViewGrupo.CurrentRow.DataBoundItem is DataRowView drv)
                {
                    idAprSeleccionado = Convert.ToInt32(drv["idApr"]);
                }
                else
                {
                    object raw = dataGridViewGrupo.CurrentRow.Cells["dgApr"].Value;
                    if (raw != null && int.TryParse(raw.ToString(), out int idtmp))
                        idAprSeleccionado = idtmp;
                }
            }

            if (!idAprSeleccionado.HasValue)
            {
                MessageBox.Show("Selecciona el aprendiz a quitar (en el listado de miembros o en disponibles).", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // BUSCAR Y ELIMINAR EN dtGrupo EL APRENDIZ QUE COINCIDA CON EL ID SELECCIONADO
            DataRow[] rows = dtGrupo.Select($"idApr = {idAprSeleccionado.Value}");
            if (rows.Length == 0)
            {
                MessageBox.Show("El aprendiz seleccionado no está en el grupo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var r in rows) r.Delete();
            dtGrupo.AcceptChanges();
            
        }

        // REGISTRA EL GRUPO COMPLETO: APRENDIZ ACTUAL + APRENDICES AGREGADOS EN EL GRID
        private void btnRegGrupo_Click(object sender, EventArgs e)
        {
            // VALIDAR QUE EL FORMULARIO RECIBIÓ EL EVENTO DESDE FORMAPRENDIZ
            if (idEvento == 0)
            {
                MessageBox.Show("No se encontró el evento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // VALIDAR QUE EL FORMULARIO RECIBIÓ EL APRENDIZ QUE INICIÓ SESIÓN
            if (idAprActual == 0)
            {
                MessageBox.Show("No se encontró el aprendiz que inició sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // VALIDAR MÍNIMO DE 2 COMPAÑEROS EN EL GRID PARA FORMAR UN GRUPO REAL DE 3 INTEGRANTES
            if (dtGrupo.Rows.Count < 2)
            {
                MessageBox.Show("Debes seleccionar mínimo 2 aprendices para registrar el grupo.");
                return;
            }

            // ARMAR LA LISTA FINAL DE IDS: PRIMERO EL APRENDIZ LOGUEADO Y LUEGO LOS COMPAÑEROS SELECCIONADOS
            var idsAprendices = new System.Collections.Generic.List<int> { idAprActual };

            foreach (DataRow row in dtGrupo.Rows)
            {
                idsAprendices.Add(Convert.ToInt32(row["idApr"]));
            }

            // ENVIAR LA LISTA COMPLETA A CONSULTAS PARA VALIDAR Y REGISTRAR EL GRUPO EN LA BASE DE DATOS
            Consultas consulta = new Consultas();
            bool ok = consulta.RegistrarInscripcionGrupo(idsAprendices, idEvento);

            if (ok)
            {
                this.Close();
            }
        }
    }
}
