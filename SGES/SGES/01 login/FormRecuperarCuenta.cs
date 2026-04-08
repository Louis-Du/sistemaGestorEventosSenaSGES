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
        // Referencia al formulario de login para poder volver a él sin crear una nueva instancia
        FormLogin login;
        
        // Constructor que recibe el formulario de login
        public FormRecuperarCuenta(FormLogin login)
        {
            InitializeComponent();
            this.login = login; // Se guarda la referencia para usarla después
        }

        // Instancia de la clase Consultas para acceder a la lógica de base de datos
        Consultas c = new Consultas();


        private void btnCancelarR_Click(object sender, EventArgs e)
        {
            // Muestra un mensaje de confirmación antes de cancelar
            if (MessageBox.Show("¿Está seguro que desea cancelar la recuperación de cuenta?", "Confirmar cancelación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                login.Show();   // vuelve a mostrar el login
                this.Close(); // Cierra el formulario de recuperación de cuenta
            }
        }

        // Evento KeyPress para validar que solo se ingresen números en el ID
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
            // Validación básica para asegurarse de que los campos no estén vacíos antes de intentar verificar el usuario.
            if (string.IsNullOrWhiteSpace(txtidusuarioV.Text) || string.IsNullOrWhiteSpace(txtemailUser.Text))
            {
                MessageBox.Show("Completa todos los campos");
                return;
            }
            // Se eliminan espacios en blanco del correo para evitar errores de validación
            string emailUser = txtemailUser.Text.Trim();
            int idUser = int.Parse(txtidusuarioV.Text); // Convierte el texto del TextBox a entero para usarlo en la consulta

            // Llamado al método de verificación en la capa de datos
            bool existe = c.VerificarUsuario(idUser, emailUser);

            if (existe)
            {
                MessageBox.Show("Usuario verificado");

                // Se abre el siguiente formulario para cambiar la contraseña
                // Se pasa el ID del usuario para usarlo en la actualización(FormVerificar)
                FormVerificar frm = new FormVerificar(idUser);
                frm.Show();

                this.Hide(); // Se oculta este formulario mientras continúa el proceso
            }
            else
            {
                MessageBox.Show("ID o correo incorrectos");
            }
        }
    }
}
