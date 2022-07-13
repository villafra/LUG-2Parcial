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
            Aspecto.FormatearDGV(dgvUsuarios);
            Aspecto.FormatearGRP(grpUsuarios);
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
             txtLocalidad.Text
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
           Calculos.RefreshGrilla(dgvUsuarios, oBLL_Jugador.Listar());
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
                oBLL_Jugador.Modificar(Jugador);
            }
            catch (Exception ex)
            {

                
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Jugador = (BE_Jugador)dgvUsuarios.CurrentRow.DataBoundItem;
            txtCodigo.Text = Jugador.Codigo.ToString();
            txtDNI.Text = Jugador.DNI.ToString();
            txtNombre.Text = Jugador.Nombre;
            txtApellido.Text = Jugador.Apellido;
            txtMail.Text = Jugador.eMail;
            txtFechaNacimiento.Text = Jugador.FechaNacimiento.ToString("dd/MM/yyyy");
            txtLocalidad.Text = Jugador.Localidad;
            lblPuntuacion.Text = Jugador.Puntuacion.ToString();
        }

        private void btnEliminarUser_Click(object sender, EventArgs e)
        {
            try
            {
                oBLL_Jugador.Baja(Jugador);
            }
            catch (Exception ex)
            {


            }
        }
    }
}
