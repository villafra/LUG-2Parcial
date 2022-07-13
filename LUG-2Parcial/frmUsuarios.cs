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
        BE_Jugador NuevoPlayer;
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

            NuevoPlayer = new BE_Jugador(
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
            Aspecto.DGVUsuarios(dgvUsuarios);
        }
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Calculos.ValidarEntero(e);
        }

        private void btnNuevoUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos().Item1)
                {
                    if (oBLL_Jugador.Guardar(nuevo()))
                    {
                        Calculos.MsgBoxAlta(NuevoPlayer.ToString());
                    }
                    else
                    {
                        Calculos.MsgBoxNoAlta(NuevoPlayer.ToString());
                    }
                }
                else
                {
                    Calculos.MsgBox(ValidarCampos().Item2);
                }
            }
            catch (Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }
            finally { ActualizarListado(); }
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            try
            {
                viejo();
                if(Calculos.EstaSeguro("Modificar",Jugador.DNI, Jugador.ToString()))
                {
                     if (oBLL_Jugador.Modificar(Jugador))
                {
                    Calculos.MsgBoxMod(Jugador.ToString());
                    
                }
                else
                {
                    Calculos.MsgBoxNoMod(Jugador.ToString());
                }
                }
               
            }
            catch (Exception ex)
            {
                Calculos.MsgBox(ex.Message);
                
            }
            finally { ActualizarListado(); }
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
                if(Calculos.EstaSeguro("Eliminar", Jugador.Codigo, Jugador.ToString()))
                {
                    if (oBLL_Jugador.Baja(Jugador))
                    {
                        Calculos.MsgBoxBaja(Jugador.ToString());
                        
                    }
                    else
                    {
                        Calculos.MsgBoxNoBaja(Jugador.ToString());
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Calculos.MsgBox(ex.Message);
            }
            finally { ActualizarListado(); }
        }
        private (bool, string) ValidarCampos()
        {
            bool sino = true;
            string cual = "";

            if (!Calculos.LargoDNI(txtDNI.Text)) { sino = false; cual = "DNI"; }
            if (!Calculos.ValidarNombrePersonal(txtNombre.Text)) { sino = false; cual = "Nombre"; }
            if (!Calculos.ValidarApellido(txtApellido.Text)) { sino = false; cual = "Apellido"; }
            if (!Calculos.ValidarMail(txtMail.Text)) { sino = false; cual = "Mail"; }
            if (!Calculos.ValidarFecha(txtFechaNacimiento.Text)) { sino = false; cual = "Fecha de Nacimiento"; }
            if(!Calculos.ValidarNombrePersonal(txtLocalidad.Text)) { sino = false; cual = "Localidad"; }

            return (sino, cual);
        }
    }
}
