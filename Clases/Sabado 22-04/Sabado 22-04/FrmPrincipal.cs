namespace Sabado_22_04
{
    public partial class FrmPrincipal : Form
    {
        List<Empleado> miLista;

        public FrmPrincipal()
        {
            InitializeComponent();
            miLista = new List<Empleado>();
            miLista.Add(new Empleado("Ale", 15000f));
            miLista.Add(new Empleado("Alan", 2000f));
            miLista.Add(new Empleado("Ger", 50000f));
            miLista.Add(new Empleado("Maria", 75000f));
            miLista.Add(new Empleado("Toto", 2500f));
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
        }

        private void cargarEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEmpleado fEmpleado = new FrmEmpleado();
            ////esto es para que esté contenido.
            //fEmpleado.MdiParent = this;

            ////muestro el formulario
            ////si le paso this arroja error. Era para ver propietario
            //fEmpleado.Show();

            ////se convierte en modal.
            ////Busca la atencion del usuario y lo pone en foco(exclusivo)
            ////el hilo del programa está detenido acá
            //DialogResult dialogo = fEmpleado.ShowDialog();

            ////es como para mostrar una alerta
            //MessageBox.Show(dialogo.ToString());

            if (fEmpleado.ShowDialog() == DialogResult.OK)
            {
                //agrego empleado a la lista
                miLista.Add(fEmpleado.MiEmpleado);
            }
        }

        private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestion gestion = new FrmGestion(miLista);
            gestion.MdiParent = this;
            gestion.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}