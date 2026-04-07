namespace SGES
{
    partial class FormRegistroGrupo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegGrupo = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridViewSelec = new System.Windows.Forms.DataGridView();
            this.dgSelApr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSelnom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgSelemail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewGrupo = new System.Windows.Forms.DataGridView();
            this.dgApr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgNombreApr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.btnRegGrupo);
            this.panel1.Controls.Add(this.btnQuitar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.dataGridViewSelec);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridViewGrupo);
            this.panel1.Location = new System.Drawing.Point(27, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 299);
            this.panel1.TabIndex = 1;
            // 
            // btnRegGrupo
            // 
            this.btnRegGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegGrupo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnRegGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegGrupo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRegGrupo.Location = new System.Drawing.Point(577, 249);
            this.btnRegGrupo.Name = "btnRegGrupo";
            this.btnRegGrupo.Size = new System.Drawing.Size(101, 32);
            this.btnRegGrupo.TabIndex = 14;
            this.btnRegGrupo.Text = "Registrarse";
            this.btnRegGrupo.UseVisualStyleBackColor = false;
            this.btnRegGrupo.Click += new System.EventHandler(this.btnRegGrupo_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuitar.BackColor = System.Drawing.Color.Brown;
            this.btnQuitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuitar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuitar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuitar.Location = new System.Drawing.Point(435, 249);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(88, 32);
            this.btnQuitar.TabIndex = 13;
            this.btnQuitar.Text = "Quitar";
            this.btnQuitar.UseVisualStyleBackColor = false;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregar.Location = new System.Drawing.Point(150, 249);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(88, 32);
            this.btnAgregar.TabIndex = 12;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridViewSelec
            // 
            this.dataGridViewSelec.AllowUserToAddRows = false;
            this.dataGridViewSelec.AllowUserToDeleteRows = false;
            this.dataGridViewSelec.AllowUserToResizeColumns = false;
            this.dataGridViewSelec.AllowUserToResizeRows = false;
            this.dataGridViewSelec.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewSelec.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dataGridViewSelec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgSelApr,
            this.dgSelnom,
            this.dgSelemail});
            this.dataGridViewSelec.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridViewSelec.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewSelec.Location = new System.Drawing.Point(393, 35);
            this.dataGridViewSelec.MultiSelect = false;
            this.dataGridViewSelec.Name = "dataGridViewSelec";
            this.dataGridViewSelec.ReadOnly = true;
            this.dataGridViewSelec.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSelec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewSelec.Size = new System.Drawing.Size(321, 208);
            this.dataGridViewSelec.TabIndex = 11;
            // 
            // dgSelApr
            // 
            this.dgSelApr.DataPropertyName = "idApr";
            this.dgSelApr.HeaderText = "ID";
            this.dgSelApr.Name = "dgSelApr";
            this.dgSelApr.ReadOnly = true;
            // 
            // dgSelnom
            // 
            this.dgSelnom.DataPropertyName = "nombreApr";
            this.dgSelnom.HeaderText = "Aprendiz";
            this.dgSelnom.Name = "dgSelnom";
            this.dgSelnom.ReadOnly = true;
            // 
            // dgSelemail
            // 
            this.dgSelemail.DataPropertyName = "emailApr";
            this.dgSelemail.HeaderText = "Email";
            this.dgSelemail.Name = "dgSelemail";
            this.dgSelemail.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(458, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Aprendices Seleccionados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(90, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Aprendices Disponibles";
            // 
            // dataGridViewGrupo
            // 
            this.dataGridViewGrupo.AllowUserToAddRows = false;
            this.dataGridViewGrupo.AllowUserToDeleteRows = false;
            this.dataGridViewGrupo.AllowUserToResizeColumns = false;
            this.dataGridViewGrupo.AllowUserToResizeRows = false;
            this.dataGridViewGrupo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewGrupo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dataGridViewGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGrupo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgApr,
            this.dgNombreApr,
            this.dgEmail});
            this.dataGridViewGrupo.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridViewGrupo.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewGrupo.Location = new System.Drawing.Point(46, 35);
            this.dataGridViewGrupo.Name = "dataGridViewGrupo";
            this.dataGridViewGrupo.ReadOnly = true;
            this.dataGridViewGrupo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGrupo.Size = new System.Drawing.Size(295, 208);
            this.dataGridViewGrupo.TabIndex = 7;
            // 
            // dgApr
            // 
            this.dgApr.DataPropertyName = "idApr";
            this.dgApr.HeaderText = "ID";
            this.dgApr.Name = "dgApr";
            this.dgApr.ReadOnly = true;
            // 
            // dgNombreApr
            // 
            this.dgNombreApr.DataPropertyName = "nombreApr";
            this.dgNombreApr.HeaderText = "Aprendiz";
            this.dgNombreApr.Name = "dgNombreApr";
            this.dgNombreApr.ReadOnly = true;
            // 
            // dgEmail
            // 
            this.dgEmail.DataPropertyName = "emailApr";
            this.dgEmail.HeaderText = "Email";
            this.dgEmail.Name = "dgEmail";
            this.dgEmail.ReadOnly = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(27, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(154, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Registro en Grupo";
            // 
            // FormRegistroGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.panel1);
            this.Name = "FormRegistroGrupo";
            this.Text = "FormRegistroGrupo";
            this.Load += new System.EventHandler(this.FormRegistroGrupo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGrupo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgApr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgNombreApr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewSelec;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSelApr;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSelnom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgSelemail;
        private System.Windows.Forms.Button btnRegGrupo;
    }
}