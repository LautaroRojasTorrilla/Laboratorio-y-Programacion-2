using Ejercicio_I02;

namespace Sobrecarga
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //construyo objeto tipo peso a través de un double.
            Peso peso = 400;

            Dolar dolar = (Dolar)peso;

            Console.WriteLine(dolar.GetCantidad());



        }
    }
}