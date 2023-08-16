namespace Entidades
{
    public class Conversor
    {
        public static string DecimalBinario(int numero)
        {
            if (numero == 1)
            {
                return "1";
            }
            else
            {
                return DecimalBinario(numero / 2) + (numero % 2).ToString();
            }
        }

        public static string DecimalBinario2(double numero)
        {
            string valorBinario = string.Empty;
            int resultDiv = (int)numero;
            int restoDiv;

            if (resultDiv >= 0)
            {
                do
                {
                    restoDiv = resultDiv % 2;
                    resultDiv /= 2;
                    valorBinario = restoDiv.ToString() + valorBinario;
                } while (resultDiv > 0);
            }
            return valorBinario;
        }


        public static double BinarioDecimal(string binario)
        {
            int len = binario.Length;
            double number = 0;

            for (int i = 0; i < binario.Length; i++)
            {
                len--;
                if (binario[i] == '1')
                {
                    number += Math.Pow(2, len);
                }
            }
            return number;
        }

        public static double BinarioDecimal2(string binario)
        {
            double resultado = 0;
            int cantidadCaracteres = binario.Length;

            foreach (char caracter in binario)
            {
                cantidadCaracteres--;
                if (caracter == '1')
                {
                    resultado += (int)Math.Pow(2, cantidadCaracteres);
                }
            }
            return resultado;
        }
    }
}