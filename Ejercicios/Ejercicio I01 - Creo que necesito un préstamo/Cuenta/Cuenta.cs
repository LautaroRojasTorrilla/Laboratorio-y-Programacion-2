namespace Entidades
{
    public class Cuenta
    {
        public string titular;
        public float cantidad;


        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular { get => titular;}
        public float Cantidad { get => cantidad;}


        public string Mostrar(string titular, float cantidad)
        {
            return $"El titular es {this.titular} y la cantidad que tiene es: {this.cantidad}";
        }

        public void Ingresar(float cantidad)
        {
            if (cantidad > -1)
            {
                this.cantidad += cantidad;
            }
        }

        public void Retirar(float cantidad)
        {
            this.cantidad -= cantidad;
        }

    }
}