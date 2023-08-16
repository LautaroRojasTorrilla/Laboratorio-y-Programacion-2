using Entidades.Exceptions;
using Entidades.Models;


namespace Ejercicio_I01___Lanzar_y_atrapar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //es donde arrojé la última excepción.
                OtraClase objeto1 = new OtraClase();
                objeto1.MetodoInstancia();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                while (ex.InnerException != null)
                {
                    //en la variable ex guardo la innerexception
                    ex = ex.InnerException;
                    // muestro el mensaje de la variable
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}