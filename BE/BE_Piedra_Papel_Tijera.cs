using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Piedra_Papel_Tijera:BE_Juego
    {
        public PPT Opcion1 { get; set; }
        public PPT Opcion2 { get; set; }

        public BE_Piedra_Papel_Tijera()
        {
            this.Codigo = 2;
            this.Nombre = "Piedra, Papel o Tijera";
        }

        public enum PPT
        {
            State=0,
            Piedra=1,
            Papel=2,
            Tijera=3
        }
    }
}
