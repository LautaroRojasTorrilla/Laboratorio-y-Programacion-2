namespace Form1
{
    partial class FrmView
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
            lblHora = new Label();
            btnIniciar = new Button();
            btnCancelar = new Button();
            txtIngreso = new TextBox();
            SuspendLayout();
            // 
            // lblHora
            // 
            lblHora.AutoSize = true;
            lblHora.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            lblHora.Location = new Point(82, 28);
            lblHora.Name = "lblHora";
            lblHora.Size = new Size(90, 42);
            lblHora.TabIndex = 0;
            lblHora.Text = "Hora";
            // 
            // btnIniciar
            // 
            btnIniciar.Location = new Point(82, 159);
            btnIniciar.Name = "btnIniciar";
            btnIniciar.Size = new Size(155, 75);
            btnIniciar.TabIndex = 1;
            btnIniciar.Text = "INICIAR";
            btnIniciar.UseVisualStyleBackColor = true;
            btnIniciar.Click += btnIniciar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(265, 159);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(155, 75);
            btnCancelar.TabIndex = 2;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // txtIngreso
            // 
            txtIngreso.Location = new Point(82, 112);
            txtIngreso.Name = "txtIngreso";
            txtIngreso.Size = new Size(338, 23);
            txtIngreso.TabIndex = 3;
            // 
            // FrmView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(526, 313);
            Controls.Add(txtIngreso);
            Controls.Add(btnCancelar);
            Controls.Add(btnIniciar);
            Controls.Add(lblHora);
            Name = "FrmView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tasks";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHora;
        private Button btnIniciar;
        private Button btnCancelar;
        private TextBox txtIngreso;
    }
}