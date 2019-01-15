namespace EjemploForms
{
    partial class Login
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cajaUsuario = new System.Windows.Forms.TextBox();
            this.cajaPass = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 197);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "Acceder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO";
            // 
            // cajaUsuario
            // 
            this.cajaUsuario.Location = new System.Drawing.Point(118, 86);
            this.cajaUsuario.Name = "cajaUsuario";
            this.cajaUsuario.Size = new System.Drawing.Size(175, 20);
            this.cajaUsuario.TabIndex = 3;
            // 
            // cajaPass
            // 
            this.cajaPass.Location = new System.Drawing.Point(118, 137);
            this.cajaPass.Name = "cajaPass";
            this.cajaPass.PasswordChar = '*';
            this.cajaPass.Size = new System.Drawing.Size(175, 20);
            this.cajaPass.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "CONTRASEÑA";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cajaUsuario);
            this.Controls.Add(this.cajaPass);
            this.Controls.Add(this.button1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox cajaUsuario;
        private System.Windows.Forms.TextBox cajaPass;
        private System.Windows.Forms.Label label2;
    }
}

