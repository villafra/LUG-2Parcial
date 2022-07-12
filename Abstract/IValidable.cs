using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    public interface IValidable<T> where T : IEntidable
    {
        bool Existe(T Jugador);
        bool ExisteActivo(T Jugador);
    }
}
