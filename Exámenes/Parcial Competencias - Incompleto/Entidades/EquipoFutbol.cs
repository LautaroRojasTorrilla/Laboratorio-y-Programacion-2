using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;

        public EquipoFutbol(string nombre) :base(nombre)
        {
            this.jugadoresEstrellas = false;
        }

        public EquipoFutbol(string nombre, bool jugadresestrellas) : this(nombre)
        {
            this.jugadoresEstrellas = jugadresestrellas;
        }

        public override int GetDificultad()
        {
            int ran = new Random().Next(7, 10);
            
            if (this.jugadoresEstrellas == true)
            {
                return (ran*2);
            }

            return ran;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Futbol -");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
