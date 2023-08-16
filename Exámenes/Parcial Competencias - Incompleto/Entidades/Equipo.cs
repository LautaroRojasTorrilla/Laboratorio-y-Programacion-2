using System.Text;

namespace Entidades
{
    public abstract class Equipo
    {
        private string nombre;
        private int partidosEmpatados;
        private int partidosGanados;
        private int partidosJugados;
        private int partidosPerdidos;
        private int puntuacion;

        public string Nombre { get => nombre;}

        public string Tipo
        {
            get
            {
                return this.GetType().Name;
            }
        }

        protected int PE { get => partidosEmpatados; set => partidosEmpatados = value; }
        protected int PG { get => partidosGanados; set => partidosGanados = value; }
        protected int PJ{ get => partidosJugados; set => partidosJugados = value; }
        protected int PP { get => partidosPerdidos; set => partidosPerdidos = value; }
        protected int Puntuacion { get => puntuacion; set => puntuacion = value; }

        protected Equipo(string nombre)
        {
            this.nombre = nombre;
        }

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if (equipoA.Equals(equipoB))
            {
                equipoA.PJ++;
                equipoB.PJ++;

                if (equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.PG++;
                    equipoA.Puntuacion += 3;
                    equipoB.PP++;
                }
                else if (equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.PG++;
                    equipoB.Puntuacion += 3;
                    equipoA.PP++;
                }
                else
                {
                    equipoA.PE++;
                    equipoB.PE++;
                    equipoA.Puntuacion += 1;
                    equipoB.Puntuacion += 1;
                }
                return true;
            }
            return false;
        }

        public abstract int GetDificultad();

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.Nombre}");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Equipo && ((Equipo)obj) == this;
        }

        public override int GetHashCode()
        {
            return this.PJ.GetHashCode();
        }

        public static bool operator==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.Equals(equipoB) && equipoA.Nombre == equipoB.Nombre;
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }

    }
}