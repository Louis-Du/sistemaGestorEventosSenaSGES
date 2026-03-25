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
            this.dataGridViewAprend = new System.Windows.Forms.DataGridView();
            this.btnRegistrarme = new System.Windows.Forms.Button();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            // dataGridViewAprend
            // 
            this.dataGridViewAprend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAprend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgNom,
            this.dgTipo,
            this.dgFecha,
            this.dgHora});
            this.dataGridViewAprend.Location = new System.Drawing.Point(6, 29);
            this.dataGridViewAprend.Name = "dataGridViewAprend";
            this.dataGridViewAprend.Size = new System.Drawing.Size(510, 122);
            this.dataGridViewAprend.TabIndex = 3;
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
            // dgID
            // 
            this.dgID.DataPropertyName = "idEvento";
            this.dgID.HeaderText = "ID";
            this.dgID.Name = "dgID";
            // 
            // dgNom
            // 
            this.dgNom.DataPropertyName = "nombreEvento";
            this.dgNom.HeaderText = "Nombre";
            this.dgNom.Name = "dgNom";
            // 
            // dgTipo
            // 
            this.dgTipo.DataPropertyName = "tipoEvento";
            this.dgTipo.HeaderText = "Tipo";
            this.dgTipo.Name = "dgTipo";
            // 
            // dgFecha
            // 
            this.dgFecha.DataPropertyName = "fechaEvento";
            this.dgFecha.HeaderText = "Fecha";
            this.dgFecha.Name = "dgFecha";
            // 
            // dgHora
            // 
            this.dgHora.DataPropertyName = "horaEvento";
            this.dgHora.HeaderText = "Hora";
            this.dgHora.Name = "dgHora";
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
            this.Load += new System.EventHandler(this.FormAprendiz_Load);
            this.grpbEventos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.GroupBox grpbEventos;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.DataGridView dataGridViewAprend;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHora;
    }
}