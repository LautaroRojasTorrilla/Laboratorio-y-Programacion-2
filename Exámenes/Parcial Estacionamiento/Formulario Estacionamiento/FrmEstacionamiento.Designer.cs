namespace Formulario_Estacionamiento
{
    partial class FrmEstacionamiento
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
            components = new System.ComponentModel.Container();
            lblTipoVehiculo = new Label();
            lblPatente = new Label();
            lblTipo = new Label();
            btnAgregar = new Button();
            cmbTipoVehiculo = new ComboBox();
            cmbTipoMoto = new ComboBox();
            txtPatente = new TextBox();
            lstVehiculos = new ListBox();
            txtMarca = new TextBox();
            txtNombreEstacionamiento = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.AutoSize = true;
            lblTipoVehiculo.Location = new Point(42, 47);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(78, 15);
            lblTipoVehiculo.TabIndex = 0;
            lblTipoVehiculo.Text = "Tipo Vehiculo";
            // 
            // lblPatente
            // 
            lblPatente.AutoSize = true;
            lblPatente.Location = new Point(42, 89);
            lblPatente.Name = "lblPatente";
            lblPatente.Size = new Size(47, 15);
            lblPatente.TabIndex = 1;
            lblPatente.Text = "Patente";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(42, 128);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(62, 15);
            lblTipo.TabIndex = 2;
            lblTipo.Text = "Tipo Moto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(42, 304);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(137, 89);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar Vechiculo";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Location = new Point(126, 44);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 4;
            cmbTipoVehiculo.SelectedIndexChanged += cmbTipoVehiculo_SelectedIndexChanged;
            // 
            // cmbTipoMoto
            // 
            cmbTipoMoto.FormattingEnabled = true;
            cmbTipoMoto.Location = new Point(126, 125);
            cmbTipoMoto.Name = "cmbTipoMoto";
            cmbTipoMoto.Size = new Size(121, 23);
            cmbTipoMoto.TabIndex = 5;
            // 
            // txtPatente
            // 
            txtPatente.Location = new Point(126, 86);
            txtPatente.Name = "txtPatente";
            txtPatente.Size = new Size(121, 23);
            txtPatente.TabIndex = 6;
            txtPatente.TextChanged += txtPatente_TextChanged;
            // 
            // lstVehiculos
            // 
            lstVehiculos.FormattingEnabled = true;
            lstVehiculos.ItemHeight = 15;
            lstVehiculos.Location = new Point(400, 89);
            lstVehiculos.Name = "lstVehiculos";
            lstVehiculos.Size = new Size(365, 304);
            lstVehiculos.TabIndex = 7;
            lstVehiculos.MouseDoubleClick += lstVehiculos_MouseDoubleClick;
            // 
            // txtMarca
            // 
            txtMarca.Location = new Point(264, 125);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(121, 23);
            txtMarca.TabIndex = 8;
            // 
            // txtNombreEstacionamiento
            // 
            txtNombreEstacionamiento.Location = new Point(400, 25);
            txtNombreEstacionamiento.Name = "txtNombreEstacionamiento";
            txtNombreEstacionamiento.Size = new Size(365, 23);
            txtNombreEstacionamiento.TabIndex = 9;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FrmEstacionamiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNombreEstacionamiento);
            Controls.Add(txtMarca);
            Controls.Add(lstVehiculos);
            Controls.Add(txtPatente);
            Controls.Add(cmbTipoMoto);
            Controls.Add(cmbTipoVehiculo);
            Controls.Add(btnAgregar);
            Controls.Add(lblTipo);
            Controls.Add(lblPatente);
            Controls.Add(lblTipoVehiculo);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmEstacionamiento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estacionamiento Lautaro Rojas Torrilla";
            FormClosing += FrmEstacionamiento_FormClosing;
            Load += FrmEstacionamiento_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTipoVehiculo;
        private Label lblPatente;
        private Label lblTipo;
        private Button btnAgregar;
        private ComboBox cmbTipoVehiculo;
        private ComboBox cmbTipoMoto;
        private TextBox txtPatente;
        private ListBox lstVehiculos;
        private TextBox txtMarca;
        private TextBox txtNombreEstacionamiento;
        private ErrorProvider errorProvider1;
    }
}