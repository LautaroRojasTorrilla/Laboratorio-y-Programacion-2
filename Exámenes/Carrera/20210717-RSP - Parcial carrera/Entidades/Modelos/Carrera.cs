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
        private CancellationTokenSource cancellation;
        private Task tarea;

        public event InformacionDeAvance InformarAvance;
        public event InformacionDeLlegada InformarLlegada;

        public Carrera()
        {
        }

        public Carrera(int kms)
        {
            this.kms = kms;
        }

        public List<AutoF1> Autos { get => autos; set => autos = value; }
        public int Kms { get => kms; set => kms = value; }

        public void IniciarCarrera()
        {
            CancellationToken token = this.cancellation.Token;
            int autosConPosicionAsignada = 0;

            this.tarea = Task.Run( () =>
            {
                while(autosConPosicionAsignada < this.Autos.Count)
                {
                    foreach (AutoF1 auto in autos)
                    {
                        auto.Acelerar();
                        InformarAvance.Invoke();
                        Thread.Sleep(10);

                        if (auto.UbicacionEnPista > kms && auto.Posicion == 0)
                        {
                            auto.Posicion = auto.UbicacionEnPista;
                            InformarLlegada.Invoke(auto.ToString());
                            autosConPosicionAsignada++;
                        }
                    }
                }



            }, token);
        }

        public static Carrera operator +(Carrera carrera, AutoF1 autoF1)
        {
            return new Carrera(carrera.Kms + autoF1.UbicacionEnPista);
        }
    }
}
