namespace LUG_2Parcial
{
    partial class Login
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
            this.grpLogin = new System.Windows.Forms.GroupBox();
            this.txtPass1 = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.picLogin = new System.Windows.Forms.PictureBox();
            this.tntPass2 = new System.Windows.Forms.TextBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.Controls.Add(this.tntPass2);
            this.grpLogin.Controls.Add(this.txtPass1);
            this.grpLogin.Controls.Add(this.txtUsuario);
            this.grpLogin.Location = new System.Drawing.Point(311, 59);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(344, 199);
            this.grpLogin.TabIndex = 9;
            this.grpLogin.TabStop = false;
            this.grpLogin.Text = "Login";
            // 
            // txtPass1
            // 
            this.txtPass1.Location = new System.Drawing.Point(20, 112);
            this.txtPass1.Name = "txtPass1";
            this.txtPass1.PasswordChar = '*';
            this.txtPass1.Size = new System.Drawing.Size(310, 22);
            this.txtPass1.TabIndex = 1;
            this.txtPass1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass1.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(20, 52);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(310, 22);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::LUG_2Parcial.Properties.Resources.logout;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(23, 264);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 70);
            this.btnExit.TabIndex = 10;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::LUG_2Parcial.Properties.Resources.perfil_del_usuario;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(428, 264);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 70);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // picLogin
            // 
            this.picLogin.Image = global::LUG_2Parcial.Properties.Resources.acceso;
            this.picLogin.Location = new System.Drawing.Point(23, 22);
            this.picLogin.Name = "picLogin";
            this.picLogin.Size = new System.Drawing.Size(271, 236);
            this.picLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogin.TabIndex = 7;
            this.picLogin.TabStop = false;
            // 
            // tntPass2
            // 
            this.tntPass2.Location = new System.Drawing.Point(20, 162);
            this.tntPass2.Name = "tntPass2";
            this.tntPass2.PasswordChar = '*';
            this.tntPass2.Size = new System.Drawing.Size(310, 22);
            this.tntPass2.TabIndex = 2;
            this.tntPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tntPass2.UseSystemPasswordChar = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 352);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picLogin);
            this.Controls.Add(this.grpLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.Text = "Login";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picLogin;
        private System.Windows.Forms.GroupBox grpLogin;
        private System.Windows.Forms.TextBox txtPass1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox tntPass2;
    }
}