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
        // Instancia de la clase Consultas para acceder a la base de datos
        Consultas c = new Consultas();
        int idUser; // Variable para almacenar el ID del usuario verificado.
         // Constructor que recibe el ID del usuario desde el formulario anterior (FormRecuperarCuenta)
        public FormVerificar(int id) // Constructor que recibe el ID del usuario verificado para mostrar información personalizada o realizar acciones específicas.
        {
            InitializeComponent();
            idUser = id; 
        }


        private void FormVerificar_Load(object sender, EventArgs e)
        {

        }

        // Evento del botón Guardar (actualizar contraseña)
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // Validación de longitud máxima según la base de datos (varchar(8))
            if (txtNewPassword.Text.Length > 8)
            {
                MessageBox.Show("La contraseña no puede tener más de 8 caracteres");
                return; // Detiene la ejecución si no cumple la condición
            }

            // Validación de coincidencia entre la nueva contraseña y la confirmación
            if (txtNewPassword.Text == txtConfimPassword.Text)
            {
                // Llama al método que actualiza la contraseña en la base de datos
                c.ActualizarContraseña(idUser, txtNewPassword.Text);

                // Redirige al usuario nuevamente al formulario de login
                FormLogin login = new FormLogin();
                login.Show();
                this.Close();// Cierra el formulario actual para finalizar el proceso
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden");
            }
        }
    }
}
