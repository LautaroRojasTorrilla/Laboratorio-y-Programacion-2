using Entidades;
/*
 Nombre de la mascota
Edad (Validar 1 - 12)
Tipo: (Validar “gato”, “perro”, “hamster”)
Peso: (Validar 0 - 50)
Diagnostico: (Validar  “otitis”, “alergias”, “parasitos”,)

Informes:

Nombre de la mascota más vieja
Cantidad de mascotas con parásitos
Nombre, edad y diagnóstico de la mascota más joven ingresada.
 */

namespace Ejercicio_clase02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombreMascota;
            int edadMascota;
            string tipoMascota;
            int pesoMascota;
            string diagnostico;

            Console.WriteLine("Ingrese el nombre de la mascota: ");
            nombreMascota = Console.ReadLine();

            Validador.ValidarNumero("Ingrese la edad de la mascota: ", out edadMascota, 1, 12);

            Validador.ValidaTexto("Ingrese el tipo de mascota (“gato”, “perro”, “hamster”)", out tipoMascota, "gato", "perro", "hamster");

            Validador.ValidarNumero("Ingrese peso de la mascota (0-50): ", out pesoMascota, 0, 50);


            Validador.ValidaTexto("Ingrese el diagnóstico de mascota (“otitis”, “alergias”, “parasitos”)", out diagnostico, "otitis", "alergias", "parasitos");

            Console.WriteLine(edadMascota);
            Console.WriteLine(pesoMascota);
            Console.WriteLine(tipoMascota);
            Console.WriteLine(diagnostico);

            Console.ReadKey();

        }
    }
}