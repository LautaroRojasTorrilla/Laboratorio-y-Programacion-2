using Entidades.Excepciones;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Xml;

namespace Entidades.Archivos
{
    public class GestorDeArchivos : IGuardar<Carrera>, IGuardar<AutoF1>
    {
        private string archivo;

        public GestorDeArchivos(string ruta)
        {
            this.archivo = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}+\\20230622_Torrilla\\";
        }

        public void Guardar(Carrera carrera)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.archivo, true))
                {
                    sw.WriteLine($"Llegada de vehículos a la meta - {DateTime.Now}:");
                    foreach (AutoF1 auto in carrera.Autos)
                    {
                        if (auto.Posicion > 0)
                        {
                            sw.WriteLine(auto.ToString());
                        }
                    }
                    sw.WriteLine();
                }
            }
            catch (ArchivoException ex)
            {
                throw new ArchivoException("Error al guardar el archivo texto", ex);
            }
        }

        void IGuardar<AutoF1>.Guardar(AutoF1 item)
        {
            try
            {
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    xmlTextWriter.Formatting = Formatting.Indented;
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(AutoF1));
                    xmlSerializer.Serialize(xmlTextWriter, item);
                }
            }
            catch (ArchivoException ex)
            {

                throw new ArchivoException("Error al guardar serializado", ex);
            }
        }

        public Carrera LeerXML()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Carrera));
                using (StreamReader reader = new StreamReader(archivo))
                {
                    Carrera carrera = (Carrera)serializer.Deserialize(reader);
                    return carrera;
                }
            }
            catch (Exception ex)
            {
                throw new ArchivoException("Error al leer el archivo XML: " + ex.Message);
            }
        }
    }
}
