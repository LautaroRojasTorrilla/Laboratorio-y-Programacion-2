using System.Security.Authentication.ExtendedProtection;
using System.Text;

namespace Primer_Parcial_Cursos
{
    public abstract class Persona
    {
        private string apellido;
        protected int dni;
        private string nombre;

        protected Persona(int dni)
        {
            this.dni = dni;
        }


        public string Apellido { get => apellido; set => apellido = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public abstract string Informacion { get; }

        public static bool operator ==(Persona personaA, Persona personaB)
        {
            return personaA.dni == personaB.dni;
        }

        public static bool operator !=(Persona personaA, Persona personaB)
        {
            return !(personaA == personaB);
        }

        //el ? indica que puede ser nulo
        public override bool Equals(object? obj)
        {
            return obj is not null && obj is Persona && ((Persona)obj) == this;
        }

        public override int GetHashCode()
        {
            return this.dni.GetHashCode(); 
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Apellido: {this.Apellido}");
            sb.AppendLine($"DNI: {this.dni}");

            return sb.ToString();
        }





    }
}