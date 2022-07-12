using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface IGameable<T> where T : IEntidable
    {
        bool GuardarPartida(T Juego);
        bool Instrucciones(T Juego);
        List<T> Listar();

    }
}
