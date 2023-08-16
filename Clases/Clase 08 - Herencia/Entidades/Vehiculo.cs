namespace Entidades
{
    .
    public class Vehiculo
    {
        //funciona similar a private. Los atributos que sean protegidos puedo acceder desde las hijas.
        protected string matricula;
        protected string modelo;
        protected double potencia;

        public Vehiculo(string matricula, string modelo, double potencia)
        {
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Potencia = potencia;
        }

        public string Modelo { get => modelo; set => modelo = value; }
        public double Potencia { get => potencia; set => potencia = value; }
        protected string Matricula { get => matricula; set => matricula = value; }

        public string PonerEnMarcha()
        {
            return "Estoy funcionando";
        }
    }
}