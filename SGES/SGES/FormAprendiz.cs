using System;
using System.Data;
using System.Windows.Forms;

namespace SGES
{
    public partial class FormAprendiz : Form
    {
        private readonly FormLogin login;
        private readonly int idApr; // id del aprendiz logueado (0 si no se pasó)

        public FormAprendiz()
        {
            InitializeComponent();
        }

        // Constructor existente adaptado: conserva compatibilidad si algún otro sitio pasa sólo FormLogin.
        public FormAprendiz(FormLogin login)
        {
            InitializeComponent(); // CORRECCIÓN: siempre inicializar componentes
            this.login = login;
        }

        // Nuevo constructor (no intrusivo): permite que Iniciar_sesion pase explícitamente el idApr.
        // Comentario: se añade para que el formulario conozca el aprendiz actual sin accionar cambios en login.
        public FormAprendiz(int idApr, FormLogin login)
        {
            InitializeComponent(); // obligatorio para evitar null refs en controles
            this.idApr = idApr;
            this.login = login;
        }

        private void FormAprendiz_Load(object sender, EventArgs e)
        {
            Consultas consulta = new Consultas();
            DataSet ds = consulta.ConsultarEventos();

            dataGridViewAprend.AutoGenerateColumns = false;
            dataGridViewAprend.DataSource = ds.Tables["Eventos"];
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin form = new FormLogin();
            form.ShowDialog();
        }

        private void dataGridViewAprend_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Opcional: lógica por clic en celda (no modificada).
        }

        private void btnRegistrarme_Click(object sender, EventArgs e)
        {
            // Validaciones mínimas y llamada a la capa de datos (no se cambia la consulta SQL existente).
            // 1) Verificar que tenemos el id del aprendiz (debe venir desde el login/iniciar sesión)
            if (idApr == 0)
            {
                MessageBox.Show("Identificador del aprendiz no disponible. Asegúrate de iniciar sesión correctamente.");
                return;
            }

            // 2) Verificar fila seleccionada
            if (dataGridViewAprend.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un evento para registrarte.");
                return;
            }

            // 3) Obtener idEvento de forma segura:
            object rawIdEvento = null;

            // Método preferente: si el grid está enlazado a un DataTable, obtener desde DataBoundItem
            if (dataGridViewAprend.CurrentRow.DataBoundItem is DataRowView drv)
            {
                // Asegúrate de que la columna en el DataTable se llame "idEvento"
                if (drv.Row.Table.Columns.Contains("idEvento"))
                {
                    rawIdEvento = drv["idEvento"];
                }
            }

            // Fallback 1: si la columna existe en el DataGridView, obtener por nombre de columna
            if (rawIdEvento == null && dataGridViewAprend.Columns.Contains("idEvento"))
            {
                rawIdEvento = dataGridViewAprend.CurrentRow.Cells["idEvento"].Value;
            }

            // Fallback 2: usar la primera celda (mantener compatibilidad con diseños simples)
            if (rawIdEvento == null)
            {
                rawIdEvento = dataGridViewAprend.CurrentRow.Cells[0].Value;
            }

            if (rawIdEvento == null || !int.TryParse(rawIdEvento.ToString(), out int idEvento))
            {
                MessageBox.Show("No se pudo obtener el identificador del evento seleccionado. Verifica las columnas del DataGridView y el nombre 'idEvento'.")
;
                return;
            }

            // 4) Confirmación del usuario
            var confirm = MessageBox.Show("¿Deseas registrarte en el evento seleccionado?", "Confirmar inscripción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            // 5) Llamada a la capa de datos (usar el método ya existente RegistrarInscripcion en Consultas)
            Consultas consulta = new Consultas();
            bool ok = consulta.RegistrarInscripcion(idApr, idEvento);

            // Nota: RegistrarInscripcion ya muestra mensajes (éxito / duplicado / conflicto). Aquí sólo manejamos UI mínima.
            if (ok)
            {
                // Opcional: deshabilitar botón para evitar doble click; conservar CRUD sencillo.
                btnRegistrarme.Enabled = false;
                // Si quieres refrescar el grid: volver a cargar eventos
                // FormAprendiz_Load(this, EventArgs.Empty);
            }
        }
    }
}