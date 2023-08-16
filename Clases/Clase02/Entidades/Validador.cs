namespace Entidades
{
    public class Validador
    {
        /// <summary>
        /// Función que valida un número entre un rango específico
        /// </summary>
        /// <param name="mensaje"> mensaje a imprimir por pantalla</param>
        /// <param name="valor">es el valor a retornar</param>
        /// <param name="min">es el minimo</param>
        /// <param name="max">es el maximo</param>
        public static void ValidarNumero(string mensaje, out int valor, int min, int max)
        //se pasa valor por referencia, porque sino tiene que tener un valor dentro de la fn.
        //no hay que acoplar lógica de la vista con la lógica.
        //Pedir información a través de la consola e imprimirla en la consola no debería pasar nunca.
        {
            Console.WriteLine(mensaje);
            int.TryParse(Console.ReadLine(), out valor);

            while (valor < min || valor > max)
            {
                Console.WriteLine($"Error valor inválido, ingrese un valor entre {min}--{max}");
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out valor);
            }
        }

        public static void ValidaTexto(string mensaje, out string valor, params string[] valores)//si o si se pasa un array
        {
            Console.WriteLine(mensaje);
            valor = Console.ReadLine();

            while (!valores.Contains(valor))//Si valores no contiene el valor que se ingreso, se vuelve a pedir
            {
                Console.WriteLine("Error, valor inválido. Ingrese válido: ");
                valor = Console.ReadLine();
            }
        }

        public static bool ValidarRango(int valor, int min, int max)
        {
            bool returnAux = false;

            if(valor >= min && valor <= max)
            {
                returnAux = true;
            }

            return returnAux;
        }
    }
}