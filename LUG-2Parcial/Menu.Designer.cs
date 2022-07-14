namespace LUG_2Parcial
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnPPT = new System.Windows.Forms.Button();
            this.FotosBotones = new System.Windows.Forms.ImageList(this.components);
            this.btnTaTeTi = new System.Windows.Forms.Button();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.picgames = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picgames)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.Controls.Add(this.btnPPT);
            this.panelMenu.Controls.Add(this.btnTaTeTi);
            this.panelMenu.Controls.Add(this.btnInformes);
            this.panelMenu.Controls.Add(this.btnUsuarios);
            this.panelMenu.Controls.Add(this.picgames);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(245, 677);
            this.panelMenu.TabIndex = 1;
            // 
            // btnPPT
            // 
            this.btnPPT.ImageKey = "Picture2.png";
            this.btnPPT.ImageList = this.FotosBotones;
            this.btnPPT.Location = new System.Drawing.Point(3, 447);
            this.btnPPT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPPT.Name = "btnPPT";
            this.btnPPT.Size = new System.Drawing.Size(239, 84);
            this.btnPPT.TabIndex = 4;
            this.btnPPT.Text = "Piedra, Papel\r\no Tijera";
            this.btnPPT.UseVisualStyleBackColor = true;
            this.btnPPT.Click += new System.EventHandler(this.btnPPT_Click);
            // 
            // FotosBotones
            // 
            this.FotosBotones.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("FotosBotones.ImageStream")));
            this.FotosBotones.TransparentColor = System.Drawing.Color.Transparent;
            this.FotosBotones.Images.SetKeyName(0, "computer-1331579_640.png");
            this.FotosBotones.Images.SetKeyName(1, "analitica.png");
            this.FotosBotones.Images.SetKeyName(2, "Picture1.jpg");
            this.FotosBotones.Images.SetKeyName(3, "Picture2.png");
            // 
            // btnTaTeTi
            // 
            this.btnTaTeTi.ImageKey = "Picture1.jpg";
            this.btnTaTeTi.ImageList = this.FotosBotones;
            this.btnTaTeTi.Location = new System.Drawing.Point(3, 359);
            this.btnTaTeTi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaTeTi.Name = "btnTaTeTi";
            this.btnTaTeTi.Size = new System.Drawing.Size(239, 84);
            this.btnTaTeTi.TabIndex = 3;
            this.btnTaTeTi.Text = "Ta - Te - Ti";
            this.btnTaTeTi.UseVisualStyleBackColor = true;
            this.btnTaTeTi.Click += new System.EventHandler(this.btnTaTeTi_Click);
            // 
            // btnInformes
            // 
            this.btnInformes.ImageKey = "analitica.png";
            this.btnInformes.ImageList = this.FotosBotones;
            this.btnInformes.Location = new System.Drawing.Point(3, 271);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(239, 84);
            this.btnInformes.TabIndex = 2;
            this.btnInformes.Text = "Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.ImageIndex = 0;
            this.btnUsuarios.ImageList = this.FotosBotones;
            this.btnUsuarios.Location = new System.Drawing.Point(3, 183);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(239, 84);
            this.btnUsuarios.TabIndex = 1;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // picgames
            // 
            this.picgames.Image = global::LUG_2Parcial.Properties.Resources.Sin_título1;
            this.picgames.Location = new System.Drawing.Point(3, 2);
            this.picgames.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picgames.Name = "picgames";
            this.picgames.Size = new System.Drawing.Size(240, 134);
            this.picgames.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picgames.TabIndex = 0;
            this.picgames.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 677);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picgames)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox picgames;
        private System.Windows.Forms.Button btnPPT;
        private System.Windows.Forms.Button btnTaTeTi;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.ImageList FotosBotones;
    }
}

