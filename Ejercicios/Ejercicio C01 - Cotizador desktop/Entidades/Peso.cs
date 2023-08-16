using System.Drawing;

namespace Entidades
{
    public class Peso
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            Peso.cotzRespectoDolar = 400;
        }

        //constructar para dar un estado inicial con la cantidad de pesos
        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }

        //constructor para dar cantidad y poder cambiar la cotizacion respecto al dolar.
        //con this llamamos a la instancia y lo inicializamos en el constructor de arriba. 2.14
        public Peso(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Peso.cotzRespectoDolar;
        }

        public static void SetCotizacion(double cotzRespectoDolar)
        {
            Peso.cotzRespectoDolar = cotzRespectoDolar;
        }

        //permite contruir un objeto de tipo peso a través de un valor de tipo doble. 2.18
        public static implicit operator Peso(double cantidad)
        {
            return new Peso(cantidad);
        }

        //devuelvo un dolar con parametro como peso
        //la cant de dolares la contruyo respecto a la cant de pesos / la cotizacion
        public static explicit operator Dolar(Peso peso)
        {
            return new Dolar(peso.cantidad / Peso.cotzRespectoDolar);
        }

        //al peso lo convierto a dolar y despues a ese dolar lo convierto a euro.
        //porque tengo la explicita que desde peso tengo dolar
        //y en dolar tengo la conversion que desde dolar retorno euro
        public static explicit operator Euro(Peso peso)
        {
            //el casteo va entre () y luego quiero castear todo, por eso el resto tambine entre()
            return (Euro)peso;
        }

        public static bool operator ==(Peso peso1, Peso peso2)
        {
            //no tiene sentido poner un if
            return peso1.cantidad == peso2.cantidad;
        }

        public static bool operator !=(Peso peso1, Peso peso2)
        {
            //estoy utilizando la comparacion de arriba.
            return !(peso1 == peso2);
        }

        public static bool operator ==(Peso peso, Dolar dolar)
        {
            //puedo ponerle la cantidad porque devuelve una instancia.
            //Por ende puedo acceder a sus propiedades y metodos de instancia
            return peso.cantidad == ((Peso)dolar).cantidad;
        }

        public static bool operator !=(Peso peso, Dolar dolar)
        {
            return !(peso == dolar);
        }

        public static bool operator ==(Peso peso, Euro euro)
        {
            return peso.cantidad == ((Peso)euro).cantidad;
        }

        public static bool operator !=(Peso peso, Euro euro)
        {
            return !(peso == euro);
        }

        public static Peso operator -(Peso peso, Dolar dolar)
        {
            return new Peso(peso.GetCantidad() - ((Peso)dolar).GetCantidad());
        }

        public static Peso operator -(Peso peso, Euro euro)
        {
            return new Peso(peso.GetCantidad() - ((Peso)euro).GetCantidad());
        }

        public static Peso operator +(Peso peso, Dolar dolar)
        {
            return new Peso(peso.GetCantidad() + ((Peso)dolar).GetCantidad());
        }

        public static Peso operator +(Peso peso, Euro euro)
        {
            return new Peso(peso.GetCantidad() + ((Peso)euro).GetCantidad());
        }
    }
}