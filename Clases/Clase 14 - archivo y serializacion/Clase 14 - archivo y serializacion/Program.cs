using Entidades;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Xml.Serialization;

namespace Clase_14___archivo_y_serializacion
{
    public class Program
    {
        static void Main(string[] args)
        {
            //es un enum con diferentes directorios especiales
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            char separador = Path.DirectorySeparatorChar;
            string carpeta = @"Progra y labo 2\Clase 14 - archivo y serializacion";
            string nombreArchivo = "miXML.xml";

            //ruta = $"{ruta}{separador}{carpeta}{separador}{nombreArchivo}";

            string rutaCompleta = Path.Join(ruta, carpeta, nombreArchivo);

            Console.WriteLine(ruta);

            //// el @ es para que no me tome la contrabarra como caracter especial
            ////File.Create(@"C:\\Users\\Lautaro\\Desktop\\Progra y labo 2\\Clase 14 - archivo y serializacion\\miArchivo.txt");

            //Persona persona = new Persona("Lautaro", "Rojas");

            ////conviene hacer con try cath todo esto de archivos y directorios.
            ////entre parentesis llamo al streamwriter.
            ////con using se cierra de manera automática el archivo.
            //using (StreamWriter sw = new StreamWriter(ruta))
            //{
            //    sw.WriteLine("Hola a todos");
            //}

            ////el bool en true indica que le voy a appendear algo más.
            //using (StreamWriter sw = new StreamWriter(ruta, true))
            //{
            //    sw.WriteLine("cómo están?");
            //}

            //using(StreamReader sr = new StreamReader(ruta))
            //{
            //    string lectura = sr.ReadToEnd();
            //    Console.WriteLine(lectura);
            //}


            //serializar en XML
            Persona persona = new Persona("Lautaro", "Rojas");
            persona.AgregarNumero(1);
            persona.AgregarNumero(2);
            persona.AgregarNumero(3);

            using(StreamWriter sw = new StreamWriter(rutaCompleta)) 
            {
                //con un typeof le indico qué es lo que voy a serializar.
                //almacena el estado de un objeto y usa las propiedades públicas.
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                xml.Serialize(sw, persona);
            }

            //leer una persona en xml. Deserializar 
            using(StreamReader sr = new StreamReader(rutaCompleta)) 
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));
                Persona persona2 = (Persona)xml.Deserialize(sr);

                Console.WriteLine(persona2.Nombre);
                Console.WriteLine(persona2.Apellido);
            }

            //serializar en JSON
            nombreArchivo = "MiJSON.json";
            rutaCompleta = Path.Join(ruta, carpeta, nombreArchivo);
            using (StreamWriter sw = new StreamWriter(rutaCompleta))
            {
                //para que se escriba una propiedad debajo de la otra.
                //se lo tengo que pasar a Serialize
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                //no es instanciable, es una clase estática
                string json = JsonSerializer.Serialize<Persona>(persona, opciones);
                Console.WriteLine(json);
                sw.WriteLine(json);
            }

            //deserializar en JSON.
            using (StreamReader sr = new StreamReader(rutaCompleta))
            {
                //esto sirve porque tengo 1 solo dato. Debería usar el ReadLine()
                //si tenog una lista de personas uso el ReadToEnd y hago la conversión.
                string json = sr.ReadToEnd();
                //el as persona no sería necesario
                Persona persona3 = JsonSerializer.Deserialize<Persona>(json) as Persona;

                Console.WriteLine(persona3.Nombre);
                Console.WriteLine(persona3.Apellido);
            }
        }
    }
}