namespace LUG_2Parcial
{
    partial class frmPPT
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
            this.panelPPT = new System.Windows.Forms.Panel();
            this.btnPapel = new System.Windows.Forms.Button();
            this.btnTijera = new System.Windows.Forms.Button();
            this.btnPiedra = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.grpJugador1 = new System.Windows.Forms.GroupBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.panelPPT.SuspendLayout();
            this.grpJugador1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPPT
            // 
            this.panelPPT.Controls.Add(this.btnPapel);
            this.panelPPT.Controls.Add(this.btnTijera);
            this.panelPPT.Controls.Add(this.btnPiedra);
            this.panelPPT.Controls.Add(this.btnOpcion2);
            this.panelPPT.Controls.Add(this.btnOpcion1);
            this.panelPPT.Enabled = false;
            this.panelPPT.Location = new System.Drawing.Point(78, 32);
            this.panelPPT.Name = "panelPPT";
            this.panelPPT.Size = new System.Drawing.Size(895, 428);
            this.panelPPT.TabIndex = 0;
            // 
            // btnPapel
            // 
            this.btnPapel.BackgroundImage = global::LUG_2Parcial.Properties.Resources.papel;
            this.btnPapel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPapel.Location = new System.Drawing.Point(378, 333);
            this.btnPapel.Name = "btnPapel";
            this.btnPapel.Size = new System.Drawing.Size(138, 67);
            this.btnPapel.TabIndex = 4;
            this.btnPapel.UseVisualStyleBackColor = true;
            this.btnPapel.Click += new System.EventHandler(this.btnPapel_Click);
            // 
            // btnTijera
            // 
            this.btnTijera.BackgroundImage = global::LUG_2Parcial.Properties.Resources.tijera;
            this.btnTijera.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTijera.Location = new System.Drawing.Point(722, 333);
            this.btnTijera.Name = "btnTijera";
            this.btnTijera.Size = new System.Drawing.Size(138, 67);
            this.btnTijera.TabIndex = 3;
            this.btnTijera.UseVisualStyleBackColor = true;
            this.btnTijera.Click += new System.EventHandler(this.btnTijera_Click);
            // 
            // btnPiedra
            // 
            this.btnPiedra.BackgroundImage = global::LUG_2Parcial.Properties.Resources.piedra;
            this.btnPiedra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPiedra.Location = new System.Drawing.Point(34, 333);
            this.btnPiedra.Name = "btnPiedra";
            this.btnPiedra.Size = new System.Drawing.Size(138, 67);
            this.btnPiedra.TabIndex = 2;
            this.btnPiedra.UseVisualStyleBackColor = true;
            this.btnPiedra.Click += new System.EventHandler(this.btnPiedra_Click);
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.BackgroundImage = global::LUG_2Parcial.Properties.Resources.Pictu2re2;
            this.btnOpcion2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpcion2.Location = new System.Drawing.Point(492, 26);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(368, 221);
            this.btnOpcion2.TabIndex = 1;
            this.btnOpcion2.UseVisualStyleBackColor = true;
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.BackgroundImage = global::LUG_2Parcial.Properties.Resources.Pictu2re2;
            this.btnOpcion1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnOpcion1.Location = new System.Drawing.Point(34, 26);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(368, 221);
            this.btnOpcion1.TabIndex = 0;
            this.btnOpcion1.UseVisualStyleBackColor = true;
            // 
            // grpJugador1
            // 
            this.grpJugador1.Controls.Add(this.lblPass);
            this.grpJugador1.Controls.Add(this.lblUsuario);
            this.grpJugador1.Controls.Add(this.btnLogin);
            this.grpJugador1.Controls.Add(this.txtPass);
            this.grpJugador1.Controls.Add(this.txtUsuario);
            this.grpJugador1.Location = new System.Drawing.Point(281, 466);
            this.grpJugador1.Name = "grpJugador1";
            this.grpJugador1.Size = new System.Drawing.Size(486, 186);
            this.grpJugador1.TabIndex = 2;
            this.grpJugador1.TabStop = false;
            this.grpJugador1.Text = "Jugador 1";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(260, 36);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(67, 16);
            this.lblPass.TabIndex = 11;
            this.lblPass.Text = "Password";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(31, 36);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(40, 16);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "eMail";
            // 
            // btnLogin
            // 
            this.btnLogin.BackgroundImage = global::LUG_2Parcial.Properties.Resources.perfil_del_usuario;
            this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(203, 108);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(90, 70);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(263, 64);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(203, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(34, 64);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(203, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmPPT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 656);
            this.Controls.Add(this.grpJugador1);
            this.Controls.Add(this.panelPPT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPPT";
            this.Text = "frmPPT";
            this.panelPPT.ResumeLayout(false);
            this.grpJugador1.ResumeLayout(false);
            this.grpJugador1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPPT;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnPapel;
        private System.Windows.Forms.Button btnTijera;
        private System.Windows.Forms.Button btnPiedra;
        private System.Windows.Forms.GroupBox grpJugador1;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}