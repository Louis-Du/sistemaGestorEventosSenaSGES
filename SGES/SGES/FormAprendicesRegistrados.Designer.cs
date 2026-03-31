namespace SGES
{
    partial class FormAprendicesRegistrados
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
            this.dataGridViewAprendices = new System.Windows.Forms.DataGridView();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprendices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAprendices
            // 
            this.dataGridViewAprendices.AllowUserToAddRows = false;
            this.dataGridViewAprendices.AllowUserToDeleteRows = false;
            this.dataGridViewAprendices.AllowUserToResizeColumns = false;
            this.dataGridViewAprendices.AllowUserToResizeRows = false;
            this.dataGridViewAprendices.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(85)))));
            this.dataGridViewAprendices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAprendices.Location = new System.Drawing.Point(34, 134);
            this.dataGridViewAprendices.MultiSelect = false;
            this.dataGridViewAprendices.Name = "dataGridViewAprendices";
            this.dataGridViewAprendices.ReadOnly = true;
            this.dataGridViewAprendices.Size = new System.Drawing.Size(345, 204);
            this.dataGridViewAprendices.TabIndex = 0;
            this.dataGridViewAprendices.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAprendices_CellContentClick);
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(100)))));
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVolver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnVolver.Location = new System.Drawing.Point(34, 58);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(96, 32);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(115, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Aprendices registrados";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormAprendicesRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(41)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(423, 363);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.dataGridViewAprendices);
            this.Name = "FormAprendicesRegistrados";
            this.Text = "FormAprendicesRegistrados";
            this.Load += new System.EventHandler(this.FormAprendicesRegistrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprendices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAprendices;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
    }
}