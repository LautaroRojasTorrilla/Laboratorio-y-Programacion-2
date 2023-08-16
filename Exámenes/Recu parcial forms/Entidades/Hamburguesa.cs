using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Hamburguesa : Comida
    {
        private static double costoBase;
        private bool esDoble;

        #region CONSTRUCTORES
        static Hamburguesa()
        {
            Hamburguesa.costoBase = 1500;
        }
        public Hamburguesa(string nombre) : base(nombre) { }
        public Hamburguesa(string nombre, bool esDoble) : this(nombre)
        {
            this.esDoble = esDoble;
        }
        #endregion

        #region MÉTODOS
        protected override string AgregarIngrediente(EIngredientes ingrediente)
        {
            if (this.ingredientes is not null && !this.ingredientes.Contains(ingrediente))
            {
                this.ingredientes.Add(ingrediente);
                return $"Se agregó {ingrediente} a su hamburguesa";
            }
            return $"No se pudo agregar {ingrediente} a su hamburguesa";
        }
        protected override double CalcularCosto()
        {
            double costoFinal = Hamburguesa.costoBase;
            if (this.ingredientes is not null)
            {
                if (this.esDoble)
                {
                    costoFinal += 500;
                }
                foreach (EIngredientes ingrediente in this.ingredientes)
                {
                    switch ((int)ingrediente)
                    {
                        case 0:
                            break;
                        case 10:
                            costoFinal = costoFinal + (costoFinal * 0.10);
                            break;
                        case 8:
                            costoFinal = costoFinal + (costoFinal * 0.08);
                            break;
                        case 7:
                            costoFinal = costoFinal + (costoFinal * 0.07);
                            break;
                        case 9:
                            costoFinal = costoFinal + (costoFinal * 0.09);
                            break;
                        case 12:
                            costoFinal = costoFinal + (costoFinal * 0.12);
                            break;
                        case 13:
                            costoFinal = costoFinal + (costoFinal * 0.13);
                            break;
                        case 15:
                            costoFinal = costoFinal + (costoFinal * 0.15);
                            break;
                        default:
                            break;
                    }
                }
                return costoFinal;
            }
            else
            {
                return 0;
            }
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
            if(this.esDoble)
            {
                return "Hamburguesa - Doble";
            }
            return "Hamburguesa - Simple";
        }
        #endregion
    }
}
