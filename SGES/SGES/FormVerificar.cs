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
    public partial class FormVerificar : Form
    {
        Consultas c = new Consultas();
        int idUser; // Variable para almacenar el ID del usuario verificado.
        public FormVerificar(int id) // Constructor que recibe el ID del usuario verificado para mostrar información personalizada o realizar acciones específicas.
        {
            InitializeComponent();
            idUser = id; // Asigna el ID del usuario a una variable de instancia para su uso en otros métodos del formulario.
        }


        private void FormVerificar_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNewPassword.Text.Length > 8)
            {
                MessageBox.Show("La contraseña no puede tener más de 8 caracteres");
                return;
            }

            if (txtNewPassword.Text == txtConfimPassword.Text)
            {
                c.ActualizarContraseña(idUser, txtNewPassword.Text);

                FormLogin login = new FormLogin();
                login.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
