using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_Centro_Atencion
{
    public class Rac :Empleado
    {
        public enum EGrupo { CALL_IN, CALL_OUT, RRSS };
        private EGrupo grupo = EGrupo.CALL_IN;
        private static double valorHora;

        static Rac()
        {
            Rac.valorHora = 875.90F;
        }

        public Rac(string legajo, string nombre, TimeSpan horaIngreso) : base(legajo, nombre, horaIngreso)
        {

        }

        public Rac(string legajo, string nombre, TimeSpan horaIngreso, EGrupo grupo) :this(legajo, nombre, horaIngreso)
        {
            this.grupo = grupo;
        }

        public EGrupo Grupo { get => grupo; }
        public double ValorHora
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
            return $"Factura de: {base.Nombre}\nImporte a facturar:{this.Facturar().ToString()}";
        }

        protected double CalculaBonoDeGrupo()
        {
            switch (grupo)
            {
                case EGrupo.CALL_IN:
                    return 0;
                case EGrupo.CALL_OUT:
                    return 0.1;
                case EGrupo.RRSS:
                    return 0.2;
                default:
                    return 0;
            }
        }

        protected override double Facturar()
        {
            double totalHoras = base.Facturar();
            double bono = this.CalculaBonoDeGrupo();
            double importe = totalHoras * valorHora * (1 + bono);
            return importe;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {this.grupo} - {base.Legajo}- {base.Nombre}";
        }
    }
}
