using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;
        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Dolar.cotzRespectoDolar;
        }

        public static implicit operator Dolar(double cantidad)
        {
            return new Dolar(cantidad);
        }

        //desde 1 dolar obtengo 1 objeto peso que tiene su cantidad de peso
        //lo hago desde dolar fijandome su cantidad y multiplicando por la cotizacion
        public static explicit operator Peso(Dolar dolar)
        {
            return new Peso(dolar.cantidad * Peso.GetCotizacion());
        }

        public static explicit operator Euro(Dolar dolar)
        {
            return new Euro(dolar.cantidad * Euro.GetCotizacion());

        }

        public static Dolar operator -(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.GetCantidad() - ((Dolar)euro).GetCantidad());
        }

        public static Dolar operator -(Dolar dolar, Peso peso)
        {
            return new Dolar(dolar.GetCantidad() - ((Dolar)peso).GetCantidad());
        }

        public static Dolar operator +(Dolar dolar, Euro euro)
        {
            return new Dolar(dolar.GetCantidad() + ((Dolar)euro).GetCantidad());
        }

        public static Dolar operator +(Dolar dolar, Peso peso)
        {
            return new Dolar(dolar.GetCantidad() + ((Dolar)peso).GetCantidad());
        }

        public static bool operator ==(Dolar dolar1, Dolar dolar2)
        {
            return dolar1.cantidad == dolar2.cantidad;
        }

        public static bool operator !=(Dolar dolar1, Dolar dolar2)
        {
            return !(dolar1 == dolar2);
        }

        public static bool operator ==(Dolar dolar, Euro euro)
        {
            return dolar.cantidad == ((Dolar)euro).cantidad;
        }

        public static bool operator !=(Dolar dolar, Euro euro)
        {
            return !(dolar == euro);
        }

        public static bool operator ==(Dolar dolar, Peso peso)
        {
            return dolar.cantidad == ((Dolar)peso).cantidad;
        }

        public static bool operator !=(Dolar dolar, Peso peso)
        {
            return !(dolar == peso);
        }
    }
}
