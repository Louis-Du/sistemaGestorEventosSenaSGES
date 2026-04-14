namespace SGES
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnCrearEvent = new System.Windows.Forms.Button();
            this.btnExportarEventos = new System.Windows.Forms.Button();
            this.btnExportarInscripciones = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBuscarNombreEvento = new System.Windows.Forms.TextBox();
            this.btnEditarEvent = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarAprendicesRegistrados = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.btnEliminarEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantIntegrantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraInicioInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraFinInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbTipoFiltro = new System.Windows.Forms.ComboBox();
            this.cbCategoriaFiltro = new System.Windows.Forms.ComboBox();
            this.dtpFiltroInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpFiltroFin = new System.Windows.Forms.DateTimePicker();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(69, 19);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnCrearEvent
            // 
            this.btnCrearEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearEvent.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCrearEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearEvent.Location = new System.Drawing.Point(513, 18);
            this.btnCrearEvent.Name = "btnCrearEvent";
            this.btnCrearEvent.Size = new System.Drawing.Size(131, 32);
            this.btnCrearEvent.TabIndex = 5;
            this.btnCrearEvent.Text = "Crear evento";
            this.btnCrearEvent.UseVisualStyleBackColor = false;
            this.btnCrearEvent.Click += new System.EventHandler(this.btnCrearEvent_Click);
            // 
            // btnExportarEventos
            // 
            this.btnExportarEventos.Text = "Exportar Eventos PDF";
            this.btnExportarEventos.Location = new System.Drawing.Point(500, 320);
            this.btnExportarEventos.Size = new System.Drawing.Size(120, 23);
            this.btnExportarEventos.TabIndex = 20;
            this.btnExportarEventos.Click += new System.EventHandler(this.btnExportarEventos_Click);
            // 
            // btnExportarInscripciones
            // 
            this.btnExportarInscripciones.Text = "Exportar Inscripciones PDF";
            this.btnExportarInscripciones.Location = new System.Drawing.Point(350, 320);
            this.btnExportarInscripciones.Size = new System.Drawing.Size(140, 23);
            this.btnExportarInscripciones.TabIndex = 21;
            this.btnExportarInscripciones.Click += new System.EventHandler(this.btnExportarInscripciones_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtBuscarNombreEvento);
            this.panel1.Controls.Add(this.btnEditarEvent);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConsultarAprendicesRegistrados);
            this.panel1.Controls.Add(this.dataGridViewAdmin);
            this.panel1.Controls.Add(this.btnEliminarEvent);
            this.panel1.Controls.Add(this.cbTipoFiltro);
            this.panel1.Controls.Add(this.cbCategoriaFiltro);
            this.panel1.Controls.Add(this.dtpFiltroInicio);
            this.panel1.Controls.Add(this.dtpFiltroFin);
            this.panel1.Controls.Add(this.btnLimpiarFiltros);
            this.panel1.Controls.Add(this.btnExportarEventos);
            this.panel1.Controls.Add(this.btnExportarInscripciones);
            this.panel1.Location = new System.Drawing.Point(34, 84);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 359);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label3.Location = new System.Drawing.Point(185, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Buscar evento por su nombre";
            // 
            // txtBuscarNombreEvento
            // 
            this.txtBuscarNombreEvento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtBuscarNombreEvento.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtBuscarNombreEvento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarNombreEvento.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtBuscarNombreEvento.Location = new System.Drawing.Point(157, 66);
            this.txtBuscarNombreEvento.MaxLength = 50;
            this.txtBuscarNombreEvento.Multiline = true;
            this.txtBuscarNombreEvento.Name = "txtBuscarNombreEvento";
            this.txtBuscarNombreEvento.Size = new System.Drawing.Size(277, 27);
            this.txtBuscarNombreEvento.TabIndex = 11;
            this.txtBuscarNombreEvento.Tag = "";
            this.txtBuscarNombreEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuscarNombreEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscarNombreEvento_KeyPress);
            // 
            // btnEditarEvent
            // 
            this.btnEditarEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditarEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnEditarEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditarEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditarEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditarEvent.Location = new System.Drawing.Point(264, 278);
            this.btnEditarEvent.Name = "btnEditarEvent";
            this.btnEditarEvent.Size = new System.Drawing.Size(131, 32);
            this.btnEditarEvent.TabIndex = 10;
            this.btnEditarEvent.Text = "Editar Evento Seleccionado";
            this.btnEditarEvent.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEditarEvent.UseVisualStyleBackColor = false;
            this.btnEditarEvent.Click += new System.EventHandler(this.btnEditarEvent_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eventos";
            // 
            // btnConsultarAprendicesRegistrados
            // 
            this.btnConsultarAprendicesRegistrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarAprendicesRegistrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnConsultarAprendicesRegistrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarAprendicesRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarAprendicesRegistrados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarAprendicesRegistrados.Location = new System.Drawing.Point(49, 278);
            this.btnConsultarAprendicesRegistrados.Name = "btnConsultarAprendicesRegistrados";
            this.btnConsultarAprendicesRegistrados.Size = new System.Drawing.Size(179, 32);
            this.btnConsultarAprendicesRegistrados.TabIndex = 9;
            this.btnConsultarAprendicesRegistrados.Text = "Consultar Aprendices Registrados";
            this.btnConsultarAprendicesRegistrados.UseVisualStyleBackColor = false;
            this.btnConsultarAprendicesRegistrados.Click += new System.EventHandler(this.btnConsultarAprendicesRegistrados_Click_1);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AllowUserToResizeColumns = false;
            this.dataGridViewAdmin.AllowUserToResizeRows = false;
            this.dataGridViewAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvento,
            this.Nombre,
            this.categoriaEvento,
            this.cantIntegrantes,
            this.Tipo,
            this.fechaHoraInicio,
            this.FechaHoraFin,
            this.fechaHoraInicioInscripcion,
            this.fechaHoraFinInscripcion});
            this.dataGridViewAdmin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridViewAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(-35, 123);
            this.dataGridViewAdmin.MultiSelect = false;
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(643, 149);
            this.dataGridViewAdmin.TabIndex = 7;
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
            // 
            // btnEliminarEvent
            // 
            this.btnEliminarEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarEvent.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarEvent.Location = new System.Drawing.Point(425, 278);
            this.btnEliminarEvent.Name = "btnEliminarEvent";
            this.btnEliminarEvent.Size = new System.Drawing.Size(123, 32);
            this.btnEliminarEvent.TabIndex = 6;
            this.btnEliminarEvent.Text = "Eliminar Evento";
            this.btnEliminarEvent.UseVisualStyleBackColor = false;
            this.btnEliminarEvent.Click += new System.EventHandler(this.btnEliminarEvent_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(172, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Panel de Administración";
            // 
            // idEvento
            // 
            this.idEvento.DataPropertyName = "idEvento";
            this.idEvento.HeaderText = "Column1";
            this.idEvento.Name = "idEvento";
            this.idEvento.ReadOnly = true;
            this.idEvento.Visible = false;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombreEvento";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // categoriaEvento
            // 
            this.categoriaEvento.HeaderText = "Categoria";
            this.categoriaEvento.Name = "categoriaEvento";
            this.categoriaEvento.ReadOnly = true;
            // 
            // cantIntegrantes
            // 
            this.cantIntegrantes.HeaderText = "Cantidad de  integrantes";
            this.cantIntegrantes.Name = "cantIntegrantes";
            this.cantIntegrantes.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipoEvento";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // fechaHoraInicio
            // 
            this.fechaHoraInicio.DataPropertyName = "fechaHoraInicio";
            this.fechaHoraInicio.HeaderText = "Fecha y Hora de Inicio";
            this.fechaHoraInicio.Name = "fechaHoraInicio";
            this.fechaHoraInicio.ReadOnly = true;
            // 
            // FechaHoraFin
            // 
            this.FechaHoraFin.DataPropertyName = "fechaHoraFin";
            this.FechaHoraFin.HeaderText = "Fecha y Hora de Finalización";
            this.FechaHoraFin.Name = "FechaHoraFin";
            this.FechaHoraFin.ReadOnly = true;
            // 
            // fechaHoraInicioInscripcion
            // 
            this.fechaHoraInicioInscripcion.DataPropertyName = "fechaHoraInicioInscripcion";
            this.fechaHoraInicioInscripcion.HeaderText = "Inicio Inscripción";
            this.fechaHoraInicioInscripcion.Name = "fechaHoraInicioInscripcion";
            this.fechaHoraInicioInscripcion.ReadOnly = true;
            // 
            // fechaHoraFinInscripcion
            // 
            this.fechaHoraFinInscripcion.DataPropertyName = "fechaHoraFinInscripcion";
            this.fechaHoraFinInscripcion.HeaderText = "Fin Inscripción";
            this.fechaHoraFinInscripcion.Name = "fechaHoraFinInscripcion";
            this.fechaHoraFinInscripcion.ReadOnly = true;
            // 
            // cbTipoFiltro
            // 
            this.cbTipoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoFiltro.Items.AddRange(new object[] {"", "Educativo", "Cultural", "Deportivo"});
            this.cbTipoFiltro.Location = new System.Drawing.Point(450, 66);
            this.cbTipoFiltro.Name = "cbTipoFiltro";
            this.cbTipoFiltro.Size = new System.Drawing.Size(100, 21);
            this.cbTipoFiltro.TabIndex = 12;
            this.cbTipoFiltro.SelectedIndexChanged += new System.EventHandler(this.FiltrosAvanzados_Changed);
            // 
            // cbCategoriaFiltro
            // 
            this.cbCategoriaFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoriaFiltro.Items.AddRange(new object[] {"", "Grupal", "Individual"});
            this.cbCategoriaFiltro.Location = new System.Drawing.Point(560, 66);
            this.cbCategoriaFiltro.Name = "cbCategoriaFiltro";
            this.cbCategoriaFiltro.Size = new System.Drawing.Size(80, 21);
            this.cbCategoriaFiltro.TabIndex = 13;
            this.cbCategoriaFiltro.SelectedIndexChanged += new System.EventHandler(this.FiltrosAvanzados_Changed);
            // 
            // dtpFiltroInicio
            // 
            this.dtpFiltroInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroInicio.Location = new System.Drawing.Point(157, 100);
            this.dtpFiltroInicio.Name = "dtpFiltroInicio";
            this.dtpFiltroInicio.Size = new System.Drawing.Size(120, 20);
            this.dtpFiltroInicio.TabIndex = 14;
            this.dtpFiltroInicio.ValueChanged += new System.EventHandler(this.FiltrosAvanzados_Changed);
            // 
            // dtpFiltroFin
            // 
            this.dtpFiltroFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFiltroFin.Location = new System.Drawing.Point(277, 100);
            this.dtpFiltroFin.Name = "dtpFiltroFin";
            this.dtpFiltroFin.Size = new System.Drawing.Size(120, 20);
            this.dtpFiltroFin.TabIndex = 15;
            this.dtpFiltroFin.ValueChanged += new System.EventHandler(this.FiltrosAvanzados_Changed);
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(410, 100);
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(100, 23);
            this.btnLimpiarFiltros.TabIndex = 16;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(723, 470);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearEvent);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnCrearEvent;
        private System.Windows.Forms.Button btnExportarEventos;
        private System.Windows.Forms.Button btnExportarInscripciones;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultarAprendicesRegistrados;
        private System.Windows.Forms.Button btnEliminarEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditarEvent;
        private System.Windows.Forms.TextBox txtBuscarNombreEvento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantIntegrantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraInicioInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraFinInscripcion;
        private System.Windows.Forms.ComboBox cbTipoFiltro;
        private System.Windows.Forms.ComboBox cbCategoriaFiltro;
        private System.Windows.Forms.DateTimePicker dtpFiltroInicio;
        private System.Windows.Forms.DateTimePicker dtpFiltroFin;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
    }
}