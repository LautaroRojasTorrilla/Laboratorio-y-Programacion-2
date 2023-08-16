using Entidades;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta1 = new Cuenta("Alberto", 110.5F);
            Cuenta cuenta2 = new Cuenta("Lautaro", 330F);
            Cuenta cuenta3 = new Cuenta("Mirta", -100.5F);

            Console.WriteLine(cuenta1.Mostrar(cuenta1.titular, cuenta1.cantidad));
            cuenta1.Ingresar(500);
            Console.WriteLine(cuenta1.Mostrar(cuenta1.titular, cuenta1.cantidad));
            cuenta1.Retirar(2000);
            Console.WriteLine(cuenta1.Mostrar(cuenta1.titular, cuenta1.cantidad));

        }
    }
}