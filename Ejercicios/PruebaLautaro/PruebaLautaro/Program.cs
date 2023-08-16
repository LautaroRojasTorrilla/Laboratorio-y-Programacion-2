namespace PruebaLautaro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            string numero1;

            Console.WriteLine("Ingrese un número: ");
            numero1 = Console.ReadLine();

            Console.WriteLine("El usuario ingreso {0}.", numero1);

            Console.ReadKey();
            */

            Console.Title = "Prueba de Lautaro";
            string numero1;
            int resultado;
            int numeroConvertido;
            bool resultadoConversion;

            Console.WriteLine("Ingrese un número: ");
            numero1 = Console.ReadLine();
            //si le pongo el ? en la asignación se va

            resultadoConversion = int.TryParse(numero1, out numeroConvertido);
            //va a intentar convertirlo. Si puede devuelve True, sino False
            //1er parametro el valor que queres convertir, 2do la variable en donde almaceno
            //se le pone out para pasarle la referencia

            if(resultadoConversion)
            {
                Console.WriteLine("Pude convertir.");
            }
            else
            {
                Console.WriteLine("No pude convertir.");
                //el valor que me queda va a ser 0
            }

            resultado = numeroConvertido + 10;

            Console.WriteLine("La suma del número ingresado más 10 es: {0}.", resultado);
            Console.ReadKey();
        }
    }
}