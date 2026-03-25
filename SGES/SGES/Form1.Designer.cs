namespace SGES
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbLogin = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtpasswordusuario = new System.Windows.Forms.TextBox();
            this.txtidusuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpbLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpbLogin
            // 
            this.grpbLogin.BackColor = System.Drawing.SystemColors.Control;
            this.grpbLogin.Controls.Add(this.button1);
            this.grpbLogin.Controls.Add(this.txtpasswordusuario);
            this.grpbLogin.Controls.Add(this.txtidusuario);
            this.grpbLogin.Controls.Add(this.label2);
            this.grpbLogin.Controls.Add(this.label1);
            this.grpbLogin.Location = new System.Drawing.Point(176, 102);
            this.grpbLogin.Name = "grpbLogin";
            this.grpbLogin.Size = new System.Drawing.Size(443, 245);
            this.grpbLogin.TabIndex = 0;
            this.grpbLogin.TabStop = false;
            this.grpbLogin.Text = "Login";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(169, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Iniciar Sesión";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtpasswordusuario
            // 
            this.txtpasswordusuario.Location = new System.Drawing.Point(160, 127);
            this.txtpasswordusuario.Name = "txtpasswordusuario";
            this.txtpasswordusuario.Size = new System.Drawing.Size(124, 20);
            this.txtpasswordusuario.TabIndex = 3;
            // 
            // txtidusuario
            // 
            this.txtidusuario.Location = new System.Drawing.Point(159, 68);
            this.txtidusuario.Name = "txtidusuario";
            this.txtidusuario.Size = new System.Drawing.Size(125, 20);
            this.txtidusuario.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número de identificación:";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpbLogin);
            this.Name = "FormLogin";
            this.Text = "SGES";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.grpbLogin.ResumeLayout(false);
            this.grpbLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbLogin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtpasswordusuario;
        private System.Windows.Forms.TextBox txtidusuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

