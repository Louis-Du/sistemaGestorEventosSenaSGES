using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGES
{
    public partial class FormAprendiz : Form
    {
        public FormAprendiz()
        {
            InitializeComponent();
        }

        private void FormAprendiz_Load(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();

            DataSet ds = consulta.ConsultarEventos();

            dataGridViewAprend.AutoGenerateColumns = false;

            dataGridViewAprend.DataSource = ds.Tables["Eventos"];
        }
    }
}
