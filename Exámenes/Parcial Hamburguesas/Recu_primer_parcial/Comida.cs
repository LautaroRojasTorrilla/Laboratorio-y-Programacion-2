using System.Text;

namespace Recu_primer_parcial
{
    

    public abstract class Comida
    {
        public enum EIngredientes
        {
            ADHERESO, QUESO = 10,
            CEBOLLA = 8, LECHUGA = 7, TOMATE = 9, JAMON = 12, HUEVO = 13, PANCETA = 15
        };
        protected List<EIngredientes> ingredientes;
        private string nombre;

        protected Comida(string nombre) : this(nombre, new List<EIngredientes>()) { }
        protected Comida(string nombre, List<EIngredientes> ingredientes)
        {
            this.nombre = nombre;
            this.ingredientes = ingredientes;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public double Costo
        {
            get { return CalcularCosto(); }
        }

        public string Descripcion
        {
            get { return MostrarDatos(); }
        }

        protected abstract string AgregarIngrediente(EIngredientes ingrediente);
        protected abstract double CalcularCosto();

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            foreach (var ingrediente in this.ingredientes)
            {
                sb.AppendLine(ingrediente.ToString());
            }
            sb.AppendLine($"Costo: {this.Costo}");

            return sb.ToString();
        }

        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Comida && ((Comida)obj).nombre == this.nombre;
        }

        public static bool operator ==(Comida c, EIngredientes ingrediente)
        {
            //return c.ingredientes.Contains(ingrediente);
            return c.ingredientes.Exists(e => e == ingrediente);
        }

        public static bool operator !=(Comida c, EIngredientes ingrediente)
        {
            return !(c == ingrediente);
        }

        public static string operator +(Comida c, EIngredientes ingrediente)
        {
            return c.AgregarIngrediente(ingrediente);
        }
    }
}