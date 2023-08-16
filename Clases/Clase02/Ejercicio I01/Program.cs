using Entidades;
using System.Drawing;

namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];
            int flag = 0;
            int mininoNum = 0;
            int maximoNum = 0;
            int contadorIngresos = 0;
            int acumuladorIngresos = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Ingrese un número entre -100 y 100");
                int.TryParse(Console.ReadLine(), out numeros[i]);

                if (Validador.ValidarRango(numeros[i], -100, 100) == true) 
                {
                    Console.WriteLine("Se validó correctamente.\n");
                    contadorIngresos++;
                    acumuladorIngresos += acumuladorIngresos;
                }
                else
                {
                    Console.WriteLine("No pasó, la validación.\n");
                }

                if (flag == 0)
                {
                    mininoNum = numeros[i];
                    maximoNum = numeros[i];
                    flag = 1;
                }
                else
                {
                    if (numeros[i] < mininoNum)
                    {
                        mininoNum = numeros[i];
                    }
                    if (numeros[i] > maximoNum)
                    {
                        maximoNum = numeros[i];
                    }
                }
            }

            Console.WriteLine("Los números ingresados son:\n");

            for (int i = 0;i < numeros.Length; i++) 
            {
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine($"El mínimo es {mininoNum}.\n");
            Console.WriteLine($"El máximo es {maximoNum}.\n");
            Console.WriteLine($"El promedio es {acumuladorIngresos/contadorIngresos}.\n");

            Console.ReadLine();
        }
    }
}