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

        public FormAdmin()
        {
            InitializeComponent();
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
                ds = co.ConsultarEventos();
                dataGridViewAdmin.DataSource = ds;
                dataGridViewAdmin.DataMember = "Eventos";
                dataGridViewAdmin.AutoGenerateColumns = false;
                idEvento.DataPropertyName = "idEvento";
                Nombre.DataPropertyName = "nombreEvento";
                Tipo.DataPropertyName = "tipoEvento";
                fechaHoraInicio.DataPropertyName = "fechaHoraInicio";
                FechaHoraFin.DataPropertyName = "fechaHoraFin";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Función que permite abrir el formulario Crear Eventos al accionar el botón
        private void btnCrearEvent_Click(object sender, EventArgs e)
        {
            FormCrearEvento form = new FormCrearEvento();
            form.ShowDialog();

            dataGridViewAdmin.DataSource = co.ConsultarEventos(); // Mantine los eventos en el grid del formulario administrador
            dataGridViewAdmin.DataMember = "Eventos";
        }

        // Función que permite volver al login al accionar el botón
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

                DataSet ds = co.ConsultarAprendicesRegistrados(idEvento);

                // Consulta los aprendices registrados al evento y los agregamos al data grid
                dataGridViewAdmin.DataSource = ds;
                dataGridViewAdmin.DataMember = "Aprendices";

                // Obtine el id del evento y lo manda al main del formulari FormAprendicesRegistrados
                FormAprendicesRegistrados form = new FormAprendicesRegistrados(idEvento);
                form.ShowDialog();

                dataGridViewAdmin.DataSource = co.ConsultarEventos(); // Mantine los eventos en el grid del formulario administrador
                dataGridViewAdmin.DataMember = "Eventos";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditarEvent_Click(object sender, EventArgs e)
        {
            if (dataGridViewAdmin.CurrentRow == null) // para validar que se haya seleccionado un evento para editar
            {
                MessageBox.Show("Seleccione un evento para editar");
                return;
            }
            else// Obtener datos de la fila seleccionada en el dataGridViewAdmin
            {
                int fila = dataGridViewAdmin.CurrentRow.Index;

                int idEvent = int.Parse(dataGridViewAdmin.Rows[fila].Cells[0].Value.ToString());
                string nombreEvent = dataGridViewAdmin.Rows[fila].Cells[1].Value.ToString();
                string tipoEvent = dataGridViewAdmin.Rows[fila].Cells[2].Value.ToString();

                // En develop ahora existen diaEvento/fechaHoraInicio/fechaHoraFin
                DateTime fechaHoraInicio = Convert.ToDateTime(dataGridViewAdmin.Rows[fila].Cells[3].Value);
                DateTime fechaHoraFin = Convert.ToDateTime(dataGridViewAdmin.Rows[fila].Cells[4].Value);

                // Abrir FormEditar
                FormEditarEvent frm = new FormEditarEvent(idEvent, nombreEvent, tipoEvent, fechaHoraInicio, fechaHoraFin);
                frm.ShowDialog();

                dataGridViewAdmin.DataSource = co.ConsultarEventos(); // Mantine los eventos actualizados en el grid del formulario administrador
                dataGridViewAdmin.DataMember = "Eventos";
            }
        }
    }
}