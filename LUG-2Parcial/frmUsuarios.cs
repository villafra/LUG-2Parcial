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
    public partial class frmUsuarios : Form
    {
        BE_Jugador Jugador;
        BLL_Jugador oBLL_Jugador;
        public frmUsuarios()
        {
            InitializeComponent();
            Jugador = new BE_Jugador();
            oBLL_Jugador = new BLL_Jugador();
            ActualizarListado();
        }
        private BE_Jugador nuevo()
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
            return NuevoPlayer;
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
        private void ActualizarListado()
        {
           Calculos.RefreshGrilla(dataGridView1, oBLL_Jugador.Listar());
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarEntero(e);
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            try
            {
                oBLL_Jugador.Guardar(nuevo());
            }
            catch (Exception ex)
            {
                
            }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                viejo();
                oBLL_Jugador.Guardar(Jugador);
            }
            catch (Exception ex)
            {

                
            }
        }
    }
}
