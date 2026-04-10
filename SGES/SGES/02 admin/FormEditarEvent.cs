using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGES
{
    public partial class FormEditarEvent : Form
    {
        public FormEditarEvent(int idEvent, string nombreEvent, string tipoEvent, string categoriaEvento, int? cantIntegrantes, DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            InitializeComponent();
            // cargar los datos del evento en los controles del formulario
            lblID.Text = idEvent.ToString(); // Mostrar el ID del evento en una etiqueta (puede ser un control de solo lectura)
            
            // Asignamos cada una de las entradas con los valores actuales del evento
            txtNombreEvento1.Text = nombreEvent;
            cbTipoEvento1.Text = tipoEvent;
            cbCategoriaEvento.Text = categoriaEvento;
            //nudCantidadIntegrantes.Value = cantIntegrantes;
            dtpFechaHoraInicio.Value = fechaHoraInicio; 
            dtpFechaHoraFin.Value = fechaHoraFin;
        }

        private void FormEditarEvent_Load(object sender, EventArgs e)
        {

        }

        private void dtpFechaHoraEvento1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarAct_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la edición del evento?", "SDGF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close(); // Cerrar el formulario de edición

            }
        }

        private void btnActualizarEvent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEvento1.Text) || string.IsNullOrWhiteSpace(cbTipoEvento1.Text) || string.IsNullOrWhiteSpace(cbCategoriaEvento.Text)) // Validación de espacio en blanco
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar el evento.");
                return;
            }
            if (dtpFechaHoraFin.Value <= dtpFechaHoraInicio.Value) // Validación de fecha fin menor a fecha inicio
            {
                MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dtpFechaHoraInicio.Value < DateTime.Now) // Validación de fecha inicio anterior al día actual
            {
                MessageBox.Show("La fecha y hora de inicio no puede ser en el pasado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int? cantIntegrantes = null;
            if (cbCategoriaEvento.Text == "Grupal")
            {
                cantIntegrantes = (int)nudCantidadIntegrantes.Value;
            }

            Consultas co = new Consultas();

            co.ActualizarEvento(int.Parse(lblID.Text), txtNombreEvento1.Text, cbTipoEvento1.Text, cbCategoriaEvento.Text, cantIntegrantes, dtpFechaHoraInicio.Value, dtpFechaHoraFin.Value); // Llamar al método ActualizarEvento para actualizar los datos del evento en la base de datos
            this.Close(); 
        }

        private void txtIdEvento_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNombreEvento1_TextChanged(object sender, EventArgs e)
        {
            int max = txtNombreEvento1.MaxLength;
            int usados = txtNombreEvento1.Text.Length;
            int restantes = max - usados;

            lblCaracteresRestantes.Text = "Caracteres restantes: " + restantes;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbCategoriaEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCategoriaEvento.Text == "Grupal")
            {
                label5.Visible = true;
                nudCantidadIntegrantes.Visible = true;
            }
            else
            {
                label5.Visible = false;
                nudCantidadIntegrantes.Visible = false;
            }
        }
    }
}
