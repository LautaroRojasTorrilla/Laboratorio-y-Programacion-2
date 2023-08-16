using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class NumeroBinario
    {
        private string numero;

        private NumeroBinario(string numero)
        {
            this.numero = numero;
        }

        public string Numero
        {
            get
            {
                return this.numero;
            }
        }

    
        public static explicit operator NumeroBinario(string numero)
        {
            return new NumeroBinario(numero);
        }

        public static explicit operator NumeroDecimal(NumeroBinario b)
        {
            return (NumeroDecimal)Conversor.BinarioDecimal2(b.Numero);
        }

        public static bool operator==(NumeroBinario b, NumeroDecimal d)
        {
            return b.Numero == ((NumeroBinario)d).Numero;
        }

        public static bool operator !=(NumeroBinario b, NumeroDecimal d)
        {
            return !(b==d);
        }

        public static string operator + (NumeroBinario b, NumeroDecimal d)
        {
            //metodo dec a binario para convertir la suma de los numeros en decimales
            return Conversor.DecimalBinario2(((NumeroDecimal)b).Numero + d.Numero);
        }

        public static string operator -(NumeroBinario b, NumeroDecimal d)
        {
            //metodo dec a binario para convertir la resta de los numeros en decimales
            return Conversor.DecimalBinario2(((NumeroDecimal)b).Numero - d.Numero);
        }
    }
}
