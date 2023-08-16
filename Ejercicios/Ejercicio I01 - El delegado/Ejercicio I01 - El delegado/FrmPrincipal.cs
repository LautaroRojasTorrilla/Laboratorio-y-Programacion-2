namespace Ejercicio_I01___El_delegado
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegado;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        /*
         Se asignará una instancia de FrmMostrar a un atributo de la clase. 
         El MdiParent de dicha instancia será FrmPrincipal.
         Se asignará una instancia de FrmTestDelegados a un atributo de la clase. 
         El MdiParent de dicha instancia será FrmPrincipal. 
        */
        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;

            this.frmTestDelegado = new FrmTestDelegados(this.frmMostrar.ActualizarNombre);
            frmTestDelegado.MdiParent = this;
        }

        private void testDelegadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //se muestra de manera no modal.
            this.frmTestDelegado.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}