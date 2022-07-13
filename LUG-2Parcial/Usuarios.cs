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
using BE;
using BLL;

namespace LUG_2Parcial
{
    public partial class Usuarios : Form
    {
        BE_Jugador Jugador;
        BLL_Jugador BLL_Jugador;
        public Usuarios()
        {
            InitializeComponent();
            Jugador = new BE_Jugador();
            BLL_Jugador = new BLL_Jugador();
        }
        private void nuevo()
        {
            BE_Jugador NuevoPlayer = new BE_Jugador(
             Convert.ToInt32(txtDNI.Text),
             txtNombre.Text,
             txtApellido.Text,
             txtMail.Text,
             Convert.ToDateTime(txtFechaNacimiento.Text),
             txtLocalidad.Text,
             Convert.ToInt32(lblPuntuacion.Text)
             ); 
        }
        private void viejo()
        {
            Jugador.Codigo = Convert.ToInt32(txtCodigo.Text);
            Jugador.DNI = Convert.ToInt32(txtDNI.Text);
            Jugador.Nombre = txtNombre.Text;
            Jugador.Apellido = txtApellido.Text;
            Jugador.Localidad = txtLocalidad.Text;
            Jugador.FechaNacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            Jugador.eMail = txtMail.Text;
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarEntero(e);
        }
    }
}
