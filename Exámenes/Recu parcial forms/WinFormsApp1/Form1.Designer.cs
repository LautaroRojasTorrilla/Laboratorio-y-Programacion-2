using Entidades;
namespace WinFormsApp1
{
    partial class Form1
    {
        Cliente cliente;
        Hamburguesa hamburguesa;
        Guarnicion guarnicion;
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtDniCliente = new TextBox();
            lblHamburguesa = new Label();
            lstHamburguesas = new ListBox();
            lblGuarnicion = new Label();
            cmbGuarnicion = new ComboBox();
            btnAgregarGuarnicion = new Button();
            grpIngredientes = new GroupBox();
            btnAgregarIngrediente = new Button();
            cmbIngredientes = new ComboBox();
            lblIngredientes = new Label();
            rdbGuarnicion = new RadioButton();
            rdbHamburguesa = new RadioButton();
            rchTicket = new RichTextBox();
            grpIngredientes.SuspendLayout();
            SuspendLayout();
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(12, 17);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.PlaceholderText = "Dni del cliente";
            txtDniCliente.Size = new Size(130, 23);
            txtDniCliente.TabIndex = 0;
            txtDniCliente.TextChanged += txtDniCliente_TextChanged;
            txtDniCliente.Leave += txtDniCliente_Leave;
            // 
            // lblHamburguesa
            // 
            lblHamburguesa.AutoSize = true;
            lblHamburguesa.Location = new Point(12, 47);
            lblHamburguesa.Name = "lblHamburguesa";
            lblHamburguesa.Size = new Size(157, 15);
            lblHamburguesa.TabIndex = 1;
            lblHamburguesa.Text = "Seleccione su hamburguesa:";
            // 
            // lstHamburguesas
            // 
            lstHamburguesas.FormattingEnabled = true;
            lstHamburguesas.ItemHeight = 15;
            lstHamburguesas.Location = new Point(12, 65);
            lstHamburguesas.Name = "lstHamburguesas";
            lstHamburguesas.Size = new Size(217, 79);
            lstHamburguesas.TabIndex = 2;
            lstHamburguesas.MouseDoubleClick += lstHamburguesas_MouseDoubleClick;
            // 
            // lblGuarnicion
            // 
            lblGuarnicion.AutoSize = true;
            lblGuarnicion.Location = new Point(12, 161);
            lblGuarnicion.Name = "lblGuarnicion";
            lblGuarnicion.Size = new Size(141, 15);
            lblGuarnicion.TabIndex = 3;
            lblGuarnicion.Text = "Seleccione su guarnición:";
            // 
            // cmbGuarnicion
            // 
            cmbGuarnicion.FormattingEnabled = true;
            cmbGuarnicion.Location = new Point(12, 179);
            cmbGuarnicion.Name = "cmbGuarnicion";
            cmbGuarnicion.Size = new Size(157, 23);
            cmbGuarnicion.TabIndex = 4;
            cmbGuarnicion.SelectedIndexChanged += cmbGuarnicion_SelectedIndexChanged;
            // 
            // btnAgregarGuarnicion
            // 
            btnAgregarGuarnicion.Location = new Point(175, 179);
            btnAgregarGuarnicion.Name = "btnAgregarGuarnicion";
            btnAgregarGuarnicion.Size = new Size(54, 23);
            btnAgregarGuarnicion.TabIndex = 5;
            btnAgregarGuarnicion.Text = "+";
            btnAgregarGuarnicion.UseVisualStyleBackColor = true;
            btnAgregarGuarnicion.Click += btnAgregarGuarnicion_Click;
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(btnAgregarIngrediente);
            grpIngredientes.Controls.Add(cmbIngredientes);
            grpIngredientes.Controls.Add(lblIngredientes);
            grpIngredientes.Controls.Add(rdbGuarnicion);
            grpIngredientes.Controls.Add(rdbHamburguesa);
            grpIngredientes.Location = new Point(253, 47);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(243, 165);
            grpIngredientes.TabIndex = 6;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Ingredientes";
            // 
            // btnAgregarIngrediente
            // 
            btnAgregarIngrediente.Location = new Point(177, 132);
            btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            btnAgregarIngrediente.Size = new Size(54, 23);
            btnAgregarIngrediente.TabIndex = 4;
            btnAgregarIngrediente.Text = "+";
            btnAgregarIngrediente.UseVisualStyleBackColor = true;
            btnAgregarIngrediente.Click += btnAgregarIngrediente_Click;
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(14, 132);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(157, 23);
            cmbIngredientes.TabIndex = 3;
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.Location = new Point(14, 114);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(75, 15);
            lblIngredientes.TabIndex = 2;
            lblIngredientes.Text = "Ingredientes:";
            // 
            // rdbGuarnicion
            // 
            rdbGuarnicion.AutoSize = true;
            rdbGuarnicion.Location = new Point(14, 48);
            rdbGuarnicion.Name = "rdbGuarnicion";
            rdbGuarnicion.Size = new Size(83, 19);
            rdbGuarnicion.TabIndex = 1;
            rdbGuarnicion.TabStop = true;
            rdbGuarnicion.Text = "Guarnición";
            rdbGuarnicion.UseVisualStyleBackColor = true;
            // 
            // rdbHamburguesa
            // 
            rdbHamburguesa.AutoSize = true;
            rdbHamburguesa.Location = new Point(14, 23);
            rdbHamburguesa.Name = "rdbHamburguesa";
            rdbHamburguesa.Size = new Size(100, 19);
            rdbHamburguesa.TabIndex = 0;
            rdbHamburguesa.TabStop = true;
            rdbHamburguesa.Text = "Hamburguesa";
            rdbHamburguesa.UseVisualStyleBackColor = true;
            // 
            // rchTicket
            // 
            rchTicket.Location = new Point(12, 218);
            rchTicket.Name = "rchTicket";
            rchTicket.Size = new Size(484, 162);
            rchTicket.TabIndex = 7;
            rchTicket.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 393);
            Controls.Add(rchTicket);
            Controls.Add(grpIngredientes);
            Controls.Add(btnAgregarGuarnicion);
            Controls.Add(cmbGuarnicion);
            Controls.Add(lblGuarnicion);
            Controls.Add(lstHamburguesas);
            Controls.Add(lblHamburguesa);
            Controls.Add(txtDniCliente);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDniCliente;
        private Label lblHamburguesa;
        private ListBox lstHamburguesas;
        private Label lblGuarnicion;
        private ComboBox cmbGuarnicion;
        private Button btnAgregarGuarnicion;
        private GroupBox grpIngredientes;
        private Button btnAgregarIngrediente;
        private ComboBox cmbIngredientes;
        private Label lblIngredientes;
        private RadioButton rdbGuarnicion;
        private RadioButton rdbHamburguesa;
        private RichTextBox rchTicket;
    }
}