using Recu_primer_parcial;
using System.Drawing;
using System;
using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace View
{
    public partial class Form1 : Form
    {
        Cliente cliente;
        Hamburguesa hamburguesa;
        Guarnicion guarnicion;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.cmbGuarnicion.DataSource = Enum.GetValues(typeof(Guarnicion.ETipo));
            this.cmbIngredientes.DataSource = Enum.GetValues(typeof(Comida.EIngredientes));
            this.cmbGuarnicion.SelectedItem = Guarnicion.ETipo.PAPAS_FRITAS;
            this.lstHamburguesas.DataSource = new List<Hamburguesa>() { new Hamburguesa("Simple con queso"),
                new Hamburguesa("Doble con queso", true) };
        }

        private void TxtDni_TextChanged(object sender, EventArgs e)
        {
            int dni;
            int.TryParse(txtDniCliente.Text, out dni);
            cliente = dni;
        }

        private void btnAgregarIngrediente_Click(object sender, EventArgs e)
        {
            if (this.rdbGuarnicion.Checked && this.cliente == this.guarnicion)
            {
                this.guarnicion = (Guarnicion)cliente.BuscarComida(this.guarnicion);
                this.InformarPorPantalla(guarnicion + (Comida.EIngredientes)this.cmbIngredientes.SelectedItem);
            }
            else if (this.rdbHamburguesa.Checked && this.cliente == this.hamburguesa)
            {
                this.hamburguesa = (Hamburguesa)cliente.BuscarComida(this.hamburguesa);
                this.InformarPorPantalla(hamburguesa + (Comida.EIngredientes)this.cmbIngredientes.SelectedItem);
            }
            this.ActualizarTicket();
        }

        private void lstHamburguesas_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.hamburguesa = (Hamburguesa)this.lstHamburguesas.SelectedItem;
            this.cliente += this.hamburguesa;
            this.ActualizarTicket();
        }

        private void btnAgregarGuarnicion_Click(object sender, EventArgs e)
        {
            this.guarnicion = (Guarnicion)((Guarnicion.ETipo)this.cmbGuarnicion.SelectedItem);
            this.cliente += this.guarnicion;
            this.ActualizarTicket();
        }

        private void txtDniCliente_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.txtDniCliente.Text))
            {
                this.InformarPorPantalla("Debe completar los datos antes de seleccionar el menu");
                this.txtDniCliente.Focus();
            }
            else
            {
                this.ActualizarTicket();
            }
        }

        private void cmbGuarnicion_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.guarnicion = (Guarnicion)((Guarnicion.ETipo)this.cmbGuarnicion.SelectedItem);
        }

        private void InformarPorPantalla(string mensaje)
        {
            MessageBox.Show(mensaje, "Informacion",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void ActualizarTicket()
        {
            this.rchTicket.Text = Cliente.ImprimirTicket(this.cliente);
        }
    }
}