namespace Ejercicio_I01___Puesto_de_atención
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        public Cliente(int numero)
        {
            this.numero = numero;
        }

        public Cliente(string nombre, int numero) :this(numero)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Numero { get => numero; }

        public static bool operator==(Cliente c1, Cliente c2)
        {
            return c1.Numero == c2.Numero;
        }

        public static bool operator!=(Cliente c1, Cliente c2)
        {
            return !(c1==c2);
        }

    }
}