using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroDecimal
    {
        private double numero;

        private NumeroDecimal(double numero)
        {
            this.numero = numero;
        }

        public double Numero
        {
            get
            {
                return this.numero;
            }
        }

        public static explicit operator NumeroDecimal(double numero)
        {
            return new NumeroDecimal(numero);
        }

        public static explicit operator NumeroBinario(NumeroDecimal d)
        {
            return (NumeroBinario)Conversor.DecimalBinario2(d.Numero);
        }

        public static bool operator==(NumeroDecimal d, NumeroBinario b)
        {
            return d.Numero == ((NumeroDecimal)b).Numero;
        }

        public static bool operator !=(NumeroDecimal d, NumeroBinario b)
        {
            return !(d==b);
        }

        public static double operator +(NumeroDecimal d, NumeroBinario b)
        {
            return d.Numero + ((NumeroDecimal)b).Numero;
        }

        public static double operator -(NumeroDecimal d, NumeroBinario b)
        {
            return d.Numero - ((NumeroDecimal)b).Numero;
        }
    }
}
