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
    public partial class FormAdmin : Form
    {
        Conexion cn = new Conexion();
        Consultas co = new Consultas();
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
        private FormLogin login;

        public FormAdmin()
        {
            InitializeComponent();
        }

        public FormAdmin(FormLogin login)
        {
            this.login = login;
        }

        private void FormAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultarReg_Click(object sender, EventArgs e)
        {
            try
            {
                ds = co.ConsultarEventos();
                dataGridViewAdmin.DataSource = ds;
                dataGridViewAdmin.DataMember = "Eventos";
                dataGridViewAdmin.AutoGenerateColumns = false;
                ID.DataPropertyName = "idEvento";
                Nombre.DataPropertyName = "nombreEvento";
                Tipo.DataPropertyName = "tipoEvento";
                Fecha.DataPropertyName = "fechaEvento";
                Hora.DataPropertyName = "horaEvento";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCrearEvent_Click(object sender, EventArgs e)
        {
            FormCrearEvento form = new FormCrearEvento();
            form.ShowDialog();

            dataGridViewAdmin.DataSource = co.ConsultarEventos();
            dataGridViewAdmin.DataMember = "Eventos";
        }

        private void btnConsultarAprendicesRegistrados_Click(object sender, EventArgs e)
        {
            try
            { 
                int idEvento = int.Parse(dataGridViewAdmin.CurrentRow.Cells["idEvento"].Value.ToString());

                DataSet ds = co.ConsultarAprendicesRegistrados(idEvento);

                dataGridViewAdmin.DataSource = ds;
                dataGridViewAdmin.DataMember = "Aprendices";

                FormAprendicesRegistrados form = new FormAprendicesRegistrados(idEvento);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridViewAdmin_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idEvento = int.Parse(dataGridViewAdmin.CurrentRow.Cells["idEvento"].Value.ToString());

                FormAprendicesRegistrados form = new FormAprendicesRegistrados(idEvento);
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
