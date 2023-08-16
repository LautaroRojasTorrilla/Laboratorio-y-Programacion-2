using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recu_primer_parcial
{
    public class Guarnicion : Comida
    {
        public enum ETipo { PAPAS_FRITAS = 1000, ENSALADA_RUSA = 750, ENSALADA_MIXTA = 500 }
        private ETipo tipo;

        public Guarnicion() : this(ETipo.PAPAS_FRITAS) { }
        public Guarnicion(ETipo tipo) : base(tipo.ToString())
        {
            this.tipo = tipo;
        }

        protected override string AgregarIngrediente(EIngredientes ingrediente)
        {
            //casteo a comida, al ser this no tiene sentido castear a guarnicion.
            if ((Comida)this != ingrediente && this == ingrediente)
            {
                //en este caso siempre agregamos a la base
                base.ingredientes.Add(ingrediente);
                return $"Se agregó {ingrediente} a su guarnicion";
            }
            else
            {
                return $"No se pudo agregar {ingrediente} a su guarnicion";
            }
        }

        protected override double CalcularCosto()
        {
            //double costoFinal = (double)this.tipo;
            //foreach (EIngredientes ingrediente in this.ingredientes)
            //{
            //    if (this == ingrediente)
            //    {
            //        switch ((int)ingrediente)
            //        {
            //            case 0:
            //                break;
            //            case 10:
            //                costoFinal = costoFinal + (costoFinal * 0.10);
            //                break;
            //            case 15:
            //                costoFinal = costoFinal + (costoFinal * 0.15);
            //                break;
            //            default:
            //                break;
            //        }
            //    }
            //}
            //return costoFinal;

            double costo = (int)this.tipo;
            base.ingredientes.ForEach(ingrediente => costo += (costo * (int)ingrediente / 100));
            return costo;
        }

        public static bool operator ==(Guarnicion g, EIngredientes ingrediente)
        {
            return ingrediente == EIngredientes.PANCETA || ingrediente == EIngredientes.ADHERESO 
                || ingrediente == EIngredientes.QUESO;
        }

        public static bool operator !=(Guarnicion g, EIngredientes ingrediente)
        {
            return !(g == ingrediente);
        }

        public override string ToString()
        {
            return $"Guarnicion de tipo{ this.tipo}";
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ToString());
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();
        }

        public static explicit operator Guarnicion(ETipo tipo)
        {
            return new Guarnicion(tipo);
        }
    }
}
