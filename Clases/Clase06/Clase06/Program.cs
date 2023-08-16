namespace Clase06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] edades = { 1, 2, 3, 4, 5, 6, 7 };

            Array.Resize(ref edades, 2);

            Console.WriteLine(edades[0]);

            Console.WriteLine("Hello, World!");
        }
    }
}