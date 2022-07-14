using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using Abstract;
using Mapper;

namespace BLL
{
    public class BLL_Jugador : IValidable<BE_Jugador>,IGestionable<BE_Jugador>
    {
        MPP_Jugador oMPP_Jugador;

        public BLL_Jugador()
        {
            oMPP_Jugador = new MPP_Jugador();
        }

        public bool Baja(BE_Jugador Jugador)
        {
            return oMPP_Jugador.Baja(Jugador);
        }

        public bool Existe(BE_Jugador Jugador)
        {
            return oMPP_Jugador.Existe(Jugador);
        }
        public bool Login(BE_Jugador Jugador)
        {
            return oMPP_Jugador.Login(Jugador);
        }
        public bool ExisteActivo(BE_Jugador Jugador)
        {
            return oMPP_Jugador.ExisteActivo(Jugador);
        }

        public bool Guardar(BE_Jugador Jugador)
        {
            return oMPP_Jugador.Guardar(Jugador);
        }
        public bool Modificar(BE_Jugador Jugador)
        {
            return oMPP_Jugador.Modificar(Jugador);
        }
            public List<BE_Jugador> Listar()
        {
            return oMPP_Jugador.Listar();
        }

        public BE_Jugador ListarObjeto(BE_Jugador Jugador)
        {
            return oMPP_Jugador.ListarObjeto(Jugador);
        }
    }
}
