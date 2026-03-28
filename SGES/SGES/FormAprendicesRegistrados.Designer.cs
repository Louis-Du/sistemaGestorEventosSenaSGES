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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprendices)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAprendices
            // 
            this.dataGridViewAprendices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAprendices.Location = new System.Drawing.Point(36, 112);
            this.dataGridViewAprendices.Name = "dataGridViewAprendices";
            this.dataGridViewAprendices.Size = new System.Drawing.Size(534, 150);
            this.dataGridViewAprendices.TabIndex = 0;
            // 
            // FormAprendicesRegistrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 434);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridViewAprendices);
            this.Name = "FormAprendicesRegistrados";
            this.Text = "FormAprendicesRegistrados";
            this.Load += new System.EventHandler(this.FormAprendicesRegistrados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAprendices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAprendices;
    }
}