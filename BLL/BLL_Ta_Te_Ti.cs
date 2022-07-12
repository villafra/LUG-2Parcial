using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
