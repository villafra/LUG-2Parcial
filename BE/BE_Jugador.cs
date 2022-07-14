using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstract;

namespace BE
{
    public class BE_Jugador: IEntidable
    {
        public int Codigo { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string eMail { get; set; }
        public string Password { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Localidad { get; set; }
        public int Puntuacion { get; set; }

        public BE_Jugador()
        {
        }

        public BE_Jugador(int dNI, string nombre, string apellido, string eMail, DateTime fechaNacimiento, string localidad)
        {
            DNI = dNI;
            Nombre = nombre;
            Apellido = apellido;
            this.eMail = eMail;
            FechaNacimiento = fechaNacimiento;
            Localidad = localidad;
        }

        public override string ToString()
        {
            return this.Nombre + " " + this.Apellido;
        }
    }
}
