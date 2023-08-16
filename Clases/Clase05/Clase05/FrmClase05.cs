namespace Clase05
{
    public partial class FrmClase05 : Form
    {
        public FrmClase05()
        {
            InitializeComponent();

            this.btnAceptar.Text = "El boton ahora cambio el nombre";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.txtNombre.Text, "Caja de Texto", MessageBoxButtons.OK, MessageBoxIcon.Question);
            SegundoForm frmSegundo = new SegundoForm();
            frmSegundo.ShowDialog();
        }

        private void FrmClase05_Load(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Hola Mundo", "Titulo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (resultado == DialogResult.OK)
            {
                MessageBox.Show("La operación es ok.");
            }

        }

        private void FrmClase05_FormClosing(object sender, FormClosingEventArgs e) //la e es del evento
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea cerrar la ventana?", "Cierre", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}