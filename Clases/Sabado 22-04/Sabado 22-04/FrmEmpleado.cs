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
    public partial class FrmEmpleado : Form
    {
        Empleado miEmpleado;

        public Empleado MiEmpleado
        {
            get
            {
                return miEmpleado;
            }
        }

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        public FrmEmpleado(Empleado empl)
        {
            InitializeComponent();
            TxtNombre.Text = empl.Nombre;
            TxtSueldo.Text = empl.Sueldo.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            miEmpleado = new Empleado(TxtNombre.Text, float.Parse(TxtSueldo.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void TxtNombre_Validating(object sender, CancelEventArgs e)
        {
            if (TxtNombre.Text.Length == 0)
            {
                errorProvider1.SetError(TxtNombre, "incompleto");
                //errorProvider1.Blinkstyle = ErrorBlinkStyle;
            }
        }

        private void TxtNombre_Validated(object sender, EventArgs e)
        {
            if (TxtNombre.Text.Length == 0)
            {
                errorProvider1.Clear();
            }
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            String path;

            if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(path);
            }
        }
    }
}
