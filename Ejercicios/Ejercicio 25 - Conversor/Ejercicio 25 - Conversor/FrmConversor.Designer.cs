namespace Ejercicio_25___Conversor
{
    partial class FrmConversor
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
            lblBinaDec = new Label();
            lblDecaBin = new Label();
            btnBinToDec = new Button();
            btnDecToBin = new Button();
            txtBinario = new TextBox();
            txtDecimal = new TextBox();
            txtResultadoDec = new TextBox();
            txtResultadoBin = new TextBox();
            SuspendLayout();
            // 
            // lblBinaDec
            // 
            lblBinaDec.AutoSize = true;
            lblBinaDec.Location = new Point(23, 31);
            lblBinaDec.Name = "lblBinaDec";
            lblBinaDec.Size = new Size(99, 15);
            lblBinaDec.TabIndex = 0;
            lblBinaDec.Text = "Binario a Decimal";
            // 
            // lblDecaBin
            // 
            lblDecaBin.AutoSize = true;
            lblDecaBin.Location = new Point(23, 71);
            lblDecaBin.Name = "lblDecaBin";
            lblDecaBin.Size = new Size(99, 15);
            lblDecaBin.TabIndex = 1;
            lblDecaBin.Text = "Decimal a Binario";
            // 
            // btnBinToDec
            // 
            btnBinToDec.Location = new Point(249, 27);
            btnBinToDec.Name = "btnBinToDec";
            btnBinToDec.Size = new Size(75, 23);
            btnBinToDec.TabIndex = 2;
            btnBinToDec.Text = "->";
            btnBinToDec.UseVisualStyleBackColor = true;
            btnBinToDec.Click += btnBinToDec_Click;
            // 
            // btnDecToBin
            // 
            btnDecToBin.Location = new Point(249, 70);
            btnDecToBin.Name = "btnDecToBin";
            btnDecToBin.Size = new Size(75, 23);
            btnDecToBin.TabIndex = 3;
            btnDecToBin.Text = "->";
            btnDecToBin.UseVisualStyleBackColor = true;
            btnDecToBin.Click += btnDecToBin_Click;
            // 
            // txtBinario
            // 
            txtBinario.Location = new Point(128, 28);
            txtBinario.Name = "txtBinario";
            txtBinario.Size = new Size(100, 23);
            txtBinario.TabIndex = 4;
            // 
            // txtDecimal
            // 
            txtDecimal.Location = new Point(128, 68);
            txtDecimal.Name = "txtDecimal";
            txtDecimal.Size = new Size(100, 23);
            txtDecimal.TabIndex = 5;
            // 
            // txtResultadoDec
            // 
            txtResultadoDec.Enabled = false;
            txtResultadoDec.Location = new Point(347, 27);
            txtResultadoDec.Name = "txtResultadoDec";
            txtResultadoDec.Size = new Size(100, 23);
            txtResultadoDec.TabIndex = 6;
            // 
            // txtResultadoBin
            // 
            txtResultadoBin.Enabled = false;
            txtResultadoBin.Location = new Point(347, 70);
            txtResultadoBin.Name = "txtResultadoBin";
            txtResultadoBin.Size = new Size(100, 23);
            txtResultadoBin.TabIndex = 7;
            // 
            // FrmConversor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(518, 122);
            Controls.Add(txtResultadoBin);
            Controls.Add(txtResultadoDec);
            Controls.Add(txtDecimal);
            Controls.Add(txtBinario);
            Controls.Add(btnDecToBin);
            Controls.Add(btnBinToDec);
            Controls.Add(lblDecaBin);
            Controls.Add(lblBinaDec);
            Name = "FrmConversor";
            Text = "Conversor Numérico";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBinaDec;
        private Label lblDecaBin;
        private Button btnBinToDec;
        private Button btnDecToBin;
        private TextBox txtBinario;
        private TextBox txtDecimal;
        private TextBox txtResultadoDec;
        private TextBox txtResultadoBin;
    }
}