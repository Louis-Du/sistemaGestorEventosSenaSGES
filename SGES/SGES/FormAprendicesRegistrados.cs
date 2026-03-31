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
    public partial class FormAprendicesRegistrados : Form
    {

        int idEvento;
        Consultas co = new Consultas();

        public FormAprendicesRegistrados(int idEventoRecibido)
        {
            InitializeComponent();
            idEvento = idEventoRecibido; 
        }

        // Carga inmediatamente los aprendices registrados en el grid al abrir este formulario
        private void FormAprendicesRegistrados_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = co.ConsultarAprendicesRegistrados(idEvento);

                dataGridViewAprendices.DataSource = ds; // Asigna las columnas de la tabla aprendiz en el grid
                dataGridViewAprendices.DataMember = "Aprendices"; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewAprendices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
          
        }
    }
}
