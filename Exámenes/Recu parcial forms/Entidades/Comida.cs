using System.Text;

namespace Entidades
{
    public abstract class Comida
    {
        public enum EIngredientes { ADHERESO, QUESO=10, CEBOLLA=8, LECHUGA=7, TOMATE=9, JAMON=12, HUEVO, PANCETA=15}
        protected List<EIngredientes> ingredientes;
        private string nombre;

        #region CONSTRUCTORES
        protected Comida(string nombre)
        {
            this.nombre = nombre;
        }
        protected Comida(string nombre, List<EIngredientes> ingredientes) : this(nombre)
        {
            this.ingredientes = ingredientes;
        }
        #endregion

        #region PROPIEDADES
        public double Costo
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        public string Descripcion
        {
            get
            {
                return this.MostrarDatos();
            }
        }
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        #endregion

        #region MÉTODOS
        protected abstract string AgregarIngrediente(EIngredientes ingredientes);
        protected abstract double CalcularCosto();
        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Comida && (Comida)obj == this;
        }
        protected virtual string MostrarDatos()
        {
            if(this.ingredientes is not null)
            {
                StringBuilder datos = new StringBuilder();
                datos.AppendLine($"Nombre: {this.nombre}\nCosto: {this.Costo}\nIngredientes:");
                foreach (EIngredientes ingrediente in this.ingredientes)
                {
                    datos.AppendLine(ingrediente.ToString());
                }
                return datos.ToString();
            }
            return "";
        }

        #region SOBRECARGAS
        public static bool operator ==(Comida c, EIngredientes ingrediente)
        {
            return c.ingredientes.Contains(ingrediente);
        }
        public static bool operator !=(Comida c, EIngredientes ingrediente)
        {
            return !(c == ingrediente);
        }
        public static string operator +(Comida c, EIngredientes ingrediente)
        {
            return c.AgregarIngrediente(ingrediente);
        }
        #endregion
        #endregion

    }
}