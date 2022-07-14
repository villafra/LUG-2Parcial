using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;


namespace BLL
{
    public abstract class BLL_Juego
    {
        public abstract int PuntuarPartida(BE_Juego.Resultado resultado);
    }
}
