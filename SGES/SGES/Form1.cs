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
        // Instancia de la clase que contiene las consultas y lógica de autenticación.
        // Se usa para iniciar sesión y abrir los formularios correspondientes según el tipo de usuario.
        Consultas c = new Consultas();

        public FormLogin()
        {
            InitializeComponent();
        }


        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Validar que el usuario y la contraseña no estén vacíos antes de intentar iniciar sesión
            // `txtidusuario` y `txtpasswordusuario` son controles TextBox en el formulario de login.
            if (txtidusuario.Text == "" || txtpasswordusuario.Text == "")
            {
                MessageBox.Show("Por favor, ingrese su ID de usuario y contraseña.");
            }
            else
            {
                // Llamar al método que valida las credenciales.
                // Se convierte el texto del TextBox `txtidusuario` a entero porque la tabla espera un id numérico.
                c.Iniciar_sesion(int.Parse(txtidusuario.Text), txtpasswordusuario.Text, this);
            }
        }

        private void txtidusuario_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingresen caracteres no numéricos
                MessageBox.Show("Solo se permiten números en el campo de ID de usuario.", "APLICACION");
            }
        }

        private void linkLblCambiarContraseña_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
