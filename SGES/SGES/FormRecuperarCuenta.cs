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
    public partial class FormRecuperarCuenta : Form
    {
        FormLogin login;
        public FormRecuperarCuenta(FormLogin login)
        {
            InitializeComponent();
            this.login = login;
        }


        Consultas c = new Consultas(); // Instancia de la clase Consultas para acceder a los métodos de verificación y recuperación de cuenta.


        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("¿Está seguro que desea cancelar la recuperación de cuenta?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login.Show();   // 🔥 vuelve a mostrar el login
                this.Close(); // Cierra el formulario de recuperación de cuenta
            }
        }

        private void txtidusuarioV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Evita que se ingresen caracteres no numéricos
                MessageBox.Show("Solo se permiten números en el campo de ID de usuario.", "SGES");
            }
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            // Validación básica
            if (string.IsNullOrWhiteSpace(txtidusuarioV.Text) || string.IsNullOrWhiteSpace(txtemailUser.Text))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            string emailUser = txtemailUser.Text.Trim(); // Elimina espacios en blanco al inicio y al final para evitar errores de validación
            int idUser = int.Parse(txtidusuarioV.Text); // Convierte el texto del TextBox a entero para usarlo en la consulta
            // 🔥 Verificación
            bool existe = c.VerificarUsuario(idUser, emailUser);

            if (existe)
            {
                MessageBox.Show("Usuario verificado");

                FormVerificar frm = new FormVerificar(idUser);
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("ID o correo incorrectos");
            }
        }
    }
}
