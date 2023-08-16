using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
//4.FileManager será estática.
//  a.En el constructor de clase realizar: 
//      i.En el atributo path se almacenará la referencia al escritorio de la pc.
//      Y se le concatenara un el nombre de la carpeta del parcial: ej {path escritorio}
//          +\\20220621SP\\
//      ii.Llamar al método ValidaExistenciaDeDirectorio.
//  b.ValidaExistenciaDeDirectorio:
//      i.Si no existe el directorio almacenado en path, se creará.
//      ii.En caso de producirse una excepción al momento de la creación, esta deberá ser capturada
//      y relanzada en una nueva excepción denominada FileManagerException,
//      la cual contendrá el mensaje: “Error al crear el directorio”.
//  c.Guardar:
//      i.Será genérico y solo permitirá que los elementos a almacenar sean tipos por referencia.
//      ii.Validar la extensión del nombre del archivo. En caso de que sea:
//          1.JSON, se serializará el elemento recibido.
//          2.TXT, se almacena en texto plano.
//          3.Cualquier otra extensión se lanzará una excepción denominada FileManagerException,
//          la cual contendrá el mensaje “Extensión no permitida”.

    public static class FileManager
    {
        static string path;
        static FileManager()
        { 
            //es la referencia al escritorio y le concateno
            FileManager.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //con el arroba también lo puedo hacer y 1 sola barra
            FileManager.path += "\\Lautaro_Rojas_Torrila\\";
            ValidaExistenciaDeDirectorio();
        }

        public static void ValidaExistenciaDeDirectorio() 
        { 
            //se crea si no existe el directio almacanado.
            if(!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(FileManager.path);
                }
                catch (Exception ex)
                {
                    //capturada y relanzada en una excepcion que te da el nombre(hay que crearla)
                    throw new FileManagerException("Error al crear el directorio", ex);
                }
            }
        }

        
        public static void Guardar<T>(T elemento, string nombre) where T : class //indico que T tiene que ser por ref  
        {
            //le tengo que pasar la ruta dónde ir a buscarla y concatenarle el nombre del archivo.
            using (StreamWriter sw = new StreamWriter(FileManager.path + nombre))
            {
                //se puede hacer con switch
                if(Path.GetExtension(nombre) == ".json")
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    sw.WriteLine(JsonSerializer.Serialize<T>(elemento, opciones));
                }
                else if (Path.GetExtension(nombre) == ".txt")
                {
                    //se almacena en texto plano
                    sw.WriteLine(elemento);
                }
                else
                {
                    throw new FileManagerException("Extensión no permitida");
                }
            }
        }

    }
}
