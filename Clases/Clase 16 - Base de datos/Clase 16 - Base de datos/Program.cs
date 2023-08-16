using Entidades;
using System.Configuration;

namespace Clase_16___Base_de_datos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //GestorDataBase.InsertEmpleado(new Empleado(100, "Lionel", "Messi", 1));

            //List<Empleado> listaEmpleados = GestorDataBase.GetEmpleados();

            //foreach(Empleado emp in listaEmpleados)
            //{
            //    Console.WriteLine(emp.Nombre);
            //    Console.WriteLine(emp.Apellido);
            //}
            ////Esto puede generar injection sql
            //Console.WriteLine(GestorDataBase.GetEmpleado(2).Apellido);

            Console.WriteLine(ConfigurationManager.AppSettings["saludo"]);

            Console.WriteLine(ConfigurationManager.ConnectionStrings["MyConnection"]);

            Console.WriteLine(Properties.Resources.cadenaDeConexiones);
        }
    }
}