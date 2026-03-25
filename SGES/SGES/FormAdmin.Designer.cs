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
            this.grpbEventos = new System.Windows.Forms.GroupBox();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminarEvent = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnConsultarReg = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCrearEvent = new System.Windows.Forms.Button();
            this.grpbEventos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbEventos
            // 
            this.grpbEventos.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.grpbEventos.Controls.Add(this.btnConsultarReg);
            this.grpbEventos.Controls.Add(this.dataGridViewAdmin);
            this.grpbEventos.Controls.Add(this.btnEliminarEvent);
            this.grpbEventos.Location = new System.Drawing.Point(120, 140);
            this.grpbEventos.Name = "grpbEventos";
            this.grpbEventos.Size = new System.Drawing.Size(522, 227);
            this.grpbEventos.TabIndex = 2;
            this.grpbEventos.TabStop = false;
            this.grpbEventos.Text = "Eventos";
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Tipo,
            this.Fecha,
            this.Hora});
            this.dataGridViewAdmin.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.Size = new System.Drawing.Size(510, 122);
            this.dataGridViewAdmin.TabIndex = 3;
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
            // btnEliminarEvent
            // 
            this.btnEliminarEvent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEliminarEvent.Location = new System.Drawing.Point(383, 174);
            this.btnEliminarEvent.Name = "btnEliminarEvent";
            this.btnEliminarEvent.Size = new System.Drawing.Size(109, 32);
            this.btnEliminarEvent.TabIndex = 2;
            this.btnEliminarEvent.Text = "Eliminar Evento";
            this.btnEliminarEvent.UseVisualStyleBackColor = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(63, 35);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // btnConsultarReg
            // 
            this.btnConsultarReg.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConsultarReg.Location = new System.Drawing.Point(37, 174);
            this.btnConsultarReg.Name = "btnConsultarReg";
            this.btnConsultarReg.Size = new System.Drawing.Size(109, 32);
            this.btnConsultarReg.TabIndex = 4;
            this.btnConsultarReg.Text = "Consultar Registros";
            this.btnConsultarReg.UseVisualStyleBackColor = false;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(603, 35);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(96, 32);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnCrearEvent
            // 
            this.btnCrearEvent.Location = new System.Drawing.Point(568, 83);
            this.btnCrearEvent.Name = "btnCrearEvent";
            this.btnCrearEvent.Size = new System.Drawing.Size(131, 32);
            this.btnCrearEvent.TabIndex = 5;
            this.btnCrearEvent.Text = "Crear evento";
            this.btnCrearEvent.UseVisualStyleBackColor = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCrearEvent);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.grpbEventos);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.grpbEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbEventos;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
        private System.Windows.Forms.Button btnEliminarEvent;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnConsultarReg;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCrearEvent;
    }
}