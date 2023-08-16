using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_Parcial_Cursos
{
    public class Curso
    {
        private List<Persona> alumnos;
        private EMateria materia;
        private Persona profesor;

        public Curso(Profesor profesor)
        {
            this.materia = profesor.Materia;
            this.profesor = profesor;
            this.alumnos = new List<Persona>();
        }

        public List<Persona> Alumnos { get => alumnos; }

        //puedo castear para retornar lo que quería.
        //la propiedad es de tipo profesor.
        //castear para poder acceder a los métodos.
        public Profesor Profesor { get => (Profesor)this.profesor; set => this.profesor = value; }

        public string InscribirAlumno(Alumno alumno)
        {
            //que la instancia sea distinto al alumno(que no pertenezca al curso)
            //a la vez con la sobrecarga se verifica (que retornaba un bool e instanciaba la collecion)
            if(this != alumno && alumno + this.materia)
            {
                this.Alumnos.Add(alumno);
                return $"Se inscribio al alumno a la materia{this.materia}\n{alumno.Informacion}";
            }
            return $"Ya inscripto o no se pudo inscribir el alumno a la materia {this.materia}";
        }

        public static bool operator ==(Curso curso, Alumno alumno)
        {
            //se puede usar contains porque usa le equals(tiene que estar sobreescrito) y compara por referencia.
            //Nosotros sobreescribimos el eqauls, diciendo que una persona es igual a otra si el dni es =
            return curso.alumnos.Contains(alumno);
        }

        public static bool operator !=(Curso curso, Alumno alumno)
        {
            return !(curso==alumno);
        }

        public static void EvaluarAlumnos(Curso curso)
        {
            foreach (var item in curso.alumnos)
            {
                //los 2 son válidos.

                //((Alumno)item).RendirExamen(curso.materia);
                ((Profesor)curso.profesor).Evaluar((Alumno)item);
            }
        }

        public static string MostrarInformacionDelCurso(Curso curso)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Curso de: {curso.materia}");
            sb.AppendLine($"Profesor: {curso.profesor.Informacion}");
            sb.AppendLine("*****Listado de Alumnos*****");
            foreach (var item in curso.alumnos)
            {
                sb.AppendLine(item.Informacion);
            }


            return sb.ToString();


        }

    }
}
