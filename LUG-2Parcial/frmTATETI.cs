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
    public partial class frmTATETI : Form
    {
        BE_Ta_Te_Ti Ta_Te_Ti;
        BLL_Ta_Te_Ti oBLL_TaTeTi;
        BLL_Jugador BLLjugador;
        private bool quien = true;
        private BE_Jugador jugador1;
        private BE_Jugador jugador2;
        public frmTATETI()
        {
            InitializeComponent();
            Ta_Te_Ti = new BE_Ta_Te_Ti();
            oBLL_TaTeTi = new BLL_Ta_Te_Ti();
            BLLjugador = new BLL_Jugador();
        }
        private BE_Ta_Te_Ti.XO Jugar()
        {
            if (quien)
            {
                return BE_Ta_Te_Ti.XO.X;
            }
            else { return BE_Ta_Te_Ti.XO.O; }
        }
        private void HabilitarPanel()
        {
            if (jugador1 != null && jugador2 != null) { panelTATETI.Enabled = true; }
        }
        private void CambiarEstado()
        {
            if (quien) { quien=false; lblJugando.Text = jugador2.ToString(); }
            else { quien=true; lblJugando.Text = jugador1.ToString(); }
        }
        private void NuevaPartida()
        {
            
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item2 == BE_Ta_Te_Ti.XO.X)
            {
                Calculos.MsgBox("El ganador ha sido el jugador: " + jugador1.ToString());
                Ta_Te_Ti.Ganador = jugador1;
                oBLL_TaTeTi.GuardarPartida(Ta_Te_Ti);
                jugador1.Puntuacion += oBLL_TaTeTi.PuntuarPartida(BE_Juego.Resultado.Victoria);
                BLLjugador.Modificar(jugador1);
            }
            else if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item2 == BE_Ta_Te_Ti.XO.Y)
            {
                Calculos.MsgBox("El ganador ha sido el jugador: " + jugador2.ToString());
                Ta_Te_Ti.Ganador = jugador2;
                oBLL_TaTeTi.GuardarPartida(Ta_Te_Ti);
                jugador2.Puntuacion += oBLL_TaTeTi.PuntuarPartida(BE_Juego.Resultado.Victoria);
                BLLjugador.Modificar(jugador2);
            }
            else
            {
                Calculos.MsgBox("Ha habido un empate.");
                oBLL_TaTeTi.GuardarPartida(Ta_Te_Ti);
                jugador1.Puntuacion += oBLL_TaTeTi.PuntuarPartida(BE_Juego.Resultado.Empate);
                jugador2.Puntuacion += oBLL_TaTeTi.PuntuarPartida(BE_Juego.Resultado.Empate);
                BLLjugador.Modificar(jugador1);
                BLLjugador.Modificar(jugador2);
            }
            quien = true;
            oBLL_TaTeTi.Limpiar(panelTATETI, Ta_Te_Ti);
            lblJugando.Text = "";
            Ta_Te_Ti.Ganador = null;
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                Ta_Te_Ti.btn1 = Jugar();
                btn1.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                Ta_Te_Ti.btn2 = Jugar();
                btn2.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                Ta_Te_Ti.btn3 = Jugar();
                btn3.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                Ta_Te_Ti.btn4 = Jugar();
                btn4.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                Ta_Te_Ti.btn5 = Jugar();
                btn5.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                Ta_Te_Ti.btn6 = Jugar();
                btn6.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if(btn7.Text == "")
            {
                Ta_Te_Ti.btn7 = Jugar();
                btn7.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                Ta_Te_Ti.btn8 = Jugar();
                btn8.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }

        }

        private void btn9_Click(object sender, EventArgs e)
        {
           if (btn9.Text == "")
            {
                Ta_Te_Ti.btn9 = Jugar();
                btn9.Text = Jugar().ToString();
                CambiarEstado();
            }
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item1)
            {
                NuevaPartida();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BE_Jugador jug1 = new BE_Jugador() ;
            jug1.eMail = txtUsuario.Text;
            jug1.Password = txtPass.Text;
            if (BLLjugador.ExisteActivo(jug1))
            {
                if (BLLjugador.Login(jug1))
                {
                    jugador1 = BLLjugador.ListarObjeto(jug1);
                    Calculos.MsgBox(jugador1.ToString() + " se ha logueado");
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

        private void btnLogin2_Click(object sender, EventArgs e)
        {
            BE_Jugador jug2 = new BE_Jugador();
            jug2.eMail = txtUsuario2.Text;
            jug2.Password = txtPass2.Text;
            if (BLLjugador.ExisteActivo(jug2))
            {
                if (BLLjugador.Login(jug2))
                {
                    jugador2 = BLLjugador.ListarObjeto(jug2);
                    Calculos.MsgBox(jugador2.ToString() + " se ha logueado");
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
    }
}
