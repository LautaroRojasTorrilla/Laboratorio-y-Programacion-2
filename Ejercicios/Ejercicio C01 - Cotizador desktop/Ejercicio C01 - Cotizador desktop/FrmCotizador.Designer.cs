namespace Ejercicio_C01___Cotizador_desktop
{
    partial class FrmCotizador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCotizador));
            BtnLock = new Button();
            ImlLock = new ImageList(components);
            txtEuro = new TextBox();
            txtDolar = new TextBox();
            txtPeso = new TextBox();
            txtCotizacionP = new TextBox();
            txtCotizacionD = new TextBox();
            txtCotizacionE = new TextBox();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            txtDolarAEuro = new TextBox();
            txtEuroAEuro = new TextBox();
            txtPesosAEuro = new TextBox();
            txtPesosADolar = new TextBox();
            txtEuroADolar = new TextBox();
            txtDolarADolar = new TextBox();
            txtPesosAPeso = new TextBox();
            txtEuroAPeso = new TextBox();
            txtDolarAPeso = new TextBox();
            lblEuro = new Label();
            lblDolar = new Label();
            lblPeso = new Label();
            lblEuro2 = new Label();
            lblDolar2 = new Label();
            lblPeso2 = new Label();
            lblCotizacion = new Label();
            SuspendLayout();
            // 
            // BtnLock
            // 
            BtnLock.FlatAppearance.BorderColor = Color.Silver;
            BtnLock.FlatStyle = FlatStyle.Popup;
            BtnLock.ImageIndex = 1;
            BtnLock.ImageList = ImlLock;
            BtnLock.Location = new Point(180, 17);
            BtnLock.Name = "BtnLock";
            BtnLock.Size = new Size(75, 54);
            BtnLock.TabIndex = 0;
            BtnLock.UseVisualStyleBackColor = true;
            BtnLock.Click += BtnLock_Click;
            // 
            // ImlLock
            // 
            ImlLock.ColorDepth = ColorDepth.Depth32Bit;
            ImlLock.ImageStream = (ImageListStreamer)resources.GetObject("ImlLock.ImageStream");
            ImlLock.TransparentColor = Color.Transparent;
            ImlLock.Images.SetKeyName(0, "internet_lock_locked_padlock_password_secure_security_icon_127078.png");
            ImlLock.Images.SetKeyName(1, "internet_locked_padlock_password_secure_security_unlock_icon_127083.png");
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(74, 110);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(100, 23);
            txtEuro.TabIndex = 1;
            txtEuro.Leave += txtEuro_Leave;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(74, 139);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(100, 23);
            txtDolar.TabIndex = 2;
            txtDolar.Leave += txtDolar_Leave;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(74, 168);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(100, 23);
            txtPeso.TabIndex = 3;
            txtPeso.Leave += txtPeso_Leave;
            // 
            // txtCotizacionP
            // 
            txtCotizacionP.Location = new Point(477, 34);
            txtCotizacionP.Name = "txtCotizacionP";
            txtCotizacionP.Size = new Size(100, 23);
            txtCotizacionP.TabIndex = 4;
            txtCotizacionP.Leave += txtCotizacionP_Leave;
            // 
            // txtCotizacionD
            // 
            txtCotizacionD.Location = new Point(371, 34);
            txtCotizacionD.Name = "txtCotizacionD";
            txtCotizacionD.Size = new Size(100, 23);
            txtCotizacionD.TabIndex = 5;
            // 
            // txtCotizacionE
            // 
            txtCotizacionE.Location = new Point(265, 34);
            txtCotizacionE.Name = "txtCotizacionE";
            txtCotizacionE.Size = new Size(100, 23);
            txtCotizacionE.TabIndex = 6;
            txtCotizacionE.KeyPress += txtCotizacionE_KeyPress;
            txtCotizacionE.Leave += txtCotizacionE_Leave;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(180, 110);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(75, 23);
            btnConvertEuro.TabIndex = 7;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(180, 139);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(75, 23);
            btnConvertDolar.TabIndex = 8;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(180, 168);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(75, 23);
            btnConvertPeso.TabIndex = 9;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Enabled = false;
            txtDolarAEuro.Location = new Point(265, 140);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(100, 23);
            txtDolarAEuro.TabIndex = 10;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Enabled = false;
            txtEuroAEuro.Location = new Point(265, 110);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(100, 23);
            txtEuroAEuro.TabIndex = 11;
            // 
            // txtPesosAEuro
            // 
            txtPesosAEuro.Enabled = false;
            txtPesosAEuro.Location = new Point(265, 169);
            txtPesosAEuro.Name = "txtPesosAEuro";
            txtPesosAEuro.Size = new Size(100, 23);
            txtPesosAEuro.TabIndex = 12;
            // 
            // txtPesosADolar
            // 
            txtPesosADolar.Enabled = false;
            txtPesosADolar.Location = new Point(371, 169);
            txtPesosADolar.Name = "txtPesosADolar";
            txtPesosADolar.Size = new Size(100, 23);
            txtPesosADolar.TabIndex = 15;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Enabled = false;
            txtEuroADolar.Location = new Point(371, 110);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(100, 23);
            txtEuroADolar.TabIndex = 14;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Enabled = false;
            txtDolarADolar.Location = new Point(371, 140);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(100, 23);
            txtDolarADolar.TabIndex = 13;
            // 
            // txtPesosAPeso
            // 
            txtPesosAPeso.Enabled = false;
            txtPesosAPeso.Location = new Point(477, 170);
            txtPesosAPeso.Name = "txtPesosAPeso";
            txtPesosAPeso.Size = new Size(100, 23);
            txtPesosAPeso.TabIndex = 18;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Enabled = false;
            txtEuroAPeso.Location = new Point(477, 111);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(100, 23);
            txtEuroAPeso.TabIndex = 17;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Enabled = false;
            txtDolarAPeso.Location = new Point(477, 141);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(100, 23);
            txtDolarAPeso.TabIndex = 16;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(30, 114);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(31, 15);
            lblEuro.TabIndex = 19;
            lblEuro.Text = "Euro";
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Location = new Point(30, 147);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(35, 15);
            lblDolar.TabIndex = 20;
            lblDolar.Text = "Dolar";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(30, 176);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(32, 15);
            lblPeso.TabIndex = 21;
            lblPeso.Text = "Peso";
            // 
            // lblEuro2
            // 
            lblEuro2.AutoSize = true;
            lblEuro2.Location = new Point(299, 9);
            lblEuro2.Name = "lblEuro2";
            lblEuro2.Size = new Size(31, 15);
            lblEuro2.TabIndex = 22;
            lblEuro2.Text = "Euro";
            // 
            // lblDolar2
            // 
            lblDolar2.AutoSize = true;
            lblDolar2.Location = new Point(402, 9);
            lblDolar2.Name = "lblDolar2";
            lblDolar2.Size = new Size(35, 15);
            lblDolar2.TabIndex = 23;
            lblDolar2.Text = "Dolar";
            // 
            // lblPeso2
            // 
            lblPeso2.AutoSize = true;
            lblPeso2.Location = new Point(512, 9);
            lblPeso2.Name = "lblPeso2";
            lblPeso2.Size = new Size(32, 15);
            lblPeso2.TabIndex = 24;
            lblPeso2.Text = "Peso";
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Location = new Point(95, 37);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(63, 15);
            lblCotizacion.TabIndex = 25;
            lblCotizacion.Text = "Cotizacion";
            // 
            // FrmCotizador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 250);
            Controls.Add(lblCotizacion);
            Controls.Add(lblPeso2);
            Controls.Add(lblDolar2);
            Controls.Add(lblEuro2);
            Controls.Add(lblPeso);
            Controls.Add(lblDolar);
            Controls.Add(lblEuro);
            Controls.Add(txtPesosAPeso);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtPesosADolar);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtPesosAEuro);
            Controls.Add(txtEuroAEuro);
            Controls.Add(txtDolarAEuro);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(txtCotizacionE);
            Controls.Add(txtCotizacionD);
            Controls.Add(txtCotizacionP);
            Controls.Add(txtPeso);
            Controls.Add(txtDolar);
            Controls.Add(txtEuro);
            Controls.Add(BtnLock);
            Name = "FrmCotizador";
            Text = " ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnLock;
        private ImageList ImlLock;
        private TextBox txtEuro;
        private TextBox txtDolar;
        private TextBox txtPeso;
        private TextBox txtCotizacionP;
        private TextBox txtCotizacionD;
        private TextBox txtCotizacionE;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private TextBox txtDolarAEuro;
        private TextBox txtEuroAEuro;
        private TextBox txtPesosAEuro;
        private TextBox txtPesosADolar;
        private TextBox txtEuroADolar;
        private TextBox txtDolarADolar;
        private TextBox txtPesosAPeso;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAPeso;
        private Label lblEuro;
        private Label lblDolar;
        private Label lblPeso;
        private Label lblEuro2;
        private Label lblDolar2;
        private Label lblPeso2;
        private Label lblCotizacion;
    }
}