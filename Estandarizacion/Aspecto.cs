using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Estandarizacion
{
    public static class Aspecto
    {

        #region Formatear Formulario

  
        public static Action<Form, Panel> FormatearForm = (formulario, panel) =>
        {
            formulario.FormBorderStyle = new FormBorderStyle();
            formulario.BackColor = Color.FromArgb(46, 51, 73);
            formulario.AutoScroll = true;
            formulario.IsMdiContainer = true;
            panel.BackColor = Color.FromArgb(24, 30, 54);
            panel.Dock = DockStyle.Left;
            FormatearBotonEnPanel(panel);
            FormatearMenuStrip(formulario);
        };

        public static Action<Form, GroupBox> FormatearLogin = (formulario, grp) =>
        {
            formulario.FormBorderStyle = new FormBorderStyle();
            formulario.BackColor = Color.FromArgb(46, 51, 73);
            formulario.AutoScroll = true;
            FormatearGRP(grp);
        };
        public static Action<Form> FormatearCambioPass = (formulario) =>
        {
            formulario.FormBorderStyle = new FormBorderStyle();
            formulario.BackColor = Color.FromArgb(46, 51, 73);
            formulario.AutoScroll = true;

        };

        public static Action<Form> FormatearFormHijo = (formulario) =>
        {
            formulario.BackColor = Color.FromArgb(46, 51, 73);
            formulario.AutoScroll = true;
        };

        public static Action<Form, Form> AbrirNuevoForm = (formPadre, FormHijo) =>
        {
            FormHijo.MdiParent = formPadre;
            FormHijo.TopLevel = false;
            FormHijo.Dock = DockStyle.Fill;
            FormHijo.Show();
            FormatearFormHijo(FormHijo);
            FormHijo.Show();
        };

        public static Action<Panel> FormatearBotonEnPanel = (panel) =>
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button) FormatearBoton(control as Button);
            }
        };

        public static Action<Button> FormatearBoton = (boton) =>
        {
            boton.BackColor = Color.FromArgb(24, 30, 54);
            boton.ForeColor = Color.FromArgb(0, 126, 249);
            boton.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatStyle = FlatStyle.Flat;
            boton.TextAlign = ContentAlignment.MiddleRight;
            boton.ImageAlign = ContentAlignment.MiddleLeft;
        };

        public static Action<Button> FormatearBotonInterno = (boton) =>
        {
            boton.BackColor = Color.FromArgb(46, 51, 73);
            boton.ForeColor = Color.FromArgb(0, 126, 249);
            boton.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            boton.FlatAppearance.BorderSize = 0;
            boton.FlatStyle = FlatStyle.Flat;
            boton.TextAlign = ContentAlignment.MiddleRight;
            boton.ImageAlign = ContentAlignment.MiddleLeft;
        };



        #endregion

        public static Action<Form> FormatearMenuStrip = (form) =>
        {
            foreach (Control control in form.Controls)
            {
                if (control is MenuStrip)
                {
                    control.BackColor = Color.FromArgb(24, 30, 54);
                    control.ForeColor = Color.FromArgb(0, 126, 249);
                    control.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
                }

            }

        };
        public static Action<TabControl> FormatearTab = (tab) =>
        {
            tab.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            foreach (TabPage page in tab.TabPages)
            {
                FormatearControlExterno(page);
            }
        };
        public static Action<GroupBox> FormatearGRP = (grp) =>
        {
            FormatearControlExterno(grp);

            foreach (Control c in grp.Controls)
            {
                if (c is TextBox) FormatearControlInterno(c as TextBox);
                else if (c is NumericUpDown) FormatearControlInterno(c as NumericUpDown);
                else if (c is ComboBox) FormatearControlInterno(c as ComboBox);
                else if (c is RadioButton) FormatearControlInterno(c as RadioButton);
                else if (c is CheckBox) FormatearControlInterno(c as CheckBox);
                else if (c is ProgressBar) FormatearControlInterno(c as ProgressBar);
            }
        };
        public static Action<Control> FormatearControlExterno = (obj) =>
        {
            obj.BackColor = Color.FromArgb(46, 51, 73);
            obj.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            obj.ForeColor = Color.FromArgb(0, 126, 249);
        };
        public static Action<Control> FormatearControlInterno = (obj) =>
        {
            obj.BackColor = Color.FromArgb(46, 51, 73);
            obj.ForeColor = Color.White;
        };
        public static Action<DataGridView> FormatearDGV = (dgv) =>
        {
            dgv.BackgroundColor = Color.FromArgb(46, 51, 73); //(44, 68, 101);
            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(56, 62, 131);
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(0, 126, 249);
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = SystemColors.Highlight;
            dgv.ColumnHeadersDefaultCellStyle.SelectionForeColor = SystemColors.HighlightText;
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.DefaultCellStyle.BackColor = Color.FromArgb(150, 86, 192);
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(120, 86, 192);
            dgv.DefaultCellStyle.Font = new Font("Nirmala UI", 10, FontStyle.Bold);
            dgv.DefaultCellStyle.ForeColor = Color.White;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(51, 137, 166);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EnableHeadersVisualStyles = false;
            dgv.GridColor = Color.FromArgb(44, 68, 101);
            dgv.RowHeadersVisible = false;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowMode.None;

        };



        public static Action<Panel> FormatearPanelMenu = (panel) =>
        {
            panel.BackColor = Color.FromArgb(46, 51, 73);
            panel.Visible = true;

        };

        public static Action<Panel, Button> CambiarColoresBtn = (panel, boton) =>
        {
            panel.Height = boton.Height;
            panel.Top = boton.Top;
            panel.Left = boton.Left;
            boton.BackColor = Color.FromArgb(46, 51, 73);
        };
        public static Action<Button> DevolverColorBtn = (boton) =>
        {
            boton.BackColor = Color.FromArgb(24, 30, 54);
        };

        #region FormatearDGV
        public static void DGVUsuarios(DataGridView dgv)
        {
            dgv.Columns[0].HeaderText = "Código";
            dgv.Columns[1].HeaderText = "DNI";
            dgv.Columns[2].HeaderText = "Nombre";
            dgv.Columns[3].HeaderText = "Apellido";
            dgv.Columns[4].HeaderText = "eMail";
            dgv.Columns[5].Visible = false;
            dgv.Columns[6].HeaderText = "Fecha de Nacimiento";
            dgv.Columns[7].HeaderText = "Localidad";
            dgv.Columns[8].Visible = false;
            foreach (DataGridViewColumn columns in dgv.Columns)
            {
                columns.SortMode = DataGridViewColumnSortMode.NotSortable;
                columns.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        #endregion


    }
}
