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

        public override int PuntuarPartida(BE_Juego.Resultado resultado)
        {
            if (resultado == BE_Juego.Resultado.Victoria)
            {
                return 3;
            }
            else
            {
                return 1;
            }
        }

        public BE_Piedra_Papel_Tijera.PPT DevolverJugada()
        {
            Random rand = new Random();
            int juego = rand.Next(1,4);
            return (BE_Piedra_Papel_Tijera.PPT)juego;
        }
        public (bool, BE_Piedra_Papel_Tijera.PPT) VerGanador(BE_Piedra_Papel_Tijera PPT)
        {
            bool ganador = false;
            BE_Piedra_Papel_Tijera.PPT quien = BE_Piedra_Papel_Tijera.PPT.State;

            if(PPT.Opcion1 == BE_Piedra_Papel_Tijera.PPT.Piedra && PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Tijera
                || PPT.Opcion1 == BE_Piedra_Papel_Tijera.PPT.Tijera && PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Papel
                || PPT.Opcion1 == BE_Piedra_Papel_Tijera.PPT.Papel && PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Piedra) 
            { ganador = true; quien = PPT.Opcion1; }
            if(PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Piedra && PPT.Opcion1 == BE_Piedra_Papel_Tijera.PPT.Tijera
                || PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Tijera && PPT.Opcion1 == BE_Piedra_Papel_Tijera.PPT.Papel
                || PPT.Opcion2 == BE_Piedra_Papel_Tijera.PPT.Papel && PPT.Opcion1 == BE_Piedra_Papel_Tijera.PPT.Piedra)
            { ganador = true; quien = PPT.Opcion2; }

            return (ganador, quien);
        }
    }
}
