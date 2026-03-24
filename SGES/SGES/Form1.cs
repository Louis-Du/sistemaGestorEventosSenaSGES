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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validar que el usuario y la contraseña no estén vacíos antes de intentar iniciar sesión
            // `txtidusuario` y `txtpasswordusuario` son controles TextBox en el formulario de login.
            if (txtidusuario.Text == "" && txtpasswordusuario.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su ID de usuario y contraseña.");
            }
        }
    }
}
