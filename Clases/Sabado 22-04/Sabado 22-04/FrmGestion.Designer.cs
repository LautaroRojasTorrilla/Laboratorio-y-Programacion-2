namespace Sabado_22_04
{
    partial class FrmGestion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            BtnEditar = new Button();
            BtnBorrar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(67, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(345, 289);
            listBox1.TabIndex = 0;
            // 
            // BtnEditar
            // 
            BtnEditar.Location = new Point(67, 355);
            BtnEditar.Name = "BtnEditar";
            BtnEditar.Size = new Size(111, 22);
            BtnEditar.TabIndex = 1;
            BtnEditar.Text = "Editar";
            BtnEditar.UseVisualStyleBackColor = true;
            BtnEditar.Click += BtnEditar_Click;
            // 
            // BtnBorrar
            // 
            BtnBorrar.Location = new Point(301, 355);
            BtnBorrar.Name = "BtnBorrar";
            BtnBorrar.Size = new Size(111, 22);
            BtnBorrar.TabIndex = 2;
            BtnBorrar.Text = "Borrar";
            BtnBorrar.UseVisualStyleBackColor = true;
            BtnBorrar.Click += BtnBorrar_Click;
            // 
            // FrmGestion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(510, 389);
            Controls.Add(BtnBorrar);
            Controls.Add(BtnEditar);
            Controls.Add(listBox1);
            Name = "FrmGestion";
            Text = "FrmGestion";
            Load += FrmGestion_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button BtnEditar;
        private Button BtnBorrar;
    }
}