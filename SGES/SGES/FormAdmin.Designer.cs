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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCrearEvent = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnConsultarAprendicesRegistrados = new System.Windows.Forms.Button();
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.btnEliminarEvent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idEvento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(52, 35);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnExportar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnExportar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExportar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExportar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExportar.Location = new System.Drawing.Point(531, 35);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(96, 32);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = false;
            // 
            // btnCrearEvent
            // 
            this.btnCrearEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCrearEvent.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCrearEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCrearEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCrearEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCrearEvent.Location = new System.Drawing.Point(390, 35);
            this.btnCrearEvent.Name = "btnCrearEvent";
            this.btnCrearEvent.Size = new System.Drawing.Size(131, 32);
            this.btnCrearEvent.TabIndex = 5;
            this.btnCrearEvent.Text = "Crear evento";
            this.btnCrearEvent.UseVisualStyleBackColor = false;
            this.btnCrearEvent.Click += new System.EventHandler(this.btnCrearEvent_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnConsultarAprendicesRegistrados);
            this.panel1.Controls.Add(this.dataGridViewAdmin);
            this.panel1.Controls.Add(this.btnEliminarEvent);
            this.panel1.Location = new System.Drawing.Point(53, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 318);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(10, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Eventos";
            // 
            // btnConsultarAprendicesRegistrados
            // 
            this.btnConsultarAprendicesRegistrados.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnConsultarAprendicesRegistrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnConsultarAprendicesRegistrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultarAprendicesRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultarAprendicesRegistrados.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConsultarAprendicesRegistrados.Location = new System.Drawing.Point(40, 261);
            this.btnConsultarAprendicesRegistrados.Name = "btnConsultarAprendicesRegistrados";
            this.btnConsultarAprendicesRegistrados.Size = new System.Drawing.Size(179, 32);
            this.btnConsultarAprendicesRegistrados.TabIndex = 9;
            this.btnConsultarAprendicesRegistrados.Text = "Consultar Aprendices Registrados";
            this.btnConsultarAprendicesRegistrados.UseVisualStyleBackColor = false;
            this.btnConsultarAprendicesRegistrados.Click += new System.EventHandler(this.btnConsultarAprendicesRegistrados_Click_1);
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.AllowUserToAddRows = false;
            this.dataGridViewAdmin.AllowUserToDeleteRows = false;
            this.dataGridViewAdmin.AllowUserToResizeColumns = false;
            this.dataGridViewAdmin.AllowUserToResizeRows = false;
            this.dataGridViewAdmin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewAdmin.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEvento,
            this.Nombre,
            this.Tipo,
            this.Fecha,
            this.Hora});
            this.dataGridViewAdmin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dataGridViewAdmin.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(5, 29);
            this.dataGridViewAdmin.MultiSelect = false;
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.ReadOnly = true;
            this.dataGridViewAdmin.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewAdmin.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(562, 208);
            this.dataGridViewAdmin.TabIndex = 7;
            this.dataGridViewAdmin.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAdmin_CellContentClick);
            // 
            // btnEliminarEvent
            // 
            this.btnEliminarEvent.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminarEvent.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminarEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEliminarEvent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEliminarEvent.Location = new System.Drawing.Point(370, 261);
            this.btnEliminarEvent.Name = "btnEliminarEvent";
            this.btnEliminarEvent.Size = new System.Drawing.Size(123, 32);
            this.btnEliminarEvent.TabIndex = 6;
            this.btnEliminarEvent.Text = "Eliminar Evento";
            this.btnEliminarEvent.UseVisualStyleBackColor = false;
            this.btnEliminarEvent.Click += new System.EventHandler(this.btnEliminarEvent_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(155, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Panel de Administración";
            // 
            // idEvento
            // 
            this.idEvento.DataPropertyName = "idEvento";
            this.idEvento.HeaderText = "ID";
            this.idEvento.Name = "idEvento";
            this.idEvento.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "nombreEvento";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.DataPropertyName = "tipoEvento";
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "fechaEvento";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // Hora
            // 
            this.Hora.DataPropertyName = "horaEvento";
            this.Hora.HeaderText = "Hora";
            this.Hora.Name = "Hora";
            this.Hora.ReadOnly = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(688, 434);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCrearEvent);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnVolver);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCrearEvent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnConsultarAprendicesRegistrados;
        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Button btnEliminarEvent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hora;
    }
}