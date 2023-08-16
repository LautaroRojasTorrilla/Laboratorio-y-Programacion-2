using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    //una clase sellada hace que no pueda heredar de ella
    public class Taxi : Vehiculo
    {
        private string licencia;

        //no heredo el constructor.
        // base llama al consturctor y espera los parametros.
        public Taxi(string matricula, string modelo, double potencia) : base(matricula, modelo, potencia)
        {
            
        }

        public Taxi(string matricula, string modelo, double potencia, string licencia) : this(matricula, modelo, potencia)
        {
            this.Licencia = licencia;
        }

        public string Licencia { get => licencia; set => licencia = value; }
    }
}
