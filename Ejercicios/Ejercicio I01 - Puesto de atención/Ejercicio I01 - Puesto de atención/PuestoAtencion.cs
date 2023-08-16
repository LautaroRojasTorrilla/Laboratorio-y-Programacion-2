using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Puesto_de_atención
{
    public enum Epuesto {Caja1, Caja2};
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Epuesto puesto;

        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Epuesto puesto)
        {
            this.puesto = puesto;
        }

        public static int NumeroActual
        {
            get 
            { 
                return ++numeroActual; 
            }
        }

        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(10000);
                return true;
            }
            return false;
        }
    }
}
