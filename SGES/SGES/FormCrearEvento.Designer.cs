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
            this.dtpFechaHoraEvento = new System.Windows.Forms.DateTimePicker();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtidEvento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(167, 143);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEvento.TabIndex = 0;
            // 
            // cbTipoEvento
            // 
            this.cbTipoEvento.FormattingEnabled = true;
            this.cbTipoEvento.Items.AddRange(new object[] {
            "Educativo",
            "Competencia",
            "Laboral"});
            this.cbTipoEvento.Location = new System.Drawing.Point(314, 143);
            this.cbTipoEvento.Name = "cbTipoEvento";
            this.cbTipoEvento.Size = new System.Drawing.Size(121, 21);
            this.cbTipoEvento.TabIndex = 1;
            // 
            // dtpFechaHoraEvento
            // 
            this.dtpFechaHoraEvento.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFechaHoraEvento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaHoraEvento.Location = new System.Drawing.Point(456, 140);
            this.dtpFechaHoraEvento.Name = "dtpFechaHoraEvento";
            this.dtpFechaHoraEvento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaHoraEvento.TabIndex = 2;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(326, 225);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 41);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "Guardar Evento";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtidEvento
            // 
            this.txtidEvento.Location = new System.Drawing.Point(35, 140);
            this.txtidEvento.Name = "txtidEvento";
            this.txtidEvento.Size = new System.Drawing.Size(100, 20);
            this.txtidEvento.TabIndex = 5;
            // 
            // FormCrearEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtidEvento);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dtpFechaHoraEvento);
            this.Controls.Add(this.cbTipoEvento);
            this.Controls.Add(this.txtNombreEvento);
            this.Name = "FormCrearEvento";
            this.Text = "FormCrearEvento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.ComboBox cbTipoEvento;
        private System.Windows.Forms.DateTimePicker dtpFechaHoraEvento;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtidEvento;
    }
}