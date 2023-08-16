using System;
using Entidades;

namespace Sabado_13_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int numero;
            //int otroNumero;
            //float division;

            //try 
            //{ 
            //    Console.WriteLine("Ingrese un numero: ");
            //    numero = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Ingrese otro numero: ");
            //    otroNumero = int.Parse(Console.ReadLine());

            //    division = numero / otroNumero;

            //    Console.WriteLine(division);
            //}
            //catch (FormatException ex) //afino porque sé que puede ser de formato la excepción.
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OverflowException ex) //se está desbordando la variable.
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (DivideByZeroException ex) 
            //{ 
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex)  // Generico que captures cualquier tipo de excepción.
            //{
            //    Console.WriteLine(ex.Message);
            //}


            //try 
            //{ 
            //    Metodo1();
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex) 
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally //se ejecuta sí o sí, se puede usar para liberar recursos.
            //{
            //    Console.WriteLine("Pase por el finally");
            //}

            List <object> objetos = new List<object> { 1, 2, 3, "Perro", 9 };
            List<int> listaInt = new List<int>();

        }

        //static void Metodo1()
        //{
        //    Metodo2();
        //}
        
        //static void Metodo2() 
        //{
        //    try
        //    {
        //        Metodo3();
        //    }
        //    catch (Exception ex) 
        //    {
        //        throw new Exception(ex.Message + " Algo paso en metodo2", ex);
        //    }
        //}
        //static void Metodo3() 
        //{
        //    try
        //    {
        //        Metodo4();
        //    }
        //    catch (Exception ex) 
        //    {
        //        // no me deja porque es solo lectura
        //        //ex.Message = "Ex en metodo 4";

        //        //la lanzo para arriba
        //        throw new Exception(ex.Message + " Algo paso en metodo3", ex);
        //    }
        //}
        //static void Metodo4() 
        //{
        //    int x;
        //    Console.WriteLine("Ingrese un numero: ");
        //    x = int.Parse(Console.ReadLine());
        //}

    }
}