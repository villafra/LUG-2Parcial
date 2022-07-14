using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using BLL;
using Estandarizacion;

namespace LUG_2Parcial
{
    public partial class PPT : Form
    {
        BLL_Piedra_Papel_Tijera oBLL_PPT;
        BE_Piedra_Papel_Tijera oBE_PPT;
        BLL_Jugador BLLjugador;
        BE_Jugador Jugador;
        public PPT()
        {
            InitializeComponent();
            oBE_PPT = new BE_Piedra_Papel_Tijera();
            oBLL_PPT = new BLL_Piedra_Papel_Tijera();
            BLLjugador = new BLL_Jugador();
        }

        private void VerJugada()
        {
            oBE_PPT.Opcion2 = oBLL_PPT.DevolverJugada();
            ElejirFoto();
            if (oBLL_PPT.VerGanador(oBE_PPT).Item1)
            {
                if(oBLL_PPT.VerGanador(oBE_PPT).Item2 == oBE_PPT.Opcion1)
                {
                    Calculos.MsgBox("Has ganado");
                    oBE_PPT.Ganador = Jugador;
                    oBLL_PPT.GuardarPartida(oBE_PPT);
                    Jugador.Puntuacion += oBLL_PPT.PuntuarPartida(BE_Juego.Resultado.Victoria);
                    BLLjugador.Modificar(Jugador);
                    NuevaPartida();
                }
                else
                {
                    Calculos.MsgBox("Has perdido");
                    oBE_PPT.Ganador = Jugador;
                    oBLL_PPT.GuardarPartida(oBE_PPT);
                    NuevaPartida();
                }
            }
            else
            {
                Calculos.MsgBox("Es un empate");
                oBE_PPT.Ganador = Jugador;
                oBLL_PPT.GuardarPartida(oBE_PPT);
                Jugador.Puntuacion += oBLL_PPT.PuntuarPartida(BE_Juego.Resultado.Empate);
                BLLjugador.Modificar(Jugador);
                NuevaPartida();
            }
        }

        private void ElejirFoto()
        {
            if (oBE_PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Piedra)
            {
                btnOpcion2.BackgroundImage = global::LUG_2Parcial.Properties.Resources.piedra;
            }
            else if (oBE_PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Papel)
            {
                btnOpcion2.BackgroundImage = global::LUG_2Parcial.Properties.Resources.papel;
            }
            else
            {
                btnOpcion2.BackgroundImage = global::LUG_2Parcial.Properties.Resources.tijera;
            }
        }
        private void NuevaPartida()
        {
            btnOpcion2.BackgroundImage = global::LUG_2Parcial.Properties.Resources.Pictu2re2;
            btnOpcion1.BackgroundImage = global::LUG_2Parcial.Properties.Resources.Pictu2re2;
            oBE_PPT.Ganador = null;

        }

        private void btnPiedra_Click(object sender, EventArgs e)
        {
            oBE_PPT.Opcion1 = BE_Piedra_Papel_Tijera.PPT.Piedra;
            btnOpcion1.BackgroundImage = global::LUG_2Parcial.Properties.Resources.piedra;
            VerJugada();
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            oBE_PPT.Opcion1 = BE_Piedra_Papel_Tijera.PPT.Papel;
            btnOpcion1.BackgroundImage = global::LUG_2Parcial.Properties.Resources.papel;
            VerJugada();
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            oBE_PPT.Opcion1 = BE_Piedra_Papel_Tijera.PPT.Tijera;
            btnOpcion1.BackgroundImage = global::LUG_2Parcial.Properties.Resources.tijera;
            VerJugada();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BE_Jugador jug1 = new BE_Jugador();
            jug1.eMail = txtUsuario.Text;
            jug1.Password = txtPass.Text;
            if (BLLjugador.ExisteActivo(jug1))
            {
                if (BLLjugador.Login(jug1))
                {
                    Jugador = BLLjugador.ListarObjeto(jug1);
                    Calculos.MsgBox(Jugador.ToString() + " se ha logueado");
                    HabilitarPanel();
                }
                else
                {
                    Calculos.MsgBox("La contraseña es incorrecta");
                }
            }
            else
            {
                Calculos.MsgBox("El eMail es inexistente");
            }
        }

        private void HabilitarPanel()
        {
            if (Jugador != null) { panelPPT.Enabled = true; }
        }
    }
}
