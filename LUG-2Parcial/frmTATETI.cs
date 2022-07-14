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
        private bool quien = true;
        private BE_Jugador jugador1;
        private BE_Jugador jugador2;
        public frmTATETI()
        {
            InitializeComponent();
            Ta_Te_Ti = new BE_Ta_Te_Ti();
            oBLL_TaTeTi = new BLL_Ta_Te_Ti();
        }
        private BE_Ta_Te_Ti.XO Jugar()
        {
            if (quien)
            {
                return BE_Ta_Te_Ti.XO.X;
            }
            else { return BE_Ta_Te_Ti.XO.O; }
        }
        private void CambiarEstado()
        {
            if (quien) { quien=false; }
            else { quien=true; }
        }
        private void NuevaPartida()
        {
            quien = true;
            oBLL_TaTeTi.Limpiar(panelTATETI, Ta_Te_Ti);
            if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item2 == BE_Ta_Te_Ti.XO.X)
            {
                Calculos.MsgBox("El ganador ha sido el jugador: " + jugador1.ToString());
            }
            else if (oBLL_TaTeTi.VerGanador(Ta_Te_Ti).Item2 == BE_Ta_Te_Ti.XO.Y)
            {
                Calculos.MsgBox("El ganador ha sido el jugador: " + jugador2.ToString());
            }
            else
            {
                Calculos.MsgBox("Ha habido un empate.");
            }

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
    }
}
