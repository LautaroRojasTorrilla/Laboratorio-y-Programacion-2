using Primer_Parcial_Cursos;

namespace View
{
    public partial class Form1 : Form
    {

        private Persona alumno;
        private Persona profesorProgra;
        private Curso cursoProgramacion;
        private Persona profesorLabo;
        private Curso cursoLaboratorio;

        public Form1()
        {
            InitializeComponent();
            profesorLabo = new Profesor(99000123, "profesorLabo@email.com", EMateria.Laboratorio);
            profesorProgra = new Profesor(99000123, "profesorProgra@email.com", EMateria.Programacion);
            cursoProgramacion = new Curso((Profesor)profesorProgra);
            cursoLaboratorio = new Curso((Profesor)profesorLabo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbMaterias.DataSource = Enum.GetValues(typeof(EMateria));
        }

        private void btnCreaAlumno_Click(object sender, EventArgs e)
        {
            alumno = (Alumno)this.txtDni.Text;
            alumno.Nombre = this.txtNombre.Text;
            alumno.Apellido = this.txtApellido.Text;
            this.lstAlumnosCreados.Items.Add(alumno);
        }

        private void ActualizarInscriptos()
        {
            this.lstAlumnosInscriptosLaboratorio.DataSource = null;
            this.lstAlumnosInscriptosProgramacion.DataSource = null;
            this.lstAlumnosInscriptosLaboratorio.DataSource =
            this.cursoLaboratorio.Alumnos;
            this.lstAlumnosInscriptosProgramacion.DataSource = this.cursoProgramacion.Alumnos;
        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            EMateria materia = (EMateria)this.cmbMaterias.SelectedItem;
            string mensaje = string.Empty;
            if (materia == EMateria.Programacion)
            {
                mensaje = cursoProgramacion.InscribirAlumno((Alumno)alumno);
            }
            else
            {
                mensaje = cursoLaboratorio.InscribirAlumno((Alumno)alumno);
            }
            this.lstAlumnosCreados.Items.Remove(alumno);
            MessageBox.Show(mensaje, "Incripcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.ActualizarInscriptos();
        }
    }
}