using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Entidades.Archivos
{
    public class GestorDeArchivos : IGuardar<Carrera>, IGuardar<AutoF1>
    {
        private string archivo;


        public GestorDeArchivos(string ruta) { }
        public void Guardar(Carrera tipo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.archivo))
                {
                    sw.WriteLine($"Autos: {tipo.Autos}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar el archivo de texto.", ex);

            }
        }

        void IGuardar<AutoF1>.Guardar(AutoF1 tipo)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(this.archivo, true))
                {
                    sw.WriteLine($"Escuderia: {tipo.Escuderia}, Posición: {tipo.Posicion}");
                }
            }
            catch (Exception ex)
            {

                throw new Exception("Error al guardar el archivo de texto.", ex);
            }
        }

        public Carrera LeerXML()
        {
            try
            {
                if (Path.GetExtension(this.archivo) == ".xml")
                {

                    using (StreamReader sr = new StreamReader(archivo))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(Carrera));
                        Carrera carrera = (Carrera)serializer.Deserialize(sr);
                        //Carrera carrera2 = (Carrera)serializer.Deserialize(sr)
                        return carrera;
                    }
                }
                else
                {
                    throw new Exception("Extension Invalida para XML");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
