using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Abstract;
using BE;
using Mapper;

namespace BLL
{
    public class BLL_Ta_Te_Ti : BLL_Juego, IGameable<BE_Ta_Te_Ti>
    {
        MPP_Ta_Te_Ti oMPP_Ta_Te_Ti;
        public BLL_Ta_Te_Ti()
        {
            oMPP_Ta_Te_Ti = new MPP_Ta_Te_Ti();
        }

        public bool GuardarPartida(BE_Ta_Te_Ti Juego)
        {
            return oMPP_Ta_Te_Ti.GuardarPartida(Juego);
        }

        public bool Instrucciones(BE_Ta_Te_Ti Juego)
        {
            return oMPP_Ta_Te_Ti.Instrucciones(Juego);
        }

        public List<BE_Ta_Te_Ti> Listar()
        {
            return oMPP_Ta_Te_Ti.Listar();
        }

        public override void PuntuarPartida()
        {
            throw new NotImplementedException();
        }

        public (bool,BE_Ta_Te_Ti.XO) VerGanador(BE_Ta_Te_Ti Ta_Te_Ti)
        {
            bool ganador = false;
            BE_Ta_Te_Ti.XO quien=BE_Ta_Te_Ti.XO.Y;

            if (Ta_Te_Ti.btn1 == Ta_Te_Ti.btn2 && Ta_Te_Ti.btn1 == Ta_Te_Ti.btn3 && Ta_Te_Ti.btn1 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn1); }
            if (Ta_Te_Ti.btn1 == Ta_Te_Ti.btn4 && Ta_Te_Ti.btn1 == Ta_Te_Ti.btn7 && Ta_Te_Ti.btn1 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn1); }
            if (Ta_Te_Ti.btn1 == Ta_Te_Ti.btn5 && Ta_Te_Ti.btn1 == Ta_Te_Ti.btn9 && Ta_Te_Ti.btn1 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn1); }
            if (Ta_Te_Ti.btn4 == Ta_Te_Ti.btn5 && Ta_Te_Ti.btn4 == Ta_Te_Ti.btn6 && Ta_Te_Ti.btn4 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn4); }
            if (Ta_Te_Ti.btn7 == Ta_Te_Ti.btn8 && Ta_Te_Ti.btn7 == Ta_Te_Ti.btn9 && Ta_Te_Ti.btn7 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn7); }
            if (Ta_Te_Ti.btn7 == Ta_Te_Ti.btn5 && Ta_Te_Ti.btn7 == Ta_Te_Ti.btn3 && Ta_Te_Ti.btn7 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn7); }
            if (Ta_Te_Ti.btn2 == Ta_Te_Ti.btn5 && Ta_Te_Ti.btn2 == Ta_Te_Ti.btn8 && Ta_Te_Ti.btn2 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn2); }
            if (Ta_Te_Ti.btn3 == Ta_Te_Ti.btn6 && Ta_Te_Ti.btn3 == Ta_Te_Ti.btn9 && Ta_Te_Ti.btn3 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = Ta_Te_Ti.btn3); }
            if (Ta_Te_Ti.btn1 != BE_Ta_Te_Ti.XO.Y && Ta_Te_Ti.btn2 != BE_Ta_Te_Ti.XO.Y && Ta_Te_Ti.btn3 != BE_Ta_Te_Ti.XO.Y &&
                Ta_Te_Ti.btn4 != BE_Ta_Te_Ti.XO.Y && Ta_Te_Ti.btn5 != BE_Ta_Te_Ti.XO.Y && Ta_Te_Ti.btn6 != BE_Ta_Te_Ti.XO.Y &&
                Ta_Te_Ti.btn7 != BE_Ta_Te_Ti.XO.Y && Ta_Te_Ti.btn8 != BE_Ta_Te_Ti.XO.Y && Ta_Te_Ti.btn9 != BE_Ta_Te_Ti.XO.Y) { return (ganador = true, quien = BE_Ta_Te_Ti.XO.Y); }

            return (ganador, quien);
        }

        public void Limpiar(Panel panel, BE_Ta_Te_Ti nuevo)
        {
            foreach(Control cont in panel.Controls)
            {
                if (cont is Button)
                {
                    cont.Text = "";
                }
            }
            nuevo.btn1 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn2 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn3 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn4 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn5 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn6 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn7 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn8 = BE_Ta_Te_Ti.XO.Y;
            nuevo.btn9 = BE_Ta_Te_Ti.XO.Y;

        }
    }
}
