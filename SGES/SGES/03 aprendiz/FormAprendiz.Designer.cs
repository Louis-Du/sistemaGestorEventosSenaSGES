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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridViewAprend = new System.Windows.Forms.DataGridView();
            this.idEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantIntegrantes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRegGrupo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprend)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(48, 33);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.dataGridViewAprend);
            this.panel1.Controls.Add(this.btnRegGrupo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnRegistrarme);
            this.panel1.Location = new System.Drawing.Point(48, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(617, 318);
            this.panel1.TabIndex = 4;
            // 
            // dataGridViewAprend
            // 
            this.dataGridViewAprend.AllowUserToAddRows = false;
            this.dataGridViewAprend.AllowUserToDeleteRows = false;
            this.dataGridViewAprend.AllowUserToResizeColumns = false;
            this.dataGridViewAprend.AllowUserToResizeRows = false;
            this.dataGridViewAprend.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAprend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dataGridViewAprend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAprend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvento,
            this.Nombre,
            this.categoriaEvento,
            this.cantIntegrantes,
            this.Tipo,
            this.fechaHoraInicio,
            this.FechaHoraFin});
            this.dataGridViewAprend.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridViewAprend.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewAprend.Location = new System.Drawing.Point(-35, 75);
            this.dataGridViewAprend.MultiSelect = false;
            this.dataGridViewAprend.Name = "dataGridViewAprend";
            this.dataGridViewAprend.ReadOnly = true;
            this.dataGridViewAprend.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAprend.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewAprend.Size = new System.Drawing.Size(643, 149);
            this.dataGridViewAprend.TabIndex = 10;
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
            // btnRegGrupo
            // 
            this.btnRegGrupo.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegGrupo.Location = new System.Drawing.Point(129, 264);
            this.btnRegGrupo.Name = "btnRegGrupo";
            this.btnRegGrupo.Size = new System.Drawing.Size(134, 38);
            this.btnRegGrupo.TabIndex = 9;
            this.btnRegGrupo.Text = "Registrarme en grupo";
            this.btnRegGrupo.UseVisualStyleBackColor = false;
            this.btnRegGrupo.Click += new System.EventHandler(this.btnRegistrarmeEnGrupo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(29, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Listado de Eventos";
            // 
            // btnRegistrarme
            // 
            this.btnRegistrarme.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnRegistrarme.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistrarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegistrarme.Location = new System.Drawing.Point(312, 264);
            this.btnRegistrarme.Name = "btnRegistrarme";
            this.btnRegistrarme.Size = new System.Drawing.Size(134, 38);
            this.btnRegistrarme.TabIndex = 4;
            this.btnRegistrarme.Text = "Registrarme";
            this.btnRegistrarme.UseVisualStyleBackColor = false;
            this.btnRegistrarme.Click += new System.EventHandler(this.btnRegistrarme_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(186, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Eventos Disponibles";
            // 
            // FormAprendiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(734, 434);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAprendiz";
            this.Text = "FormAprendiz";
            this.Load += new System.EventHandler(this.FormAprendiz_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegGrupo;
        private System.Windows.Forms.DataGridView dataGridViewAprend;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantIntegrantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaHoraFin;
    }
}