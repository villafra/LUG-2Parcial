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
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Usuarios);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new Usuarios();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void btnTaTeTi_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is TATETI);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new TATETI();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void btnPPT_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is PPT);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new PPT();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }

        private void btnInformes_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frmGraficos);
            if (frm != null)
            {
                frm.BringToFront();
                return;
            }
            else
            {
                frm = new frmGraficos();
                Aspecto.AbrirNuevoForm(this, frm);
            }
        }
    }
}
