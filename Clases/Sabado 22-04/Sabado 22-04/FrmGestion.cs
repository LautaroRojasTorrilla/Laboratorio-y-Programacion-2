using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sabado_22_04
{
    public partial class FrmGestion : Form
    {
        List<Empleado> listaFormulario;
        public FrmGestion(List<Empleado> lista)
        {
            InitializeComponent();
            listaFormulario = lista;
        }

        private void FrmGestion_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void Mostrar()
        {
            listBox1.Items.Clear();
            foreach (Empleado emp in listaFormulario)
            {
                listBox1.Items.Add(emp.ToString());
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            int index;
            index = listBox1.SelectedIndex;
            if (index != -1)
            {
                //remuevo el elemento que esta en el indice especificado
                listaFormulario.RemoveAt(index);
                //refresco la lista
                Mostrar();
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            int index;
            Empleado modifica;
            index = listBox1.SelectedIndex;
            if (index != -1)
            {
                ////laburar como si fuese un vector
                //modifica = listaFormulario[index];

                //devuelve elemento especificado como un get de LL.
                modifica = listaFormulario.ElementAt(index);

                FrmEmpleado fmodifica = new FrmEmpleado(modifica);

                //lo muestro como forma de dialogo
                if (fmodifica.ShowDialog() == DialogResult.OK) 
                {
                    listaFormulario[index] = fmodifica.MiEmpleado;
                    Mostrar();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar algo.");
                }
            }
        }
    }
}
