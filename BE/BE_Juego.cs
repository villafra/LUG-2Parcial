using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BE
{
    public abstract class BE_Juego : IEntidable
    {
        public int Codigo { get ; set ; }
        public string Nombre { get; set; }
        public BE_Jugador Ganador { get; set; }

        public override string ToString()
        {
            return Nombre;
        }

        public enum Resultado
        {
            Empate=1,
            Victoria=2
        }
    }
}
