namespace SGES
{
    partial class FormEditarEvent
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblCaracteresRestantes = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCantidadIntegrantes = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoriaEvento = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelarAct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.btnActualizarEvent = new System.Windows.Forms.Button();
            this.txtNombreEvento1 = new System.Windows.Forms.TextBox();
            this.cbTipoEvento1 = new System.Windows.Forms.ComboBox();
            this.labelInscripcionInicio = new System.Windows.Forms.Label();
            this.labelInscripcionFin = new System.Windows.Forms.Label();
            this.dtpFechaHoraInicioInscripcion = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaHoraFinInscripcion = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadIntegrantes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(75, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 47);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.label3.Location = new System.Drawing.Point(102, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editar Evento";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblCaracteresRestantes);
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
            this.labelInscripcionInicio.Location = new System.Drawing.Point(62, 190);
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
            this.dtpFechaHoraInicioInscripcion.Location = new System.Drawing.Point(220, 190);
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
            this.labelInscripcionFin.Location = new System.Drawing.Point(62, 220);
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
            this.dtpFechaHoraFinInscripcion.Location = new System.Drawing.Point(220, 220);
            this.dtpFechaHoraFinInscripcion.Name = "dtpFechaHoraFinInscripcion";
            this.dtpFechaHoraFinInscripcion.Size = new System.Drawing.Size(140, 20);
            this.dtpFechaHoraFinInscripcion.TabIndex = 43;
            this.panel1.Controls.Add(this.dtpFechaHoraFinInscripcion);
                private System.Windows.Forms.Label labelInscripcionInicio;
                private System.Windows.Forms.Label labelInscripcionFin;
                private System.Windows.Forms.DateTimePicker dtpFechaHoraInicioInscripcion;
                private System.Windows.Forms.DateTimePicker dtpFechaHoraFinInscripcion;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.nudCantidadIntegrantes);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.cbCategoriaEvento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.dtpFechaHoraFin);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCancelarAct);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dtpFechaHoraInicio);
            this.panel1.Controls.Add(this.btnActualizarEvent);
            this.panel1.Controls.Add(this.txtNombreEvento1);
            this.panel1.Controls.Add(this.cbTipoEvento1);
            this.panel1.Location = new System.Drawing.Point(75, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 336);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblCaracteresRestantes
            // 
            this.lblCaracteresRestantes.AutoSize = true;
            this.lblCaracteresRestantes.Font = new System.Drawing.Font("Segoe UI Historic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaracteresRestantes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblCaracteresRestantes.Location = new System.Drawing.Point(64, 57);
            this.lblCaracteresRestantes.Name = "lblCaracteresRestantes";
            this.lblCaracteresRestantes.Size = new System.Drawing.Size(128, 13);
            this.lblCaracteresRestantes.TabIndex = 30;
            this.lblCaracteresRestantes.Text = "Caracteres restantes: 50";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label8.Location = new System.Drawing.Point(222, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(145, 16);
            this.label8.TabIndex = 30;
            this.label8.Text = "Cantidad de integantes";
            this.label8.Visible = false;
            // 
            // nudCantidadIntegrantes
            // 
            this.nudCantidadIntegrantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nudCantidadIntegrantes.Location = new System.Drawing.Point(223, 158);
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
            this.nudCantidadIntegrantes.TabIndex = 29;
            this.nudCantidadIntegrantes.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidadIntegrantes.Visible = false;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label7.Location = new System.Drawing.Point(62, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 28;
            this.label7.Text = "Categoria";
            // 
            // cbCategoriaEvento
            // 
            this.cbCategoriaEvento.FormattingEnabled = true;
            this.cbCategoriaEvento.Items.AddRange(new object[] {
            "Grupal",
            "Individual"});
            this.cbCategoriaEvento.Location = new System.Drawing.Point(65, 157);
            this.cbCategoriaEvento.Name = "cbCategoriaEvento";
            this.cbCategoriaEvento.Size = new System.Drawing.Size(121, 21);
            this.cbCategoriaEvento.TabIndex = 27;
            this.cbCategoriaEvento.SelectedIndexChanged += new System.EventHandler(this.cbCategoriaEvento_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label6.Location = new System.Drawing.Point(218, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Fecha y Hora Fin del Evento";
            // 
            // dtpFechaHoraFin
            // 
            this.dtpFechaHoraFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraFin.Location = new System.Drawing.Point(220, 99);
            this.dtpFechaHoraFin.Name = "dtpFechaHoraFin";
            this.dtpFechaHoraFin.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaHoraFin.TabIndex = 16;
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.lblID.Location = new System.Drawing.Point(175, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 16);
            this.lblID.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(218, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha y Hora inicio del Evento";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(64, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de Evento";
            // 
            // btnCancelarAct
            // 
            this.btnCancelarAct.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelarAct.BackColor = System.Drawing.Color.Brown;
            this.btnCancelarAct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelarAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAct.ForeColor = System.Drawing.Color.White;
            this.btnCancelarAct.Location = new System.Drawing.Point(113, 251);
            this.btnCancelarAct.Name = "btnCancelarAct";
            this.btnCancelarAct.Size = new System.Drawing.Size(208, 40);
            this.btnCancelarAct.TabIndex = 11;
            this.btnCancelarAct.Text = "Cancelar";
            this.btnCancelarAct.UseVisualStyleBackColor = false;
            this.btnCancelarAct.Click += new System.EventHandler(this.btnCancelarAct_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(60, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Evento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(60, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 6;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpFechaHoraInicio
            // 
            this.dtpFechaHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraInicio.Location = new System.Drawing.Point(220, 32);
            this.dtpFechaHoraInicio.Name = "dtpFechaHoraInicio";
            this.dtpFechaHoraInicio.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaHoraInicio.TabIndex = 2;
            this.dtpFechaHoraInicio.ValueChanged += new System.EventHandler(this.dtpFechaHoraEvento1_ValueChanged);
            // 
            // btnActualizarEvent
            // 
            this.btnActualizarEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActualizarEvent.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnActualizarEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActualizarEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizarEvent.Location = new System.Drawing.Point(113, 205);
            this.btnActualizarEvent.Name = "btnActualizarEvent";
            this.btnActualizarEvent.Size = new System.Drawing.Size(208, 40);
            this.btnActualizarEvent.TabIndex = 3;
            this.btnActualizarEvent.Text = "Actualizar Evento";
            this.btnActualizarEvent.UseVisualStyleBackColor = false;
            this.btnActualizarEvent.Click += new System.EventHandler(this.btnActualizarEvent_Click);
            // 
            // txtNombreEvento1
            // 
            this.txtNombreEvento1.Location = new System.Drawing.Point(63, 34);
            this.txtNombreEvento1.MaxLength = 50;
            this.txtNombreEvento1.Name = "txtNombreEvento1";
            this.txtNombreEvento1.Size = new System.Drawing.Size(129, 20);
            this.txtNombreEvento1.TabIndex = 0;
            this.txtNombreEvento1.TextChanged += new System.EventHandler(this.txtNombreEvento1_TextChanged);
            // 
            // cbTipoEvento1
            // 
            this.cbTipoEvento1.FormattingEnabled = true;
            this.cbTipoEvento1.Items.AddRange(new object[] {
            "Educativo",
            "Cultural",
            "Deportivo"});
            this.cbTipoEvento1.Location = new System.Drawing.Point(63, 99);
            this.cbTipoEvento1.Name = "cbTipoEvento1";
            this.cbTipoEvento1.Size = new System.Drawing.Size(129, 21);
            this.cbTipoEvento1.TabIndex = 1;
            // 
            // FormEditarEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(596, 451);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormEditarEvent";
            this.Text = "FormEditarEvent";
            this.Load += new System.EventHandler(this.FormEditarEvent_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadIntegrantes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelarAct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicio;
        private System.Windows.Forms.Button btnActualizarEvent;
        private System.Windows.Forms.TextBox txtNombreEvento1;
        private System.Windows.Forms.ComboBox cbTipoEvento1;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoriaEvento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nudCantidadIntegrantes;
        private System.Windows.Forms.Label lblCaracteresRestantes;
        private System.Windows.Forms.Label labelInscripcionInicio;
        private System.Windows.Forms.Label labelInscripcionFin;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicioInscripcion;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFinInscripcion;
    }
}