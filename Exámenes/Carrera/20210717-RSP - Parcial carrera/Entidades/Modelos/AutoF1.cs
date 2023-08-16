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
            this.posicion = 0;
        }

        public AutoF1(string escuderia, int posicion, int puntoPartida) : this()
        {
            this.escuderia = escuderia;
            this.posicion = posicion;
            this.puntoPartida = puntoPartida;
        }

        public string Escuderia { get => escuderia; set => escuderia = value; }
        public int Posicion { get => posicion; set => posicion = value; }
        public int UbicacionEnPista { get => puntoPartida; set => puntoPartida = value; }
        public int Velocidad { get => velocidad; set => velocidad = value; }

        public void Acelerar()
        {
            this.puntoPartida += this.velocidad; 
        }

        public override string ToString()
        {
            return $"Escuderia: {this.Escuderia} - Posicion: {this.Posicion}";
        }

    }
}
