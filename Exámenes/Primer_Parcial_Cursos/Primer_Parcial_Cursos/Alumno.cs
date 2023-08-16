using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Cursos
{
    public class Alumno : Persona
    {
        private string legajo;
        //el diccionario tiene la particularidad de ser clave valor.
        //No puedo agregar más de una materia al mismo alumno.
        private Dictionary<EMateria, List<int>> materiasAsignadas;

        //Si el contructor tiene candadito, es porque es privado o de clase.
        private Alumno(int dni) : base(dni)
        {
            this.materiasAsignadas = new Dictionary<EMateria, List<int>>();
        }

        public Alumno(int dni, string legajo) : this(dni)
        {
            this.legajo = legajo;
        }

        public List<int> this[EMateria materia]
        {
            get
            {
                //chequea si la instancia era igual a la materia.
                if (this == materia)
                {
                    return this.materiasAsignadas[materia];
                }
                return null;
            }
        }

        public override string Informacion
        {
            get { return $"Alumno - {this.MostrarDatos()}"; }
        }

        public static bool operator ==(Alumno alumno, EMateria materia)
        {
            //evalúo si contiene la key.
            return alumno.materiasAsignadas.ContainsKey(materia);
        }

        public static bool operator !=(Alumno alumno, EMateria materia)
        {
            return !(alumno == materia);
        }

        public static implicit operator Alumno(string dni)
        {
            int dniAux;
            int.TryParse(dni, out dniAux);
            //generamos la isntancia y a la isntancia generada se le agrega el lagjo.
            Alumno alumno = new Alumno(dniAux);
            alumno.legajo = $"L-{alumno.GetHashCode()}";
            //se retorna la instancia generada
            return alumno;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Legajo: {this.legajo}");
            sb.AppendLine("Materias asignadas: ");
            //recorro las claves y las agrego.
            foreach (EMateria materia in this.materiasAsignadas.Keys)
            {
                sb.AppendLine(materia.ToString());
            }
            //puede estar arriba o abajo.
            //es importante traer los datos de la base.
            sb.AppendLine(base.MostrarDatos());

            return sb.ToString();

        }

        public static bool operator +(Alumno alumno, EMateria materia)
        {
            //si el alumno contiene la materia
            if(alumno == materia)
            {
                return false;
            }
            else
            {
                //se agrega, instanciando la colección.

                //alumno.materiasAsignadas[materia] = new List<int>();
                alumno.materiasAsignadas.Add(materia, new List<int>());
                return true;
            }
        }

        //no es static porque se usa la instancia
        public bool RendirExamen(EMateria materia)
        {
            if(this == materia)
            {
                Random random = new Random();
                //acá se está utilizando el indexador.
                this[materia].Add(random.Next(1, 10));
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return $"Alumno -{this.legajo}";
        }

    }
}
