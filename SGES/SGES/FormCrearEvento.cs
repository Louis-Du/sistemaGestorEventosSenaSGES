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
    }
}
