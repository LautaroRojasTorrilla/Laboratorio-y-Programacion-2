using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Autobus : Vehiculo
    {
        private int numeroPlazas;

        public Autobus(int numeroPlazas)
        {
            this.numeroPlazas = numeroPlazas;
        }
    }
}
