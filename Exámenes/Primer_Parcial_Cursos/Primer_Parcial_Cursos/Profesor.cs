using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Cursos
{
    public class Profesor : Persona
    {
        private string email;
        private EMateria materiaAsignada;

        public Profesor(int dni) : base(dni) { }

        public Profesor(int dni, string email) : this(dni)
        {
            this.email = email;
        }

        public Profesor (int dni, string email, EMateria materiaAsignada) :this(dni, email)
        {
            this.materiaAsignada = materiaAsignada;
        }

        public EMateria Materia { get => this.materiaAsignada; set => this.materiaAsignada = value; }

        public override string Informacion
        {
            get { return $"Profesor - {this.MostrarDatos()}"; }
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Email: {this.email}");
            sb.AppendLine($"Materia: {this.materiaAsignada}");
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();

        }

        public override string ToString()
        {
            return $"Profesor -{this.materiaAsignada}";
        }

        public bool Evaluar(Alumno alumno)
        {
            //llama al método y se le asigna la materia.
            return alumno.RendirExamen(this.materiaAsignada);
        }
    }
}
