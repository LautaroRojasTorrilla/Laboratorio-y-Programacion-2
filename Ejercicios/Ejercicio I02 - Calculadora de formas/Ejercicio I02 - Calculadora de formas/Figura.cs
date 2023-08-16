namespace Ejercicio_I02___Calculadora_de_formas
{
    public abstract class Figura
    {

        protected double yAltura;
        protected double xBase;

        protected virtual string Dibujar()
        {
            return "Dibujando forma";
        }
    }
}