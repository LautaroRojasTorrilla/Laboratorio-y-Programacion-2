using Entidades;

namespace Ejercicio_17___Bolígrafo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string dibujo;
            Boligrafo boligrafo1 = new Boligrafo(ConsoleColor.Red, 10);
            ConsoleColor colorIncialDeConsola = Console.ForegroundColor;


            boligrafo1.Pintar(3, out dibujo);
            Console.ForegroundColor = boligrafo1.GetColor();

            Console.WriteLine(dibujo);

            Console.ForegroundColor = colorIncialDeConsola;
            Console.WriteLine($"cantidad de caracteres del primer retorno es {dibujo.Length}");


            boligrafo1.Pintar(100, out dibujo);
            Console.ForegroundColor = boligrafo1.GetColor();
            Console.WriteLine(dibujo);
            Console.ForegroundColor = colorIncialDeConsola;
            Console.WriteLine($"cantidad de caracteres del segundo retorno es {dibujo.Length}");

            Console.ForegroundColor = colorIncialDeConsola;
        }
    }
}