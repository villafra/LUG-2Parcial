using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using Abstract;
using BE;

namespace Mapper
{
    public class MPP_Ta_Te_Ti : IGameable<BE_Ta_Te_Ti>
    {
        public bool GuardarPartida(BE_Ta_Te_Ti Juego)
        {
            try
            {
                XDocument xmlDoc;
                if (!File.Exists("Datos Juegos.xml"))
                {
                    xmlDoc = new XDocument(
                         new XDeclaration("1.0", "UTF-8", "yes"),
                         new XComment("Registro de Juegos Jugados."));
                    XElement nuevo = new XElement("Registro");
                    xmlDoc.Add(nuevo);
                }
                else
                {
                    xmlDoc = XDocument.Load("Datos Juegos.xml");
                }

                xmlDoc.Element("Registro").Add(new XElement("Juego",
                                             new XAttribute("ID", Juego.Codigo.ToString()),
                                             new XElement("Nombre", Juego.ToString()),
                                             new XElement("Jugador", 
                                             new XAttribute("ID", Juego.Ganador.Codigo),
                                             new XElement("Nombre", Juego.Ganador.Nombre),
                                             new XElement("Apellido", Juego.Ganador.Apellido),
                                             new XElement("eMail", Juego.Ganador.eMail),
                                             new XElement("FechaNacimiento", Juego.Ganador.FechaNacimiento.ToString("dd/MM/yyyy")),
                                             new XElement("Localidad", Juego.Ganador.Localidad),
                                             new XElement("Puntuacion", Juego.Ganador.Puntuacion.ToString()))));
                xmlDoc.Save("Datos Juegos.xml");
                return true;
            }
            catch (XmlException xml)
            {

                return false;
                throw xml;

            }
            catch (Exception ex)
            {
                return false;
                throw ex;
            }
        }

        public bool Instrucciones(BE_Ta_Te_Ti Juego)
        {
            throw new NotImplementedException();
        }

        public List<BE_Ta_Te_Ti> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
