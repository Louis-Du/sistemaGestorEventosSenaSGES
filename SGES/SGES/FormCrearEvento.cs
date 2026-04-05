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
                // 1) Validar ID de evento
                if (!int.TryParse(txtidEvento.Text.Trim(), out int idEvent))
                {
                    MessageBox.Show("ID de evento inválido.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 2) Combinar fecha + horas desde los DateTimePicker
                DateTime fecha = dtpFechaEvento.Value.Date;
                DateTime inicio = fecha.Add(dtpHoraInicioEvento.Value.TimeOfDay);
                DateTime fin = fecha.Add(dtpHoraFinEvento.Value.TimeOfDay);

                // Si quieres permitir eventos que crucen medianoche descomentar la línea siguiente:
                if (fin <= inicio) fin = fin.AddDays(1);

                // 3) Validaciones básicas
                if (fin <= inicio)
                {
                    MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (inicio < DateTime.Now.Date)
                {
                    MessageBox.Show("La fecha y hora de inicio no puede ser en el pasado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // 4) Llamada a la capa de datos
                // Ajusta idUser según tu contexto; aquí se mantiene 1 por compatibilidad con el proyecto.
                int idUser = 1;
                co.InsertarEvento(idEvent, txtNombreEvento.Text.Trim(), cbTipoEvento.Text, inicio, fin, idUser);

                MessageBox.Show("Evento creado con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtpFechaEvento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpHoraFinEvento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dtpHoraInicioEvento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}