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
    }
}
