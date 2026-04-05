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
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.cbTipoEvento = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtidEvento = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHoraFinEvento = new System.Windows.Forms.DateTimePicker();
            this.dtpHoraInicioEvento = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaEvento = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaHoraFin = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpFechaHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(87, 72);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(200, 20);
            this.txtNombreEvento.TabIndex = 0;
            // 
            // cbTipoEvento
            // 
            this.cbTipoEvento.FormattingEnabled = true;
            this.cbTipoEvento.Items.AddRange(new object[] {
            "Educativo",
            "Competencia",
            "Laboral"});
            this.cbTipoEvento.Location = new System.Drawing.Point(87, 114);
            this.cbTipoEvento.Name = "cbTipoEvento";
            this.cbTipoEvento.Size = new System.Drawing.Size(200, 21);
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
            this.btnGuardar.Location = new System.Drawing.Point(87, 235);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(208, 40);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Evento";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtidEvento
            // 
            this.txtidEvento.Location = new System.Drawing.Point(87, 30);
            this.txtidEvento.Name = "txtidEvento";
            this.txtidEvento.Size = new System.Drawing.Size(200, 20);
            this.txtidEvento.TabIndex = 5;
            this.txtidEvento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtidEvento_KeyPress);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(143, 48);
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
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.dtpHoraFinEvento);
            this.panel1.Controls.Add(this.dtpHoraInicioEvento);
            this.panel1.Controls.Add(this.dtpFechaEvento);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtidEvento);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.txtNombreEvento);
            this.panel1.Controls.Add(this.cbTipoEvento);
            this.panel1.Location = new System.Drawing.Point(143, 96);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 326);
            this.panel1.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label7.Location = new System.Drawing.Point(158, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Inicio/Fin";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dtpHoraFinEvento
            // 
            this.dtpHoraFinEvento.Location = new System.Drawing.Point(224, 199);
            this.dtpHoraFinEvento.Name = "dtpHoraFinEvento";
            this.dtpHoraFinEvento.Size = new System.Drawing.Size(64, 20);
            this.dtpHoraFinEvento.TabIndex = 20;
            this.dtpHoraFinEvento.ValueChanged += new System.EventHandler(this.dtpHoraFinEvento_ValueChanged);
            // 
            // dtpHoraInicioEvento
            // 
            this.dtpHoraInicioEvento.Location = new System.Drawing.Point(88, 199);
            this.dtpHoraInicioEvento.Name = "dtpHoraInicioEvento";
            this.dtpHoraInicioEvento.Size = new System.Drawing.Size(65, 20);
            this.dtpHoraInicioEvento.TabIndex = 19;
            this.dtpHoraInicioEvento.ValueChanged += new System.EventHandler(this.dtpHoraInicioEvento_ValueChanged);
            // 
            // dtpFechaEvento
            // 
            this.dtpFechaEvento.Location = new System.Drawing.Point(87, 157);
            this.dtpFechaEvento.Name = "dtpFechaEvento";
            this.dtpFechaEvento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaEvento.TabIndex = 18;
            this.dtpFechaEvento.ValueChanged += new System.EventHandler(this.dtpFechaEvento_ValueChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label6.Location = new System.Drawing.Point(85, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Horas del Evento";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label5.Location = new System.Drawing.Point(85, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Fecha del Evento";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label4.Location = new System.Drawing.Point(84, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tipo de Evento";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(87, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(208, 40);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label2.Location = new System.Drawing.Point(84, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre del Evento";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label1.Location = new System.Drawing.Point(85, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID del Evento";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label8.Location = new System.Drawing.Point(578, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Fecha y Hora Fin del Evento";
            // 
            // dtpFechaHoraFin
            // 
            this.dtpFechaHoraFin.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraFin.Location = new System.Drawing.Point(580, 263);
            this.dtpFechaHoraFin.Name = "dtpFechaHoraFin";
            this.dtpFechaHoraFin.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaHoraFin.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(213)))), ((int)(((byte)(225)))));
            this.label9.Location = new System.Drawing.Point(578, 193);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Fecha y Hora Fin del Evento";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dtpFechaHoraInicio
            // 
            this.dtpFechaHoraInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraInicio.Location = new System.Drawing.Point(580, 211);
            this.dtpFechaHoraInicio.Name = "dtpFechaHoraInicio";
            this.dtpFechaHoraInicio.Size = new System.Drawing.Size(129, 20);
            this.dtpFechaHoraInicio.TabIndex = 18;
            // 
            // FormCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(688, 434);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaHoraFin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpFechaHoraInicio);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormCrearEvento";
            this.Text = "FormCrearEvento";
            this.Load += new System.EventHandler(this.FormCrearEvento_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.ComboBox cbTipoEvento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtidEvento;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpHoraInicioEvento;
        private System.Windows.Forms.DateTimePicker dtpFechaEvento;
        private System.Windows.Forms.DateTimePicker dtpHoraFinEvento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraFin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraInicio;
    }
}