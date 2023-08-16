using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Centro_Atencion
{
    public class Supervisor :Empleado
    {
        private static float valorHora;

        static Supervisor()
        {
            Supervisor.valorHora = 1025.50F;
        }

        private Supervisor(string legajo) : base(legajo, "n/a", new TimeSpan(09, 00, 00))
        {
        }

        public static float ValorHora
        {
            get => valorHora;
            set
            {
                if (value > 0)
                {
                    valorHora = value;
                }
            }
        }

        public override string EmitirFactura()
        {
            return $"Factura de: {base.Nombre}" +
                $"\nImporte a facturar:{this.Facturar().ToString()}";
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {base.Legajo} - {base.Nombre}";
        }

        protected override double Facturar()
        {
            return base.Facturar() * Supervisor.valorHora;
        }

        public static implicit operator Supervisor(string legajo)
        {
            return new Supervisor(legajo);
        }
    }
}
