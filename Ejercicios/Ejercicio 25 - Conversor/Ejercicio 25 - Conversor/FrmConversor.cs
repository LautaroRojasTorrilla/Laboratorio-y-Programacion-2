using Entidades;

namespace Ejercicio_25___Conversor
{
    public partial class FrmConversor : Form
    {
        public FrmConversor()
        {
            InitializeComponent();
        }

        private void btnBinToDec_Click(object sender, EventArgs e)
        {
            //de la textbox se toma el valor binario ingresado.
            //se convierte a decimal y se guarda en la otra textbox
            //retorna un numoer binario y hay que volver a usar la conversión explícita
            this.txtResultadoDec.Text = 
                ((NumeroDecimal)((NumeroBinario)this.txtBinario.Text)).Numero.ToString();
        }

        private void btnDecToBin_Click(object sender, EventArgs e)
        {
            //se genera var aux double y se convierte el ingreso de la textbox a ese tipo
            double ingresoAux;
            if (double.TryParse(this.txtDecimal.Text, out ingresoAux))
            {
                this.txtResultadoBin.Text = ((NumeroBinario)((NumeroDecimal)ingresoAux)).Numero;
            }
            else 
            {
                this.txtResultadoBin.Text = "Datos erroneos";
            }
        }
    }
}