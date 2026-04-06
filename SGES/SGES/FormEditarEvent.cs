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
        public FormEditarEvent(int idEvent, string nombreEvent, string tipoEvent, DateTime fechaHoraInicio, DateTime fechaHoraFin)
        {
            InitializeComponent();
            // cargar los datos del evento en los controles del formulario
            lblID.Text = idEvent.ToString(); // Mostrar el ID del evento en una etiqueta (puede ser un control de solo lectura)
            txtNombreEvento1.Text = nombreEvent;
            cbTipoEvento1.Text = tipoEvent;
            dtpFechaHoraInicio.Value = fechaHoraInicio; // Personalizar el formato de la fecha y hora
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
            if (txtNombreEvento1.Text == "" || cbTipoEvento1.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos antes de actualizar el evento.");
            }
            else
            {
                try
                {
                    Consultas co = new Consultas(); // Crear una instancia de la clase Consultas para acceder a los métodos de actualización

                    co.ActualizarEvento(int.Parse(lblID.Text), txtNombreEvento1.Text, cbTipoEvento1.Text, dtpFechaHoraInicio.Value, dtpFechaHoraFin.Value); // Llamar al método ActualizarEvento para actualizar los datos del evento en la base de datos
                    this.Close(); // Cerrar el formulario de edición

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
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

        }
    }
}
