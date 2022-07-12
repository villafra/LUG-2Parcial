using BE;
using Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BLL
{
    public class BLL_Piedra_Papel_Tijera : BLL_Juego,IGameable<BE_Piedra_Papel_Tijera>
    {
        MPP_Piedra_Papel_Tijera oMPP_Juego;

        public BLL_Piedra_Papel_Tijera()
        {
            oMPP_Juego = new MPP_Piedra_Papel_Tijera();
        }

        public bool GuardarPartida(BE_Piedra_Papel_Tijera Juego)
        {
            return oMPP_Juego.GuardarPartida(Juego);
        }

        public bool Instrucciones(BE_Piedra_Papel_Tijera Juego)
        {
            return oMPP_Juego.Instrucciones(Juego);
        }

        public List<BE_Piedra_Papel_Tijera> Listar()
        {
            return oMPP_Juego.Listar();
        }

        public override void PuntuarPartida()
        {
            throw new NotImplementedException();
        }
    }
}
