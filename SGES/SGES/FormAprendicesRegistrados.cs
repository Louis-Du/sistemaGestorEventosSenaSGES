using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void FormAprendicesRegistrados_Load(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = co.ConsultarAprendicesRegistrados(idEvento);

                dataGridViewAprendices.DataSource = ds;
                dataGridViewAprendices.DataMember = "Aprendices";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
