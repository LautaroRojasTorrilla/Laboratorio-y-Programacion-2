using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class AutoF1
    {
        private string escuderia;
        private int posicion;
        private int puntoPartida;
        private int velocidad;

        public AutoF1()
        {

        }

        public AutoF1(string escuderia, int velocidad, int puntoPartida)
        {
            this.escuderia = escuderia;
            this.puntoPartida = puntoPartida;
            this.velocidad = velocidad;
        }

        public string Escuderia { get => this.escuderia; set => this.escuderia = value; }
        public int Posicion { get => this.posicion; set => this.posicion = value; }
        public int Velocidad { get => this.velocidad; set => this.velocidad = value; }
        public int UbicacionEnPista { get => puntoPartida; set => puntoPartida = value; }

        public void Acelerar()
        {
            this.puntoPartida += this.velocidad;
        }

        public override string ToString()
        {
            return $"Escuderia {this.Escuderia} - Posicion: {this.Posicion}";
        }

    }
}
