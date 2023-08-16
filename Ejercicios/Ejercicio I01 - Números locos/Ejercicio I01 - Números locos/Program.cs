using System;

namespace Ejercicio_I01___Números_locos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Crear una aplicación de consola que cargue 20 números enteros (positivos y negativos) 
            distintos de cero de forma aleatoria utilizando la clase Random.

                Mostrar el vector tal como fue ingresado.
                Luego mostrar los positivos ordenados en forma decreciente.
                Por último, mostrar los negativos ordenados en forma creciente.*/
            
            int[] arrayNumero = new int[20];
            Random random = new Random();

            for (int i = 0; i < arrayNumero.Length; i++)
            {
                arrayNumero[i] = random.Next(-101,101);
            }

            //for (int i = 0; i < numeros.Length; i++) 
            //{
            //    numeros[i] = random.Next(1, 101) * random.Next(2) == 0 ? -1 : 1; 
            //}

            Console.WriteLine("Recorro el array oiginal:");

            for (int i = 0;i < arrayNumero.Length; i++)
            {
                Console.WriteLine($"Posicion: {i} Valor: {arrayNumero[i]}");
            }

            Array.Sort(arrayNumero, Program.OrdenDesc);
            Console.WriteLine("Positivos ordenados de forma decreciente: ");

            for (int i = 0; i < arrayNumero.Length; i++)
            {
                if (arrayNumero[i] > 0)
                {
                    Console.WriteLine($"Posicion: {i} Valor: {arrayNumero[i]}");
                }
            }
            
            Array.Sort(arrayNumero);
            Console.WriteLine("Negativos ordenados de forma creciente: ");

            for (int i = 0; i < arrayNumero.Length; i++)
            {
                if (arrayNumero[i] < 0)
                {
                    Console.WriteLine($"Posicion: {i} Valor: {arrayNumero[i]}");
                }
            }


        }
            public static int OrdenDesc(int n1, int n2)
            {
                return n2 - n1;
            }
    }
}