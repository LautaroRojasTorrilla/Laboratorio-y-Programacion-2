using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Carrera
    {
        private List<AutoF1> autos;
        private int kms;

        public Carrera() 
        { 
            autos = new List<AutoF1>();
        }

        public Carrera(int kms) : this()
        {
            this.kms = kms;
        }

        public List<AutoF1> Autos { get => autos; set => autos = value; }
        public int Kms { get => kms; set => kms = value; }

        public void IniciarCarrera()
        {

        }

        public static Carrera operator +(Carrera carrera, AutoF1 auto)
        {
            return new Carrera();
        }
    }
}
