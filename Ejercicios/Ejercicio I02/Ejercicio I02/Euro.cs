using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02
{
    public class Euro
    {
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotzRespectoDolar) : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotzRespectoDolar;
        }

        public double GetCantidad()
        {
            return this.cantidad;
        }

        public static double GetCotizacion()
        {
            return Euro.cotzRespectoDolar;
        }

        public static implicit operator Euro(double cantidad)
        {
            return new Euro(cantidad);
        }

        //desde un euro puedo obtener un dolar.
        //objeto de tipo euro que va a tener una cantidad de euros.
        //la deduzco en base a la cant de dolares / dividido la cot respescto al dolar
        public static explicit operator Dolar(Euro euro)
        {
            return new Dolar(euro.cantidad / Euro.cotzRespectoDolar);
        }

        //en dolar tenemos conversion explicita 
        public static explicit operator Peso(Euro euro)
        {
            return (Peso)((Dolar)euro);
        }

        public static bool operator ==(Euro euro1, Euro euro2)
        {
            return euro1.cantidad == euro2.cantidad;
        }

        public static bool operator !=(Euro euro1, Euro euro2)
        {
            return !(euro1 == euro2);
        }

        public static bool operator ==(Euro euro, Dolar dolar)
        {
            return euro.cantidad == ((Euro)dolar).cantidad;
        }

        public static bool operator !=(Euro euro, Dolar dolar)
        {
            return !(euro == dolar);
        }

        public static bool operator ==(Euro euro, Peso peso)
        {
            return euro.cantidad == ((Euro)peso).cantidad;
        }

        public static bool operator !=(Euro euro, Peso peso)
        {
            return !(euro == peso);
        }

        public static Euro operator -(Euro euro1, Dolar dolar)
        {
            return new Euro(euro1.GetCantidad() - ((Euro)dolar).GetCantidad());
        }

        public static Euro operator -(Euro euro1, Peso peso)
        {
            return new Euro(euro1.GetCantidad() - ((Euro)peso).GetCantidad());
        }

        public static Euro operator +(Euro euro1, Dolar dolar)
        {
            return new Euro(euro1.GetCantidad() + ((Euro)dolar).GetCantidad());
        }

        public static Euro operator +(Euro euro1, Peso peso)
        {
            return new Euro(euro1.GetCantidad() + ((Euro)peso).GetCantidad());
        }

    }
}
