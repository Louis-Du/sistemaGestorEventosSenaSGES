namespace SGES
{
    partial class FormCrearEvento
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
            this.cbTipoEvento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaracteresRestantes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoriaEvento = new System.Windows.Forms.ComboBox();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFechaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.nudCantidadIntegrantes = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoEvento
            // 
            this.cbTipoEvento.FormattingEnabled = true;
            this.cbTipoEvento.Items.AddRange(new object[] {
            "Educativo",
            "Cultural",
            "Deportivo"});
            this.cbTipoEvento.Location = new System.Drawing.Point(52, 107);
            this.cbTipoEvento.Name = "cbTipoEvento";
            this.cbTipoEvento.Size = new System.Drawing.Size(120, 21);
            this.cbTipoEvento.TabIndex = 1;
            this.cbTipoEvento.SelectedIndexChanged += new System.EventHandler(this.cbTipoEvento_SelectedIndexChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnGuardar.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGuardar.Location = new System.Drawing.Point(91, 195);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(208, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Evento";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(143, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(393, 47);
            this.panel2.TabIndex = 7;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(102, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Crear Evento";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nudCantidadIntegrantes);
            // Controles para inscripción
            this.labelInscripcionInicio = new System.Windows.Forms.Label();
            this.labelInscripcionFin = new System.Windows.Forms.Label();
            this.dtpFechaHoraInicioInscripcion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHoraFinInscripcion = new System.Windows.Forms.DateTimePicker();
            //
            // labelInscripcionInicio
            //
            this.labelInscripcionInicio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInscripcionInicio.AutoSize = true;
            this.labelInscripcionInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscripcionInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.labelInscripcionInicio.Location = new System.Drawing.Point(44, 200);
            this.labelInscripcionInicio.Name = "labelInscripcionInicio";
            this.labelInscripcionInicio.Size = new System.Drawing.Size(140, 16);
            this.labelInscripcionInicio.TabIndex = 40;
            this.labelInscripcionInicio.Text = "Inicio Inscripción";
            this.panel1.Controls.Add(this.labelInscripcionInicio);
            //
            // dtpFechaHoraInicioInscripcion
            //
            this.dtpFechaHoraInicioInscripcion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraInicioInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraInicioInscripcion.Location = new System.Drawing.Point(198, 200);
            this.dtpFechaHoraInicioInscripcion.Name = "dtpFechaHoraInicioInscripcion";
            this.dtpFechaHoraInicioInscripcion.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaHoraInicioInscripcion.TabIndex = 41;
            this.panel1.Controls.Add(this.dtpFechaHoraInicioInscripcion);
            //
            // labelInscripcionFin
            //
            this.labelInscripcionFin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelInscripcionFin.AutoSize = true;
            this.labelInscripcionFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscripcionFin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.labelInscripcionFin.Location = new System.Drawing.Point(44, 230);
            this.labelInscripcionFin.Name = "labelInscripcionFin";
            this.labelInscripcionFin.Size = new System.Drawing.Size(130, 16);
            this.labelInscripcionFin.TabIndex = 42;
            this.labelInscripcionFin.Text = "Fin Inscripción";
            this.panel1.Controls.Add(this.labelInscripcionFin);
            //
            // dtpFechaHoraFinInscripcion
            //
            this.dtpFechaHoraFinInscripcion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraFinInscripcion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraFinInscripcion.Location = new System.Drawing.Point(198, 230);
            this.dtpFechaHoraFinInscripcion.Name = "dtpFechaHoraFinInscripcion";
            this.dtpFechaHoraFinInscripcion.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaHoraFinInscripcion.TabIndex = 43;
            this.panel1.Controls.Add(this.dtpFechaHoraFinInscripcion);
            this.panel1.Controls.Add(this.lblCaracteresRestantes);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbCategoriaEvento);
            this.panel1.Controls.Add(this.txtNombreEvento);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpFechaHoraFin);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.dtpFechaHoraInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.cbTipoEvento);
            this.panel1.Location = new System.Drawing.Point(143, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 326);
            this.panel1.TabIndex = 8;
            // 
            // lblCaracteresRestantes
            // 
            this.lblCaracteresRestantes.AutoSize = true;
            this.lblCaracteresRestantes.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteresRestantes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaracteresRestantes.Location = new System.Drawing.Point(49, 66);
            this.lblCaracteresRestantes.Name = "lblCaracteresRestantes";
            this.lblCaracteresRestantes.Size = new System.Drawing.Size(128, 13);
            this.lblCaracteresRestantes.TabIndex = 29;
            this.lblCaracteresRestantes.Text = "Caracteres restantes: 50";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(193, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Cantidad de integantes";
            this.label5.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(49, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Categoria";
            // 
            // cbCategoriaEvento
            // 
            this.cbCategoriaEvento.FormattingEnabled = true;
            this.cbCategoriaEvento.Items.AddRange(new object[] {
            "Grupal",
            "Individual"});
            this.cbCategoriaEvento.Location = new System.Drawing.Point(52, 162);
            this.cbCategoriaEvento.Name = "cbCategoriaEvento";
            this.cbCategoriaEvento.Size = new System.Drawing.Size(121, 21);
            this.cbCategoriaEvento.TabIndex = 25;
            this.cbCategoriaEvento.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaEvento_SelectedIndexChanged);
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(51, 43);
            this.txtNombreEvento.MaxLength = 50;
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(120, 20);
            this.txtNombreEvento.TabIndex = 24;
            this.txtNombreEvento.TextChanged += new System.EventHandler(this.txtNombreEvento_TextChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label8.Location = new System.Drawing.Point(193, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha y Hora Fin del Evento";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(44, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de Evento";
            // 
            // dtpFechaHoraFin
            // 
            this.dtpFechaHoraFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraFin.Location = new System.Drawing.Point(198, 108);
            this.dtpFechaHoraFin.Name = "dtpFechaHoraFin";
            this.dtpFechaHoraFin.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaHoraFin.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label9.Location = new System.Drawing.Point(191, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha y Hora inicio del Evento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(91, 244);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(208, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // dtpFechaHoraInicio
            // 
            this.dtpFechaHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraInicio.Location = new System.Drawing.Point(198, 42);
            this.dtpFechaHoraInicio.Name = "dtpFechaHoraInicio";
            this.dtpFechaHoraInicio.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaHoraInicio.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(43, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Evento";
            // 
            // nudCantidadIntegrantes
            // 
            this.nudCantidadIntegrantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudCantidadIntegrantes.Location = new System.Drawing.Point(198, 163);
            this.nudCantidadIntegrantes.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudCantidadIntegrantes.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidadIntegrantes.Name = "nudCantidadIntegrantes";
            this.nudCantidadIntegrantes.Size = new System.Drawing.Size(46, 20);
            this.nudCantidadIntegrantes.TabIndex = 30;
            this.nudCantidadIntegrantes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidadIntegrantes.Visible = false;
            // 
            // FormCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(688, 470);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCrearEvento";
            this.Text = "FormCrearEvento";
            this.Load += new System.EventHandler(this.FormCrearEvento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadIntegrantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTipoEvento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicio;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCategoriaEvento;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCaracteresRestantes;
        private System.Windows.Forms.NumericUpDown nudCantidadIntegrantes;
        private System.Windows.Forms.Label labelInscripcionInicio;
        private System.Windows.Forms.Label labelInscripcionFin;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicioInscripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFinInscripcion;
    }
}