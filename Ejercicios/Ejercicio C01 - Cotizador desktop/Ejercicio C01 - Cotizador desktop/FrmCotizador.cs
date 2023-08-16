using Entidades;

namespace Ejercicio_C01___Cotizador_desktop
{
    public partial class FrmCotizador : Form
    {
        private Euro e;
        private Dolar d;
        private Peso p;

        public FrmCotizador()
        {
            InitializeComponent();
        }

        private void BtnLock_Click(object sender, EventArgs e)
        {
            if (this.BtnLock.ImageIndex == 1)
            {
                this.BtnLock.ImageIndex = 0;
                CambiarEstado(false);
            }
            else
            {
                this.BtnLock.ImageIndex = 1;
                CambiarEstado(true);
            }
        }

        private void CambiarEstado(bool estado)
        {
            this.txtCotizacionD.Enabled = estado;
            this.txtCotizacionE.Enabled = estado;
            this.txtCotizacionP.Enabled = estado;
        }

        private void txtCotizacionE_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtCotizacionE.Text, out numero);
            Euro.SetCotizacion(numero);
        }

        private void txtCotizacionP_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtCotizacionP.Text, out numero);
            Peso.SetCotizacion(numero);
            //double numer = Peso.GetCotizacion();
        }

        //para validar que no se ingresen letras
        private void txtCotizacionE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txtEuro_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtEuro.Text, out numero);
            this.e = numero;
        }

        private void txtDolar_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtDolar.Text, out numero);
            this.d = numero;
        }

        private void txtPeso_Leave(object sender, EventArgs e)
        {
            double numero = 0;
            double.TryParse(this.txtPeso.Text, out numero);
            this.p = numero;
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            if (this.BtnLock.ImageIndex.Equals(1))
            {
                MessageBox.Show("Error! Debe bloquear las cotizaciones.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtEuro.Text.Equals(""))
            {
                MessageBox.Show("Error! Primero debe agragar la cantidad de Euros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.txtEuroAEuro.Text = $"{this.e.GetCantidad()}";
                this.txtEuroADolar.Text = $"{((Dolar)this.e).GetCantidad()}";
                this.txtEuroAPeso.Text = $"{((Peso)this.e).GetCantidad()}";
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            if (this.BtnLock.ImageIndex.Equals(1))
            {
                MessageBox.Show("Error! Debe bloquear las cotizaciones.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtEuro.Text.Equals(""))
            {
                MessageBox.Show("Error! Primero debe agragar la cantidad de Dólares.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.txtDolarAEuro.Text = $"{this.e.GetCantidad()}";
                this.txtDolarADolar.Text = $"{((Dolar)this.e).GetCantidad()}";
                this.txtDolarAPeso.Text = $"{((Peso)this.e).GetCantidad()}";
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            if (this.BtnLock.ImageIndex.Equals(1))
            {
                MessageBox.Show("Error! Debe bloquear las cotizaciones.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtEuro.Text.Equals(""))
            {
                MessageBox.Show("Error! Primero debe agragar la cantidad de Pesos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.txtPesosAEuro.Text = $"{this.e.GetCantidad()}";
                this.txtPesosADolar.Text = $"{((Dolar)this.e).GetCantidad()}";
                this.txtPesosAPeso.Text = $"{((Peso)this.e).GetCantidad()}";
            }
        }
    }
}