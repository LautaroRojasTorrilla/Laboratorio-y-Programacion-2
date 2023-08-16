namespace Entidades
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private List<int> numeros;

        public Persona() 
        { 
            this.numeros = new List<int>();
        }

        public Persona(string nombre, string apellido) :this()
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public List<int> Numeros { get => numeros; set => numeros = value; }

        public void AgregarNumero(int numero)
        {
            this.numeros.Add(numero);
        }
    }
}