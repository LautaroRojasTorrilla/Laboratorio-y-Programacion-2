using Entidades;

namespace Ejercicio_16
{
    public class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Lautaro", "Rojas Torrilla", 1);
            Alumno alumno2 = new Alumno("Juan", "Habenchus", 2);
            Alumno alumno3 = new Alumno("Flavio IVan", "Sanchez", 3);

            alumno1.Estudiar(8, 9);
            alumno2.Estudiar(2, 5);
            alumno3.Estudiar(4, 5);

            alumno1.CalcularFinal();
            alumno2.CalcularFinal();
            alumno3.CalcularFinal();

            Console.WriteLine(alumno1.Mostrar());
            Console.WriteLine(alumno2.Mostrar());
            Console.WriteLine(alumno3.Mostrar());
        }
    }
}