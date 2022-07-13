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
        public bool Baja(BE_Jugador Objeto)
        {
            throw new NotImplementedException();
        }

        public bool Existe(BE_Jugador Jugador)
        {
            throw new NotImplementedException();
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
                    Jugador.Codigo = 1000;
                }
                else
                {
                    xmlDoc = XDocument.Load("Datos Usuarios.xml");
                    if (Jugador.Codigo == 0)
                    {
                        int max = 0;
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

        public List<BE_Jugador> Listar()
        {
            throw new NotImplementedException();
        }

        public BE_Jugador ListarObjeto(BE_Jugador Objeto)
        {
            throw new NotImplementedException();
        }
    }
}
