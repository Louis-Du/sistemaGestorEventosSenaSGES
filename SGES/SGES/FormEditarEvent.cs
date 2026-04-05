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
        FormAdmin FormAdmin; // Variable para almacenar la referencia al formulario principal para poder actualizarlo después
        int filaIndex; // Variable para almacenar el índice de la fila que se va a editar
        public FormEditarEvent(FormAdmin formAdmin, int fila, int idEvent, string nombreEvent, string tipoEvent, DateTime fechaHoraEvent)
        {
            InitializeComponent();
            FormAdmin = formAdmin; // Guardar la referencia al formulario principal para poder actualizarlo después
            formAdmin.Hide(); // Ocultar el formulario principal mientras se edita el evento
            filaIndex = fila; // Guardar el índice de la fila que se va a editar para poder actualizarla después
            // cargar los datos del evento en los controles del formulario
            lblID.Text = idEvent.ToString(); // Mostrar el ID del evento en una etiqueta (puede ser un control de solo lectura)
            txtNombreEvento1.Text = nombreEvent;
            cbTipoEvento1.Text = tipoEvent;
            dtpFechaHoraEvento1.Value = fechaHoraEvent; // Personalizar el formato de la fecha y hora
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
                FormAdmin.Show(); // Volver a mostrar el formulario principal
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

                    co.ActualizarEvento(int.Parse(lblID.Text), txtNombreEvento1.Text, cbTipoEvento1.Text, dtpFechaHoraEvento1.Value); // Llamar al método ActualizarEvento para actualizar los datos del evento en la base de datos

                    MessageBox.Show("Evento actualizado con éxito.");
                    this.Close(); // Cerrar el formulario de edición
                    FormAdmin.Show(); // Volver a mostrar el formulario principal

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
