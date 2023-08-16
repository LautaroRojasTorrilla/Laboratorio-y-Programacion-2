using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Guarnicion : Comida
    {
        public enum ETipo { PAPAS_FRITAS = 1000, ENSALADA_RUSA = 750, ENSALADA_MIXTA = 500 }
        private ETipo tipo;

        #region CONSTRUCTORES
        public Guarnicion() : base(ETipo.PAPAS_FRITAS.ToString())
        {

        }
        public Guarnicion(ETipo tipo) : base(tipo.ToString())
        {
            this.tipo = tipo;
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Intenta agregar el ingrediente pasado por parámetro.
        /// </summary>
        /// <param name="ingredientes">Ingrediente a agregar.</param>
        /// <returns>Devuelve una string indicando si se agregó o no el ingrediente.</returns>
        protected override string AgregarIngrediente(EIngredientes ingredientes)
        {
            if (this.ingredientes is not null && !this.ingredientes.Contains(ingredientes) && this == ingredientes)
            {
                this.ingredientes.Add(ingredientes);
                return $"Se agregó {ingredientes} a su guarnición";
            }
            return $"No se pudo agregar {ingredientes} a su guarnición";
        }
        protected override double CalcularCosto()
        {
            double costoFinal = (double)this.tipo;
            foreach (EIngredientes ingrediente in this.ingredientes)
            {
                if (this == ingrediente)
                {
                    switch ((int)ingrediente)
                    {
                        case 0:
                            break;
                        case 10:
                            costoFinal = costoFinal + (costoFinal * 0.10);
                            break;
                        case 15:
                            costoFinal = costoFinal + (costoFinal * 0.15);
                            break;
                        default:
                            break;
                    }
                }
            }
            return costoFinal;
        }
        protected override string MostrarDatos()
        {
            StringBuilder datos = new StringBuilder();
            datos.AppendLine(base.MostrarDatos());
            datos.AppendLine(this.ToString());
            return datos.ToString();
        }
        public override string ToString()
        {
            return $"Guarnición de tipo {this.tipo}";
        }
        public static explicit operator Guarnicion(ETipo tipo)
        {
            return new Guarnicion(tipo);
        }
        public static bool operator ==(Guarnicion g, EIngredientes ingrediente)
        {
            if (ingrediente == EIngredientes.PANCETA || ingrediente == EIngredientes.ADHERESO || ingrediente == EIngredientes.QUESO)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Guarnicion g, EIngredientes ingrediente)
        {
            return !(g == ingrediente);
        }
        #endregion

    }
}
