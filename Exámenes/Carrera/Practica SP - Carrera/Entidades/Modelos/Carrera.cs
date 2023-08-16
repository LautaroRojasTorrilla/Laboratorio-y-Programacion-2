using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public delegate void InformacionDeAvance();
    public delegate void InformacionDeLlegada(string mensaje);
    public class Carrera
    {
        private List<AutoF1> autos;
        private int kms;
        private Task tarea;
        public event InformacionDeAvance InformarAvance;
        public event InformacionDeLlegada InformarLlegada;

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
            int autosConPosicionAsignada = 0;

            try
            {
                while (autosConPosicionAsignada < this.Autos.Count)
                {
                    foreach (AutoF1 auto in this.Autos)
                    {
                        if (auto.Posicion == 0)
                        {
                            auto.Acelerar();
                            InformarAvance.Invoke();
                            Thread.Sleep(10);
                            if (auto.UbicacionEnPista > Kms)
                            {
                                auto.Posicion = auto.UbicacionEnPista;
                                InformarLlegada.Invoke(auto.ToString());
                                autosConPosicionAsignada++;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("No hay autos en carrera");
            }
        }

        public static Carrera operator +(Carrera carrera, AutoF1 auto)
        {
            return new Carrera();
        }
    }
}
