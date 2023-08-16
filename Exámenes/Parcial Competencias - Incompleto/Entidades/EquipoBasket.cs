using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ELiga {NBA, Euroleague, ACB};
    public class EquipoBasket :Equipo
    {
        private ELiga liga;

        public EquipoBasket(string nombre) :base(nombre) 
        {
            this.liga = ELiga.NBA;
        }

        public EquipoBasket(string nombre, ELiga liga) :this(nombre)
        {
            this.liga = liga;
        }

        public override int GetDificultad()
        {
            Random ran = new Random();

            if (this.liga == ELiga.NBA)
            {
                return ran.Next(0, 8);
            }
            else if (this.liga == ELiga.Euroleague)
            {
                return ran.Next(5, 10);
            }
            else
            {
                return ran.Next(1,7);
            }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine("Basket -");

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
