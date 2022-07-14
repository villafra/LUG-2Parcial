using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BE_Ta_Te_Ti:BE_Juego
    {
        public XO btn1 { get; set; }
        public XO btn2 { get; set; }
        public XO btn3 { get; set; }
        public XO btn4 { get; set; }
        public XO btn5 { get; set; }
        public XO btn6 { get; set; }
        public XO btn7 { get; set; }
        public XO btn8 { get; set; }
        public XO btn9 { get; set; }

        public BE_Ta_Te_Ti()
        {
            this.Codigo = 1;
            this.Nombre = "Ta-Te-Ti";
        }
        public enum XO
        {
            Y,
            X,
            O
        }
    }
}
