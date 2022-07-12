using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;
using BE;

namespace Mapper
{
    public class MPP_Jugador : IValidable<BE_Jugador>, IGestionable<BE_Jugador>
    {
        public bool Baja(BE_Jugador Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(BE_Jugador Jugador)
        {
            throw new NotImplementedException();
        }

        public bool ExisteActivo(BE_Jugador Jugador)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Jugador Objeto)
        {
            throw new NotImplementedException();
        }

        public List<BE_Jugador> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Jugador ListarObjeto(BE_Jugador Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
