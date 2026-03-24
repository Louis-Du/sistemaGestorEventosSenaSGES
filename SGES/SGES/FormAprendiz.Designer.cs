namespace SGES
{
    partial class FormAprendiz
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
            this.grpbEventos = new System.Windows.Forms.GroupBox();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            this.dataGridViewAprend = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpbEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(63, 35);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // grpbEventos
            // 
            this.grpbEventos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbEventos.Controls.Add(this.dataGridViewAprend);
            this.grpbEventos.Controls.Add(this.btnRegistrarme);
            this.grpbEventos.Location = new System.Drawing.Point(120, 140);
            this.grpbEventos.Name = "grpbEventos";
            this.grpbEventos.Size = new System.Drawing.Size(522, 227);
            this.grpbEventos.TabIndex = 1;
            this.grpbEventos.TabStop = false;
            this.grpbEventos.Text = "Eventos";
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnRegistrarme.Location = new System.Drawing.Point(389, 174);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(96, 32);
            this.btnRegistrarme.TabIndex = 2;
            this.btnRegistrarme.Text = "Registrarme";
            this.btnRegistrarme.UseVisualStyleBackColor = false;
            // 
            // dataGridViewAprend
            // 
            this.dataGridViewAprend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAprend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Tipo,
            this.Fecha,
            this.Hora});
            this.dataGridViewAprend.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewAprend.Name = "dataGridViewAprend";
            this.dataGridViewAprend.Size = new System.Drawing.Size(510, 122);
            this.dataGridViewAprend.TabIndex = 3;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // Hora
            // 
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            // 
            // FormAprendiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbEventos);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAprendiz";
            this.Text = "FormAprendiz";
            this.grpbEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpbEventos;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.DataGridView dataGridViewAprend;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}