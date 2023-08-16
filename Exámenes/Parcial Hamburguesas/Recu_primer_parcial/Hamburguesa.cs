using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recu_primer_parcial
{
    public class Hamburguesa : Comida
    {
        private static double costoBase;
        private bool esDoble;

        static Hamburguesa() { Hamburguesa.costoBase = 1500; }

        public Hamburguesa(string nombre) :base(nombre) { }

        public Hamburguesa(string nombre, bool esDoble) : this(nombre)
        {
            this.esDoble = esDoble;
        }

        protected override string AgregarIngrediente(EIngredientes ingrediente)
        {
            if(!(this == ingrediente))
            {
                //lo tengoq que hacer en la base
                base.ingredientes.Add(ingrediente);
                return $"Se agrego {ingrediente} a su hamburguesa";
            }
            else
            {
                return $"No se pudo agregar {ingrediente} a su hamburguesa";
            }
        }

        protected override double CalcularCosto()
        {
            //double costoTotal = costoBase;

            //if (esDoble)
            //{
            //    costoTotal += 500;
            //}

            //Dictionary<EIngredientes, double> porcentajesIncremento = new Dictionary<EIngredientes, double>()
            //{
            //    { EIngredientes.ADHERESO, 0 },
            //    { EIngredientes.LECHUGA, 0.07 },
            //    { EIngredientes.CEBOLLA, 0.08 },
            //    { EIngredientes.TOMATE, 0.09 },
            //    { EIngredientes.QUESO, 0.1 },
            //    { EIngredientes.JAMON, 0.12 },
            //    { EIngredientes.HUEVO, 0.13 },
            //    { EIngredientes.PANCETA, 0.15 }
            //};

            //foreach (var ingrediente in ingredientes)
            //{
            //    if (porcentajesIncremento.TryGetValue(ingrediente, out double porcentaje))
            //    {
            //        costoTotal += costoBase * porcentaje;
            //    }
            //}

            //return costoTotal;

            double costo = this.esDoble ? Hamburguesa.costoBase + 500 : Hamburguesa.costoBase;
            base.ingredientes.ForEach(ingrediente => costo += (costo * (int)ingrediente / 100));
            return costo;
        }

        public override string ToString()
        {
            if (this.esDoble)
            {
                return "Hamburguesa - Doble";
            }
            return "Hamburguesa - Simple";

            //el return de ale
            //return $"Hamburguesa {(this.esDoble ? "Doble" : "Simple")}";
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(ToString());
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();

            //como lo hizo ale, sin stringbuilder
            //return $"{this.ToString()}\n{base.MostrarDatos()}";
        }


    }
}
