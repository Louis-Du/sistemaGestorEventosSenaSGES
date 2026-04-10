using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGES
{
    public partial class FormCrearEvento : Form
    {
        int idUsuario;
        public FormCrearEvento(int idUser)
        {
            InitializeComponent();
            this.idUsuario = idUser;

        }

        private void FormCrearEvento_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Consultas co = new Consultas();

                if (string.IsNullOrWhiteSpace(txtNombreEvento.Text) || string.IsNullOrWhiteSpace(cbTipoEvento.Text) || string.IsNullOrWhiteSpace(cbCategoriaEvento.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos antes de crear un nuevo evento.");
                    return;
                }
                if (dtpFechaHoraFin.Value <= dtpFechaHoraInicio.Value)
                {
                    MessageBox.Show("La hora de fin debe ser posterior a la hora de inicio.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (dtpFechaHoraInicio.Value < DateTime.Now)
                {
                    MessageBox.Show("La fecha y hora de inicio no puede ser en el pasado.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int? cantIntegrantes = null;
                if (cbCategoriaEvento.Text == "Grupal")
                {
                    cantIntegrantes = (int)nudCantidadIntegrantes.Value;
                }

                co.InsertarEvento(txtNombreEvento.Text.Trim(), cbTipoEvento.Text, dtpFechaHoraInicio.Value, dtpFechaHoraFin.Value, cbCategoriaEvento.Text, cantIntegrantes, idUsuario);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el evento: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void cbCategoriaEvento_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbCategoriaEvento.Text == "Grupal")
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

        private void txtNombreEvento_TextChanged(object sender, EventArgs e)
        {
            int max = txtNombreEvento.MaxLength;
            int usados = txtNombreEvento.Text.Length;
            int restantes = max - usados;

            lblCaracteresRestantes.Text = "Caracteres restantes: " + restantes;
        }
    }
}
