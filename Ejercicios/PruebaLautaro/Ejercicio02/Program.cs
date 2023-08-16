namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double resutladoCubo;
            double resutladoCuadrado;
            string valorIngresado;
            int numero;

            Console.WriteLine("Ingrese un numero mayor que cero: ");

            valorIngresado = Console.ReadLine();

            int.TryParse(valorIngresado, out numero);

            while (numero < 1) 
            {
                Console.WriteLine("Error. Reingresar numero!");
                Console.WriteLine("Ingrese un número mayor que 0: ");
                valorIngresado = Console.ReadLine();

                if(int.TryParse(valorIngresado, out numero))
                {
                    Console.WriteLine("Pude convertir.");
                }
                else
                {
                    Console.WriteLine("No pude convertir.");
                }
            }

            resutladoCuadrado = Math.Pow(numero, 2);
            Console.WriteLine($"El resutlado del cuadrado del numero {numero}, es {resutladoCuadrado}.");

            Console.ReadLine();
        }
    }
}