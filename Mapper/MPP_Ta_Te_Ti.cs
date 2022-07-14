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
                int Cantidad = 0;
                
                XDocument xmlDoc;
                if (!File.Exists("Datos Juegos.xml"))
                {
                    Cantidad = 1;
                    xmlDoc = new XDocument(
                         new XDeclaration("1.0", "UTF-8", "yes"),
                         new XComment("Registro de Juegos Jugados."));
                    XElement nuevo = new XElement("Registro");
                    xmlDoc.Add(nuevo);
                    xmlDoc.Element("Registro").Add(new XElement("Juego",
                                                               new XAttribute("ID", Juego.Codigo.ToString()),
                                                               new XElement("Nombre", Juego.ToString()),
                                                               new XElement("Cantidad", Cantidad.ToString())));
                }
                else
                {
                    Cantidad = Listar().Find(x => x.Codigo == Juego.Codigo).Cantidad;
                    Cantidad += 1;
                    xmlDoc = XDocument.Load("Datos Juegos.xml");
                    var query = from jugador in xmlDoc.Descendants("Juego")
                                where Convert.ToInt32(jugador.Attribute("ID").Value) == Juego.Codigo
                                select jugador;
                    foreach (XElement atrib in query)
                    {
                        atrib.Element("Cantidad").Value = Cantidad.ToString() ;
                    }
                }
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
        public bool GuardarEstadistica(BE_Ta_Te_Ti Juego, BE_Juego.Resultado resultado)
        {
            XDocument xmlDoc1 = XDocument.Load("Estadisticas TaTeTi.xml");
            var consulta = from juego in xmlDoc1.Descendants("Juegos")
                           where juego.Element("Jugador").Value == Juego.Ganador.ToString()
                           select juego;
            foreach (XElement atrib in consulta)
            {
                if (resultado == BE_Juego.Resultado.Victoria)
                {
                    atrib.Element("Victorias").Value += 1;
                }
                if (resultado == BE_Juego.Resultado.Empate)
                {
                    atrib.Element("Empates").Value += 1;
                }
                else
                {
                    atrib.Element("Derrotas").Value += 1;
                }

            }
            xmlDoc1.Save("Estadisticas TaTeTi.xml");
            return true;
        }
        public List<BE_Ta_Te_Ti> Listar()
        {
            var consulta =
                from logueo in XElement.Load("Datos Juegos.xml").Elements("Juego")
                select new BE_Ta_Te_Ti
                {
                    Codigo = Convert.ToInt32(Convert.ToString(logueo.Attribute("ID").Value).Trim()),
                    Nombre = Convert.ToString(logueo.Element("Nombre").Value).Trim(),
                    Cantidad = Convert.ToInt32(Convert.ToString(logueo.Element("Cantidad").Value.Trim()))
                };
            List<BE_Ta_Te_Ti> listadejuegos = consulta.ToList<BE_Ta_Te_Ti>();
            return listadejuegos;
        }
    }
}
