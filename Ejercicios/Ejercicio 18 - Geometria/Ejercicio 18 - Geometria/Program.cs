using Geometria;

namespace Ejercicio_18___Geometria
{
    public class Program
    {
        static void Main(string[] args)
        {
            Punto point1 = new Punto(5, 2);
            Punto point2 = new Punto(1, 3);

            Rectangulo rec = new Rectangulo(point1, point2);

            rec.Mostrar();
        }
    }
}