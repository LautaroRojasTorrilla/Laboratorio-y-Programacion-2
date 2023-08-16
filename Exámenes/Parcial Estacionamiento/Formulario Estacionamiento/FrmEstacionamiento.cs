using Entidades;
using System.Windows.Forms;

namespace Formulario_Estacionamiento
{
    public partial class FrmEstacionamiento : Form
    {
        private Estacionamiento estacionamiento;
        public FrmEstacionamiento()
        {
            InitializeComponent();
        }

        private void FrmEstacionamiento_Load(object sender, EventArgs e)
        {
            this.cmbTipoVehiculo.DataSource = Enum.GetValues(typeof(EVehiculos));
            this.cmbTipoMoto.DataSource = Enum.GetValues(typeof(ETipo));
            this.estacionamiento = Estacionamiento.GetEstacionamiento("Lautaro Rojas Torrilla",
            20);
            this.txtNombreEstacionamiento.Text = this.estacionamiento.Nombre;
        }

        private void cmbTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((EVehiculos)this.cmbTipoVehiculo.SelectedItem == EVehiculos.Automovil)
            {
                this.cmbTipoMoto.Visible = false;
                lblTipo.Text = "Marca:";
                this.txtMarca.Location = this.cmbTipoMoto.Location;
                this.txtMarca.Visible = true;
            }
            else
            {
                this.cmbTipoMoto.Visible = true;
                lblTipo.Text = "Tipo Moto:";
                this.txtMarca.Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Vehiculo vehiculo;
            if ((EVehiculos)this.cmbTipoVehiculo.SelectedItem == EVehiculos.Automovil)
            {
                vehiculo = new Automovil(this.txtPatente.Text, DateTime.Now, this.txtMarca.Text);
            }
            else
            {
                vehiculo = new
                Moto(this.txtPatente.Text, DateTime.Now, (ETipo)this.cmbTipoMoto.SelectedItem)
                ;
            }
            if (this.estacionamiento + vehiculo)
            {
                this.lstVehiculos.Items.Add(vehiculo);
                MessageBox.Show(vehiculo.ToString(), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void lstVehiculos_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (this.estacionamiento - (Vehiculo)this.lstVehiculos.SelectedItem)
            {
                MessageBox.Show(this.estacionamiento.InformarSalida((Vehiculo)this.lstVehiculos.SelectedItem), "Ingreso al Estacionamiento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.lstVehiculos.Items.Remove((Vehiculo)this.lstVehiculos.SelectedItem);
            }
        }

        private void FrmEstacionamiento_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult resultado = MessageBox.Show("Desea salir del programa?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    MessageBox.Show("AGUANTE BOQUITA!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void txtPatente_TextChanged(object sender, EventArgs e)
        {
            if (txtPatente.Text.Length < 5 || txtPatente.Text.Length > 8)
            {
                errorProvider1.SetError(txtPatente, "La patente debe tener entre 6 o 7 caracteres");
                errorProvider1.BlinkStyle = ErrorBlinkStyle.BlinkIfDifferentError;
            }
            else
            {
                errorProvider1.Clear(); // limpio el errorProvider
            }
        }
    }
}