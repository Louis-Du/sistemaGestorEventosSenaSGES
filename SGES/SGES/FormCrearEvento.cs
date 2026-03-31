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

            dtpFechaHoraEvento.Format = DateTimePickerFormat.Custom;
            dtpFechaHoraEvento.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        Consultas co = new Consultas();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                co.InsertarEvento(int.Parse(txtidEvento.Text), txtNombreEvento.Text, cbTipoEvento.Text, dtpFechaHoraEvento.Value, 1);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Estás seguro que deseas cancelar la creación del evento?", "SDGF", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void txtidEvento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingresen caracteres no numéricos
                MessageBox.Show("ERROR: Solo se permite valores númericos", "SDGF");
            }
        }
    }
}
