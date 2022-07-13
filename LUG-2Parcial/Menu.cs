using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Estandarizacion;

namespace LUG_2Parcial
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Aspecto.FormatearForm(this, panelMenu);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmUsuarios);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmUsuarios();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }
    }
}
