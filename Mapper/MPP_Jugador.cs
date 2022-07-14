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
    public class MPP_Jugador : IValidable<BE_Jugador>, IGestionable<BE_Jugador>
    {
        public bool Baja(BE_Jugador Jugador)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load("Datos Usuarios.xml");
                var query = from jugador in xmlDoc.Descendants("Usuario")
                            where Convert.ToInt32(jugador.Attribute("ID").Value) == Jugador.Codigo
                            select jugador;

                query.Remove();
                xmlDoc.Save("Datos Usuarios.xml");
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

        public bool Existe(BE_Jugador Jugador)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load("Datos Usuarios.xml");
                var query = from jugador in xmlDoc.Descendants("Usuario")
                            where Convert.ToInt32(jugador.Element("DNI").Value) == Jugador.DNI
                            select jugador;
                if (query.Any())
                {
                    return true;
                }
                else
                {
                    return false;
                }
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

        public bool ExisteActivo(BE_Jugador Jugador)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(BE_Jugador Jugador)
        {
            try
            {
                XDocument xmlDoc;
                if (!File.Exists("Datos Usuarios.xml"))
                {
                    xmlDoc = new XDocument(
                         new XDeclaration("1.0", "UTF-8", "yes"),
                         new XComment("Registro de Usuarios."));
                    XElement nuevo = new XElement("Usuarios");
                    xmlDoc.Add(nuevo);
                    Jugador.Codigo = 1000;
                }
                else
                {
                    xmlDoc = XDocument.Load("Datos Usuarios.xml");
                    if (Jugador.Codigo == 0)
                    {
                        int max = Listar().LastOrDefault().Codigo;
                        Jugador.Codigo = max + 1;
                    }

                }
                
                xmlDoc.Element("Usuarios").Add(new XElement("Usuario",
                                             new XAttribute("ID", Jugador.Codigo.ToString()),
                                             new XElement("DNI", Jugador.DNI.ToString()),
                                             new XElement("Nombre", Jugador.Nombre),
                                             new XElement("Apellido", Jugador.Apellido),
                                             new XElement("eMail", Jugador.eMail),
                                             new XElement("FechaNacimiento", Jugador.FechaNacimiento.ToString("dd/MM/yyyy")),
                                             new XElement("Localidad", Jugador.Localidad),
                                             new XElement("Puntuacion", Jugador.Puntuacion.ToString())));
                xmlDoc.Save("Datos Usuarios.xml");
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

        public bool Modificar(BE_Jugador Jugador)
        {
            try
            {
                XDocument xmlDoc = XDocument.Load("Datos Usuarios.xml");
                var query = from jugador in xmlDoc.Descendants("Usuario")
                            where Convert.ToInt32(jugador.Attribute("ID").Value) == Jugador.Codigo
                            select jugador;

                foreach(XElement atrib in query)
                {
                    atrib.Element("DNI").Value = Jugador.DNI.ToString();
                    atrib.Element("Nombre").Value = Jugador.Nombre;
                    atrib.Element("Apellido").Value = Jugador.Apellido;
                    atrib.Element("eMail").Value = Jugador.eMail;
                    atrib.Element("FechaNacimiento").Value = Jugador.FechaNacimiento.ToString("dd/MM/yyyy");
                    atrib.Element("Localidad").Value = Jugador.Localidad;
                    atrib.Element("Puntuacion").Value = Jugador.Puntuacion.ToString();
                } 
                xmlDoc.Save("Datos Usuarios.xml");
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

        public List<BE_Jugador> Listar()
        {
            var consulta =
                from logueo in XElement.Load("Datos Usuarios.xml").Elements("Usuario")
                select new BE_Jugador
                {
                    Codigo = Convert.ToInt32(Convert.ToString(logueo.Attribute("ID").Value).Trim()),
                    DNI = Convert.ToInt32(Convert.ToString(logueo.Element("DNI").Value).Trim()),
                    Nombre = Convert.ToString(logueo.Element("Nombre").Value).Trim(),
                    Apellido = Convert.ToString(logueo.Element("Apellido").Value).Trim(),
                    eMail = Convert.ToString(logueo.Element("eMail").Value).Trim(),
                    FechaNacimiento = Convert.ToDateTime(Convert.ToString(logueo.Element("FechaNacimiento").Value).Trim()),
                    Localidad = Convert.ToString(logueo.Element("Localidad").Value).Trim(),
                    Puntuacion = Convert.ToInt32(Convert.ToString(logueo.Element("Puntuacion").Value).Trim()),
                };
            List<BE_Jugador> listadejugadores = consulta.ToList<BE_Jugador>();
            return listadejugadores;
        }

        public BE_Jugador ListarObjeto(BE_Jugador Jugador)
        {
            throw new NotImplementedException();
        }
    }
}
