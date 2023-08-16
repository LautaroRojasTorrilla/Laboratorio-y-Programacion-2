using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Extension
{
    //10.	Extenderá la clase Random la cual retornará un valor de Id aleatorio
    //desde 1 hasta el valor recibido por parámetro.
    //para poder EXTENDER UNA CLASE TIENE QUE SER STATIC Y TENER THIS EN EL PRIMER PARAMETRO.
    public static class RandomExtension
    {
        public static int GetRandomID(this Random value, int hasta)//al pasarle el this lo instancio por parametro
        {
            return value.Next(1, hasta);
        }
    }
}
