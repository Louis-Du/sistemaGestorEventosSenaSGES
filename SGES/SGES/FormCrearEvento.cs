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
    public partial class FormCrearEvento : Form
    {
        public FormCrearEvento()
        {
            InitializeComponent();

            // Se personaliza el formato de la fecha y hora
            dtpFechaEvento.Format = DateTimePickerFormat.Custom; 
            dtpFechaEvento.CustomFormat = "dd/MM/yyyy HH:mm";

            // Inicializar los DateTimePicker para horas
            dtpHoraInicioEvento.Format = DateTimePickerFormat.Custom;
            dtpHoraInicioEvento.CustomFormat = "HH:mm";
            dtpHoraInicioEvento.ShowUpDown = true;
            dtpHoraInicioEvento.Value = DateTime.Today.AddHours(9); // 09:00

            dtpHoraFinEvento.Format = DateTimePickerFormat.Custom;
            dtpHoraFinEvento.CustomFormat = "HH:mm";
            dtpHoraFinEvento.ShowUpDown = true;
            dtpHoraFinEvento.Value = DateTime.Today.AddHours(10); // 10:00

            // Fecha: solo fecha
            dtpFechaEvento.Format = DateTimePickerFormat.Short;
        }

        Consultas co = new Consultas();

        // Función para el botón guardar que permite accionar el registro del nuevo evento en la base de dato
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                co.InsertarEvento(int.Parse(txtidEvento.Text), txtNombreEvento.Text, cbTipoEvento.Text, dtpFechaEvento.Value, 1);
                MessageBox.Show("Evento creado con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCrearEvento_Load(object sender, EventArgs e)
        {

        }

        private void cbTipoEvento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Función que cierro el formulario de Crear Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la creación del evento?", "SDGF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        // Validaciones de entrada solo números para el id del evento
        private void txtidEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingresen caracteres no numéricos
                MessageBox.Show("ERROR: Solo se permite valores númericos", "SDGF");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}