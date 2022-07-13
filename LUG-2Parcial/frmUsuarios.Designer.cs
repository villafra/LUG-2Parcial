namespace LUG_2Parcial
{
    partial class frmUsuarios
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
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.grpUsuarios = new System.Windows.Forms.GroupBox();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.btnNuevoUser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.grpUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(22, 33);
            this.dgvUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(743, 253);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // grpUsuarios
            // 
            this.grpUsuarios.Controls.Add(this.lblPuntuacion);
            this.grpUsuarios.Controls.Add(this.txtFechaNacimiento);
            this.grpUsuarios.Controls.Add(this.lblFechaNacimiento);
            this.grpUsuarios.Controls.Add(this.txtApellido);
            this.grpUsuarios.Controls.Add(this.label2);
            this.grpUsuarios.Controls.Add(this.txtCodigo);
            this.grpUsuarios.Controls.Add(this.lblCodigo);
            this.grpUsuarios.Controls.Add(this.txtLocalidad);
            this.grpUsuarios.Controls.Add(this.lblLocalidad);
            this.grpUsuarios.Controls.Add(this.txtMail);
            this.grpUsuarios.Controls.Add(this.lblMail);
            this.grpUsuarios.Controls.Add(this.txtNombre);
            this.grpUsuarios.Controls.Add(this.lblApellido);
            this.grpUsuarios.Controls.Add(this.txtDNI);
            this.grpUsuarios.Controls.Add(this.lblDNI);
            this.grpUsuarios.Location = new System.Drawing.Point(9, 291);
            this.grpUsuarios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpUsuarios.Name = "grpUsuarios";
            this.grpUsuarios.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpUsuarios.Size = new System.Drawing.Size(769, 147);
            this.grpUsuarios.TabIndex = 1;
            this.grpUsuarios.TabStop = false;
            this.grpUsuarios.Text = "Usuarios";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Location = new System.Drawing.Point(702, 69);
            this.lblPuntuacion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(19, 13);
            this.lblPuntuacion.TabIndex = 52;
            this.lblPuntuacion.Text = "10";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(11, 112);
            this.txtFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(126, 20);
            this.txtFechaNacimiento.TabIndex = 51;
            this.txtFechaNacimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(9, 88);
            this.lblFechaNacimiento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(93, 13);
            this.lblFechaNacimiento.TabIndex = 50;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(475, 48);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(158, 20);
            this.txtApellido.TabIndex = 49;
            this.txtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(472, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Apellido";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Enabled = false;
            this.txtCodigo.Location = new System.Drawing.Point(11, 48);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(95, 20);
            this.txtCodigo.TabIndex = 47;
            this.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(16, 24);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 46;
            this.lblCodigo.Text = "Codigo";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(194, 112);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(206, 20);
            this.txtLocalidad.TabIndex = 45;
            this.txtLocalidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(191, 88);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 44;
            this.lblLocalidad.Text = "Localidad";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(419, 112);
            this.txtMail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(183, 20);
            this.txtMail.TabIndex = 43;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(417, 88);
            this.lblMail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(35, 13);
            this.lblMail.TabIndex = 42;
            this.lblMail.Text = "e-Mail";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(270, 48);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(165, 20);
            this.txtNombre.TabIndex = 41;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(268, 24);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 40;
            this.lblApellido.Text = "Nombre";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(140, 48);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(90, 20);
            this.txtDNI.TabIndex = 39;
            this.txtDNI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(138, 24);
            this.lblDNI.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 38;
            this.lblDNI.Text = "DNI";
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.BackgroundImage = global::LUG_2Parcial.Properties.Resources.Picture1;
            this.btnEliminarUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminarUser.FlatAppearance.BorderSize = 0;
            this.btnEliminarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarUser.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarUser.ForeColor = System.Drawing.Color.Gold;
            this.btnEliminarUser.Location = new System.Drawing.Point(658, 440);
            this.btnEliminarUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(82, 86);
            this.btnEliminarUser.TabIndex = 7;
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            this.btnEliminarUser.Click += new System.EventHandler(this.btnEliminarUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.BackgroundImage = global::LUG_2Parcial.Properties.Resources.Picture6;
            this.btnEditUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditUser.FlatAppearance.BorderSize = 0;
            this.btnEditUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditUser.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditUser.ForeColor = System.Drawing.Color.Gold;
            this.btnEditUser.Location = new System.Drawing.Point(356, 443);
            this.btnEditUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(67, 85);
            this.btnEditUser.TabIndex = 6;
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // btnNuevoUser
            // 
            this.btnNuevoUser.BackgroundImage = global::LUG_2Parcial.Properties.Resources.Picture3;
            this.btnNuevoUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNuevoUser.FlatAppearance.BorderSize = 0;
            this.btnNuevoUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoUser.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoUser.ForeColor = System.Drawing.Color.Gold;
            this.btnNuevoUser.Location = new System.Drawing.Point(46, 448);
            this.btnNuevoUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNuevoUser.Name = "btnNuevoUser";
            this.btnNuevoUser.Size = new System.Drawing.Size(75, 76);
            this.btnNuevoUser.TabIndex = 5;
            this.btnNuevoUser.UseVisualStyleBackColor = true;
            this.btnNuevoUser.Click += new System.EventHandler(this.btnNuevoUser_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 533);
            this.Controls.Add(this.btnEliminarUser);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnNuevoUser);
            this.Controls.Add(this.grpUsuarios);
            this.Controls.Add(this.dgvUsuarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmUsuarios";
            this.Text = "Usuarios";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.grpUsuarios.ResumeLayout(false);
            this.grpUsuarios.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.GroupBox grpUsuarios;
        private System.Windows.Forms.Label lblUsuarios;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.TextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Button btnEliminarUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.Button btnNuevoUser;
    }
}