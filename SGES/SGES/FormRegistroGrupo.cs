using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SGES
{
    public partial class FormRegistroGrupo : Form
    {
        private readonly int idEvento; // id del evento para el que se registra el grupo
        private readonly int idAprActual; // aprendiz que inició sesión
        private readonly DataTable dtGrupo; // almacena los miembros seleccionados

        public FormRegistroGrupo()
        {
            InitializeComponent();

            // No asignar this.idEvento = idEvento aquí (era un bug)
            this.idEvento = 0;
            this.idAprActual = 0;

            // Inicializar tabla de miembros del grupo
            dtGrupo = new DataTable();
            dtGrupo.Columns.Add("idApr", typeof(int));
            dtGrupo.Columns.Add("nombreApr", typeof(string));
            dtGrupo.Columns.Add("emailApr", typeof(string));

            // Si existe un DataGridView para mostrar los miembros (nombre típico: dataGridViewMiembros),
            // lo enlazamos automáticamente para que el diseñador no tenga que cambiar nada.
            var dgvMembers = this.Controls.Find("dataGridViewSelec", true).FirstOrDefault() as DataGridView;
            if (dgvMembers != null)
            {
                dgvMembers.AutoGenerateColumns = false;
                dgvMembers.DataSource = dtGrupo;
                dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
        }

        // Constructor que permite pasar el idEvento desde el formulario padre (recomendado)
        public FormRegistroGrupo(int idEvento, int idAprActual) : this()
        {
            this.idEvento = idEvento;
            this.idAprActual = idAprActual;
        }

        private void FormRegistroGrupo_Load(object sender, EventArgs e)
        {
            try
            {
                Consultas consulta = new Consultas();
                DataSet ds = consulta.ConsultarAprendicesDisponibles(idEvento, idAprActual);

                // Aceptamos tanto "Disponibles" como "Aprendices" según cómo implemente el método
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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // 1) Validar selección
            if (dataGridViewGrupo.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un aprendiz.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int idApr;
            string nombreApr = string.Empty;
            string emailApr = string.Empty;

            // 2) Intento preferente: obtener desde DataBoundItem (DataRowView)
            if (dataGridViewGrupo.CurrentRow.DataBoundItem is DataRowView drv)
            {
                // Comprueba que la columna exista en el DataTable
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
                // 3) Fallback: buscar la celda por DataPropertyName o por Name
                DataGridViewCell cell = null;

                // buscar columna cuyo DataPropertyName sea "idApr"
                foreach (DataGridViewColumn col in dataGridViewGrupo.Columns)
                {
                    if (string.Equals(col.DataPropertyName, "idApr", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(col.Name, "idApr", StringComparison.OrdinalIgnoreCase))
                    {
                        cell = dataGridViewGrupo.CurrentRow.Cells[col.Index];
                        break;
                    }
                }

                // Si no se encontró, usar la primera celda por si el id está en la primera columna
                if (cell == null) cell = dataGridViewGrupo.CurrentRow.Cells[0];

                if (cell?.Value == null || !int.TryParse(cell.Value.ToString(), out idApr))
                {
                    MessageBox.Show("No se pudo leer el identificador del aprendiz seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Intentar leer nombre/email si existen columnas con esos DataPropertyName
                var colNombre = dataGridViewGrupo.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => string.Equals(c.DataPropertyName, "nombreApr", StringComparison.OrdinalIgnoreCase) || string.Equals(c.Name, "nombreApr", StringComparison.OrdinalIgnoreCase));
                var colEmail = dataGridViewGrupo.Columns.Cast<DataGridViewColumn>().FirstOrDefault(c => string.Equals(c.DataPropertyName, "emailApr", StringComparison.OrdinalIgnoreCase) || string.Equals(c.Name, "emailApr", StringComparison.OrdinalIgnoreCase));

                if (colNombre != null) nombreApr = dataGridViewGrupo.CurrentRow.Cells[colNombre.Index].Value?.ToString() ?? string.Empty;
                if (colEmail != null) emailApr = dataGridViewGrupo.CurrentRow.Cells[colEmail.Index].Value?.ToString() ?? string.Empty;
            }

            // 4) Evitar duplicados en dtGrupo
            bool existe = dtGrupo.AsEnumerable().Any(r => r.Field<int>("idApr") == idApr);
            if (existe)
            {
                MessageBox.Show("Este aprendiz ya fue agregado al grupo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 5) Validar máximo 2 miembros
            if (dtGrupo.Rows.Count >= 2)
            {
                MessageBox.Show("Solo puedes seleccionar máximo 2 aprendices para el grupo.");
                return;
            }



            // 6) Agregar
            dtGrupo.Rows.Add(idApr, nombreApr, emailApr);
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            // Intentar quitar según selección en el DataGridView de seleccion 
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
                // Fallback: usar la selección del grid de disponibles para quitar el mismo aprendiz del grupo
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

            // Buscar y eliminar filas en dtGrupo con ese idApr
            DataRow[] rows = dtGrupo.Select($"idApr = {idAprSeleccionado.Value}");
            if (rows.Length == 0)
            {
                MessageBox.Show("El aprendiz seleccionado no está en el grupo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var r in rows) r.Delete();
            dtGrupo.AcceptChanges();
        }

        private void btnRegGrupo_Click(object sender, EventArgs e)
        {
            if (idEvento == 0)
            {
                MessageBox.Show("No se encontró el evento seleccionado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (idAprActual == 0)
            {
                MessageBox.Show("No se encontró el aprendiz que inició sesión.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtGrupo.Rows.Count != 2)
            {
                MessageBox.Show("Debes seleccionar exactamente 2 aprendices para completar el grupo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var idsAprendices = new System.Collections.Generic.List<int> { idAprActual };

            foreach (DataRow row in dtGrupo.Rows)
            {
                idsAprendices.Add(Convert.ToInt32(row["idApr"]));
            }

            Consultas consulta = new Consultas();
            bool ok = consulta.RegistrarInscripcionGrupo(idsAprendices, idEvento);

            if (ok)
            {
                this.Close();
            }
        }
    }
}
