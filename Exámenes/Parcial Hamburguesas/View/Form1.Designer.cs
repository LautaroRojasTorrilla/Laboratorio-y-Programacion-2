namespace View
{
    partial class Form1
    {
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
            btnAgregarGuarnicion = new Button();
            btnAgregarIngrediente = new Button();
            lstHamburguesas = new ListBox();
            lblHamburguesa = new Label();
            lblGuarnicion = new Label();
            lblIngredientes = new Label();
            cmbGuarnicion = new ComboBox();
            cmbIngredientes = new ComboBox();
            grpIngredientes = new GroupBox();
            rdbHamburguesa = new RadioButton();
            rdbGuarnicion = new RadioButton();
            rchTicket = new RichTextBox();
            grpIngredientes.SuspendLayout();
            SuspendLayout();
            // 
            // txtDniCliente
            // 
            txtDniCliente.Location = new Point(34, 41);
            txtDniCliente.Margin = new Padding(3, 4, 3, 4);
            txtDniCliente.Name = "txtDniCliente";
            txtDniCliente.PlaceholderText = "DNI del Cliente";
            txtDniCliente.Size = new Size(215, 27);
            txtDniCliente.TabIndex = 0;
            txtDniCliente.TextChanged += TxtDni_TextChanged;
            txtDniCliente.Leave += txtDniCliente_Leave;
            // 
            // btnAgregarGuarnicion
            // 
            btnAgregarGuarnicion.Location = new Point(251, 277);
            btnAgregarGuarnicion.Name = "btnAgregarGuarnicion";
            btnAgregarGuarnicion.Size = new Size(44, 36);
            btnAgregarGuarnicion.TabIndex = 1;
            btnAgregarGuarnicion.Text = "+";
            btnAgregarGuarnicion.UseVisualStyleBackColor = true;
            btnAgregarGuarnicion.Click += btnAgregarGuarnicion_Click;
            // 
            // btnAgregarIngrediente
            // 
            btnAgregarIngrediente.Location = new Point(329, 188);
            btnAgregarIngrediente.Name = "btnAgregarIngrediente";
            btnAgregarIngrediente.Size = new Size(44, 36);
            btnAgregarIngrediente.TabIndex = 2;
            btnAgregarIngrediente.Text = "+";
            btnAgregarIngrediente.UseVisualStyleBackColor = true;
            btnAgregarIngrediente.Click += btnAgregarIngrediente_Click;
            // 
            // lstHamburguesas
            // 
            lstHamburguesas.FormattingEnabled = true;
            lstHamburguesas.ItemHeight = 20;
            lstHamburguesas.Location = new Point(34, 112);
            lstHamburguesas.Name = "lstHamburguesas";
            lstHamburguesas.Size = new Size(215, 104);
            lstHamburguesas.TabIndex = 3;
            lstHamburguesas.MouseDoubleClick += lstHamburguesas_MouseDoubleClick;
            // 
            // lblHamburguesa
            // 
            lblHamburguesa.AutoSize = true;
            lblHamburguesa.Location = new Point(34, 89);
            lblHamburguesa.Name = "lblHamburguesa";
            lblHamburguesa.Size = new Size(198, 20);
            lblHamburguesa.TabIndex = 4;
            lblHamburguesa.Text = "Seleccione su Hamburguesa:";
            // 
            // lblGuarnicion
            // 
            lblGuarnicion.AutoSize = true;
            lblGuarnicion.Location = new Point(34, 258);
            lblGuarnicion.Name = "lblGuarnicion";
            lblGuarnicion.Size = new Size(176, 20);
            lblGuarnicion.TabIndex = 5;
            lblGuarnicion.Text = "Seleccione su Guarnicion:";
            // 
            // lblIngredientes
            // 
            lblIngredientes.AutoSize = true;
            lblIngredientes.Location = new Point(108, 169);
            lblIngredientes.Name = "lblIngredientes";
            lblIngredientes.Size = new Size(94, 20);
            lblIngredientes.TabIndex = 6;
            lblIngredientes.Text = "Ingredientes:";
            // 
            // cmbGuarnicion
            // 
            cmbGuarnicion.FormattingEnabled = true;
            cmbGuarnicion.Location = new Point(34, 282);
            cmbGuarnicion.Name = "cmbGuarnicion";
            cmbGuarnicion.Size = new Size(215, 28);
            cmbGuarnicion.TabIndex = 7;
            cmbGuarnicion.SelectedIndexChanged += cmbGuarnicion_SelectedIndexChanged;
            // 
            // cmbIngredientes
            // 
            cmbIngredientes.FormattingEnabled = true;
            cmbIngredientes.Location = new Point(108, 196);
            cmbIngredientes.Name = "cmbIngredientes";
            cmbIngredientes.Size = new Size(215, 28);
            cmbIngredientes.TabIndex = 8;
            // 
            // grpIngredientes
            // 
            grpIngredientes.Controls.Add(rdbHamburguesa);
            grpIngredientes.Controls.Add(rdbGuarnicion);
            grpIngredientes.Controls.Add(cmbIngredientes);
            grpIngredientes.Controls.Add(lblIngredientes);
            grpIngredientes.Controls.Add(btnAgregarIngrediente);
            grpIngredientes.Location = new Point(449, 89);
            grpIngredientes.Name = "grpIngredientes";
            grpIngredientes.Size = new Size(422, 242);
            grpIngredientes.TabIndex = 9;
            grpIngredientes.TabStop = false;
            grpIngredientes.Text = "Ingredientes";
            // 
            // rdbHamburguesa
            // 
            rdbHamburguesa.AutoSize = true;
            rdbHamburguesa.Location = new Point(29, 47);
            rdbHamburguesa.Name = "rdbHamburguesa";
            rdbHamburguesa.Size = new Size(123, 24);
            rdbHamburguesa.TabIndex = 10;
            rdbHamburguesa.TabStop = true;
            rdbHamburguesa.Text = "Hamburguesa";
            rdbHamburguesa.UseVisualStyleBackColor = true;
            // 
            // rdbGuarnicion
            // 
            rdbGuarnicion.AutoSize = true;
            rdbGuarnicion.Location = new Point(29, 103);
            rdbGuarnicion.Name = "rdbGuarnicion";
            rdbGuarnicion.Size = new Size(101, 24);
            rdbGuarnicion.TabIndex = 9;
            rdbGuarnicion.TabStop = true;
            rdbGuarnicion.Text = "Guarnicion";
            rdbGuarnicion.UseVisualStyleBackColor = true;
            // 
            // rchTicket
            // 
            rchTicket.Location = new Point(34, 347);
            rchTicket.Name = "rchTicket";
            rchTicket.Size = new Size(837, 241);
            rchTicket.TabIndex = 10;
            rchTicket.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(rchTicket);
            Controls.Add(grpIngredientes);
            Controls.Add(cmbGuarnicion);
            Controls.Add(lblGuarnicion);
            Controls.Add(lblHamburguesa);
            Controls.Add(lstHamburguesas);
            Controls.Add(btnAgregarGuarnicion);
            Controls.Add(txtDniCliente);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Hamburgueseria Torrilla 2C";
            Load += Form1_Load;
            grpIngredientes.ResumeLayout(false);
            grpIngredientes.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtDniCliente;
        private Button btnAgregarGuarnicion;
        private Button btnAgregarIngrediente;
        private ListBox lstHamburguesas;
        private Label lblHamburguesa;
        private Label lblGuarnicion;
        private Label lblIngredientes;
        private ComboBox cmbGuarnicion;
        private ComboBox cmbIngredientes;
        private GroupBox grpIngredientes;
        private RadioButton rdbHamburguesa;
        private RadioButton rdbGuarnicion;
        private RichTextBox rchTicket;
    }
}