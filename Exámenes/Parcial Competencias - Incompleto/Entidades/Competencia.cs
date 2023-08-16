using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Competencia
    {
        private int cantidadCompetides;
        private List<Equipo> equipos;
        private string nombre;

        public int CantidadCompetides { get => cantidadCompetides; set => cantidadCompetides = value; }
        public List<Equipo> Equipos { get => equipos;}
        public string Nombre { get => nombre; set => nombre = value; }

        private Competencia(string nombre)
        {
            this.cantidadCompetides = 5;
        }
  
        public Competencia(string nombre, int cantidadCompetidores) : this(nombre)
        {
            equipos = new List<Equipo>();
            this.Nombre = nombre;
            this.CantidadCompetides = cantidadCompetidores;
        }

        public static implicit operator Competencia (string nombre)
        {
            return new Competencia(nombre);
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Competencia && ((Competencia)obj) == this;
        }


        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            foreach(Equipo e in torneo.Equipos)
            {
                if(e.Nombre == equipo.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }
        public override int GetHashCode()
        {
            return this.CantidadCompetides.GetHashCode();
        }

        public static Competencia operator+(Competencia torneo, Equipo equipo)
        {
            if (torneo != equipo && torneo.Equipos.Count() <= torneo.CantidadCompetides)
            {
                torneo.Equipos.Add(equipo);
            }
            return torneo;
        }

        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"La competencia es: {torneo.Nombre}");
            sb.AppendLine($"La cantidad de competiodres es: {torneo.CantidadCompetides}");

            foreach (Equipo e in torneo.Equipos)
            {
                sb.AppendLine($"{e.ToString()}");
            }

            return sb.ToString();
        }
    }
}
