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
            this.btnRegGrupo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewAprend = new System.Windows.Forms.DataGridView();
            this.dgID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgHorafin = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.btnRegGrupo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewAprend);
            this.panel1.Controls.Add(this.btnRegistrarme);
            this.panel1.Location = new System.Drawing.Point(48, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 318);
            this.panel1.TabIndex = 4;
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
            this.btnRegGrupo.Click += new System.EventHandler(this.btnRegGrupo_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(8, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Listado de Eventos";
            // 
            // dataGridViewAprend
            // 
            this.dataGridViewAprend.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dataGridViewAprend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAprend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgID,
            this.dgNom,
            this.dgTipo,
            this.dgFecha,
            this.dgHoraInicio,
            this.dgHorafin});
            this.dataGridViewAprend.Location = new System.Drawing.Point(11, 34);
            this.dataGridViewAprend.Name = "dataGridViewAprend";
            this.dataGridViewAprend.Size = new System.Drawing.Size(552, 216);
            this.dataGridViewAprend.TabIndex = 5;
            this.dataGridViewAprend.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAprend_CellContentClick);
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
            this.dgFecha.DataPropertyName = "diaEvento";
            this.dgFecha.HeaderText = "Fecha";
            this.dgFecha.Name = "dgFecha";
            // 
            // dgHoraInicio
            // 
            this.dgHoraInicio.DataPropertyName = "fechaHoraInicio";
            this.dgHoraInicio.HeaderText = "Hora Inicio";
            this.dgHoraInicio.Name = "dgHoraInicio";
            // 
            // dgHorafin
            // 
            this.dgHorafin.DataPropertyName = "fechaHoraFin";
            this.dgHorafin.HeaderText = "Hora Fin";
            this.dgHorafin.Name = "dgHorafin";
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
            this.label1.Location = new System.Drawing.Point(163, 40);
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
            this.ClientSize = new System.Drawing.Size(688, 434);
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
        private System.Windows.Forms.DataGridView dataGridViewAprend;
        private System.Windows.Forms.Button btnRegistrarme;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgTipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgHorafin;
        private System.Windows.Forms.Button btnRegGrupo;
    }
}