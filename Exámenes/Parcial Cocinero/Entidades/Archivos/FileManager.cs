using Entidades.Exceptions;
using Entidades.Interfaces;
using Entidades.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
    public static class FileManager
    {
        private static string path;

        static FileManager() 
        {
            FileManager.path = $"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}+\\20230622_Torrilla\\";
            ValidaExistenciaDeDirectorio();
        }

        private static void ValidaExistenciaDeDirectorio()
        {
            if(!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(FileManager.path);
                }
                catch (Exception ex)
                {

                    throw new FileManagerException("Error al crear el directorio", ex);
                }
            }
        }

        //controlar con excepción.
        //se puede hacer en la útlima instancia donde vayamos a usar los métodos.
        public static void Guardar(string data, string nombreArchivo, bool append)
        {
            try
            {
                //se agrega el appen en true para agregar información al archivo
                //si es falso lo sobrescribe.
                using (StreamWriter writer = new StreamWriter(FileManager.path + nombreArchivo, append))
                {
                    writer.WriteLine(data);
                }
            }
            catch (Exception ex)
            {
                throw new FileManagerException("Error al guardar el archivo de texto", ex);
            }
        }

        public static bool Serializar<T>(T elemento, string nombreArchivo) where T : class
        {
            //typeof(T) porque depende del tipo que recibe
            try
            {
                //llamo al método guardar para no escribir de nuevo el using con el SW
                JsonSerializerOptions option = new JsonSerializerOptions();
                option.WriteIndented = true;
                FileManager.Guardar(JsonSerializer.Serialize(elemento, typeof(T), option), nombreArchivo, false);
                return true;
            }
            catch (Exception ex)
            {

                throw new FileManagerException("Error al serializar", ex);
            }
        }



    }
}
