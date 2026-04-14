using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGES
{
    public partial class FormAdmin : Form
    {
        Conexion cn = new Conexion();
        Consultas co = new Consultas();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        private FormLogin login;

        int idUsuario;
        public FormAdmin(int idUser)
        {
            InitializeComponent();
            this.idUsuario = idUser;
        }

        public FormAdmin(FormLogin login)
        {
            this.login = login;
        }

        // Carga todos los eventos registrados en la base de datos al entrar en el formulario
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                // Configuración y relación entre las columnas de el grid y la tabla en la base de datos
                dataGridViewAdmin.AutoGenerateColumns = false;
                ds = co.ConsultarEventos();
                dataGridViewAdmin.DataSource = ds;
                dataGridViewAdmin.DataMember = "Eventos";

                idEvento.DataPropertyName = "idEvento";
                Nombre.DataPropertyName = "nombreEvento";
                categoriaEvento.DataPropertyName = "categoriaEvento";
                cantIntegrantes.DataPropertyName = "cantIntegrantes";
                Tipo.DataPropertyName = "tipoEvento";
                fechaHoraInicio.DataPropertyName = "fechaHoraInicio";
                FechaHoraFin.DataPropertyName = "fechaHoraFin";
                fechaHoraInicioInscripcion.DataPropertyName = "fechaHoraInicioInscripcion";
                fechaHoraFinInscripcion.DataPropertyName = "fechaHoraFinInscripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearEvent_Click(object sender, EventArgs e)
        {
            FormCrearEvento form = new FormCrearEvento(idUsuario); // Envia el id del usuario con el que se inició sesión
            form.ShowDialog();

            dataGridViewAdmin.DataSource = co.ConsultarEventos(); // Mantine los eventos en el grid del formulario administrador
            dataGridViewAdmin.DataMember = "Eventos";
        }

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

        private void btnEliminarEvent_Click(object sender, EventArgs e)
        {
            int idEvento = int.Parse(dataGridViewAdmin.CurrentRow.Cells["idEvento"].Value.ToString());

            DialogResult result = MessageBox.Show("¿Estás seguro de que desea eliminar el evento? El evento se eliminará y no se podrá recuperar", "SGDF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                co.EliminarEvento(idEvento);
                dataGridViewAdmin.DataSource = co.ConsultarEventos(); // Mantine los eventos en el grid del formulario administrador
                dataGridViewAdmin.DataMember = "Eventos";
            }
        }

        private void dataGridViewAdmin_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        // Función que permite abrir el formulario con los aprendices registrados a un evento seleccionado
        private void btnConsultarAprendicesRegistrados_Click_1(object sender, EventArgs e)
        {
            try
            {
                int idEvento = int.Parse(dataGridViewAdmin.CurrentRow.Cells["idEvento"].Value.ToString()); // Obtiene la posición de el id de el evento

                // Obtine el id del evento y lo manda al main del formulari FormAprendicesRegistrados
                FormAprendicesRegistrados form = new FormAprendicesRegistrados(idEvento); 
                form.ShowDialog();

                //dataGridViewAdmin.DataSource = co.ConsultarEventos(); // Mantine los eventos en el grid del formulario administrador
                dataGridViewAdmin.DataMember = "Eventos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarEvent_Click(object sender, EventArgs e)
        {
            // Obtener datos de la fila seleccionada en el dataGridViewAdmin
            DataGridViewRow fila = dataGridViewAdmin.CurrentRow;

            int idEvent = int.Parse(fila.Cells["idEvento"].Value.ToString());
            string nombreEvent = fila.Cells["Nombre"].Value.ToString();
            string tipoEvent = fila.Cells["Tipo"].Value.ToString();
            string categoriaEvento = fila.Cells["categoriaEvento"].Value.ToString();

            int? cantIntegrantes = null;
            if (categoriaEvento == "Grupal")
            {
                object valor = fila.Cells["cantIntegrantes"].Value;
                if(valor != null && valor != DBNull.Value && !string.IsNullOrWhiteSpace(valor.ToString()))
                {
                    cantIntegrantes = Convert.ToInt32(valor);
                }
            }

            DateTime fechaHoraInicio = Convert.ToDateTime(fila.Cells["fechaHoraInicio"].Value);
            DateTime fechaHoraFin = Convert.ToDateTime(fila.Cells["FechaHoraFin"].Value);
            DateTime fechaHoraInicioInscripcion = Convert.ToDateTime(fila.Cells["fechaHoraInicioInscripcion"].Value);
            DateTime fechaHoraFinInscripcion = Convert.ToDateTime(fila.Cells["fechaHoraFinInscripcion"].Value);

            // Abrir FormEditar con fechas de inscripción
            FormEditarEvent frm = new FormEditarEvent(idEvent, nombreEvent, tipoEvent, categoriaEvento, cantIntegrantes, fechaHoraInicio, fechaHoraFin, fechaHoraInicioInscripcion, fechaHoraFinInscripcion);
            frm.ShowDialog();

            dataGridViewAdmin.DataSource = co.ConsultarEventos();
            dataGridViewAdmin.DataMember = "Eventos";
        }

        private void txtBuscarNombreEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarNombreEvento.Text))
            {
                dataGridViewAdmin.DataSource = co.ConsultarEventos();
                dataGridViewAdmin.DataMember = "Eventos";
            }
            else
            {
                dataGridViewAdmin.DataSource = co.FiltrarEvento(txtBuscarNombreEvento.Text);
                dataGridViewAdmin.DataMember = "Eventos";
            }
        }

        // Evento para cualquier cambio en los filtros avanzados
        private void FiltrosAvanzados_Changed(object sender, EventArgs e)
        {
            string nombre = txtBuscarNombreEvento.Text.Trim();
            string tipo = cbTipoFiltro.SelectedItem?.ToString() ?? "";
            string categoria = cbCategoriaFiltro.SelectedItem?.ToString() ?? "";
            DateTime? fechaInicio = dtpFiltroInicio.Checked ? dtpFiltroInicio.Value.Date : (DateTime?)null;
            DateTime? fechaFin = dtpFiltroFin.Checked ? dtpFiltroFin.Value.Date : (DateTime?)null;

            DataTable eventos = co.ConsultarEventos().Tables["Eventos"];
            IEnumerable<DataRow> query = eventos.AsEnumerable();

            if (!string.IsNullOrWhiteSpace(nombre))
                query = query.Where(r => r.Field<string>("nombreEvento").IndexOf(nombre, StringComparison.OrdinalIgnoreCase) >= 0);
            if (!string.IsNullOrWhiteSpace(tipo))
                query = query.Where(r => r.Field<string>("tipoEvento") == tipo);
            if (!string.IsNullOrWhiteSpace(categoria))
                query = query.Where(r => r.Field<string>("categoriaEvento") == categoria);
            if (fechaInicio.HasValue)
                query = query.Where(r => r.Field<DateTime>("fechaHoraInicio") >= fechaInicio.Value);
            if (fechaFin.HasValue)
                query = query.Where(r => r.Field<DateTime>("fechaHoraFin") <= fechaFin.Value);

            if (query.Any())
                dataGridViewAdmin.DataSource = query.CopyToDataTable();
            else
                dataGridViewAdmin.DataSource = null;
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarNombreEvento.Text = "";
            cbTipoFiltro.SelectedIndex = 0;
            cbCategoriaFiltro.SelectedIndex = 0;
            dtpFiltroInicio.Value = DateTime.Now;
            dtpFiltroInicio.Checked = false;
            dtpFiltroFin.Value = DateTime.Now;
            dtpFiltroFin.Checked = false;
            dataGridViewAdmin.DataSource = co.ConsultarEventos();
            dataGridViewAdmin.DataMember = "Eventos";
        }
    }
}