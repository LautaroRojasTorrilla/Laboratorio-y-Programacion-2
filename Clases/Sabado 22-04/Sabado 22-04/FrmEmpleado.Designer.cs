namespace Sabado_22_04
{
    partial class FrmEmpleado
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            TxtNombre = new TextBox();
            TxtSueldo = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            BtnSeleccionar = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(57, 256);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(193, 256);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 45);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 89);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 3;
            label2.Text = "Sueldo";
            // 
            // TxtNombre
            // 
            TxtNombre.Location = new Point(124, 40);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.Size = new Size(115, 23);
            TxtNombre.TabIndex = 4;
            TxtNombre.Validating += TxtNombre_Validating;
            TxtNombre.Validated += TxtNombre_Validated;
            // 
            // TxtSueldo
            // 
            TxtSueldo.Location = new Point(124, 81);
            TxtSueldo.Name = "TxtSueldo";
            TxtSueldo.Size = new Size(115, 23);
            TxtSueldo.TabIndex = 5;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // BtnSeleccionar
            // 
            BtnSeleccionar.Location = new Point(193, 187);
            BtnSeleccionar.Name = "BtnSeleccionar";
            BtnSeleccionar.Size = new Size(75, 23);
            BtnSeleccionar.TabIndex = 6;
            BtnSeleccionar.Text = "Seleccionar";
            BtnSeleccionar.UseVisualStyleBackColor = true;
            BtnSeleccionar.Click += BtnSeleccionar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(47, 149);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(121, 81);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FrmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(337, 318);
            Controls.Add(pictureBox1);
            Controls.Add(BtnSeleccionar);
            Controls.Add(TxtSueldo);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "FrmEmpleado";
            Text = "FrmEmpleado";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private TextBox TxtNombre;
        private TextBox TxtSueldo;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button BtnSeleccionar;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
    }
}