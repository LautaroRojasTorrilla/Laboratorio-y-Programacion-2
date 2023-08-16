﻿using Entidades;

namespace Ejercicio_22___Conversor
{
    public class Program
    {
        static void Main(string[] args)
        {
            NumeroBinario numeroBinario = (NumeroBinario)"1001";
            NumeroDecimal numeroDecimal = (NumeroDecimal)9;

            Console.WriteLine($"El numero binario es {numeroBinario.Numero}, sumado con el decimal da un total de {numeroDecimal + numeroBinario}");
            
            Console.WriteLine($"El numero decimal es {numeroDecimal.Numero}, sumado con el binario da un total de {(numeroBinario + numeroDecimal)}");

            Console.ReadKey();
        }
    }
}