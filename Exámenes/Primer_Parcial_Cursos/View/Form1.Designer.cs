

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
            grpAltaALumno = new GroupBox();
            btnCreaAlumno = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            grpAsignaMateria = new GroupBox();
            cmbMaterias = new ComboBox();
            lblMateria = new Label();
            btnAsignar = new Button();
            lstAlumnosCreados = new ListBox();
            lstAlumnosInscriptosProgramacion = new ListBox();
            lstAlumnosInscriptosLaboratorio = new ListBox();
            lblAlumnosCreados = new Label();
            lblInscriptosProgramacion = new Label();
            lblInscriptosLaboratorio = new Label();
            grpAltaALumno.SuspendLayout();
            grpAsignaMateria.SuspendLayout();
            SuspendLayout();
            // 
            // grpAltaALumno
            // 
            grpAltaALumno.Controls.Add(btnCreaAlumno);
            grpAltaALumno.Controls.Add(txtNombre);
            grpAltaALumno.Controls.Add(txtApellido);
            grpAltaALumno.Controls.Add(txtDni);
            grpAltaALumno.Controls.Add(lblNombre);
            grpAltaALumno.Controls.Add(lblApellido);
            grpAltaALumno.Controls.Add(lblDni);
            grpAltaALumno.Location = new Point(189, 12);
            grpAltaALumno.Name = "grpAltaALumno";
            grpAltaALumno.Size = new Size(339, 159);
            grpAltaALumno.TabIndex = 0;
            grpAltaALumno.TabStop = false;
            grpAltaALumno.Text = "Alta Alumno";
            // 
            // btnCreaAlumno
            // 
            btnCreaAlumno.Location = new Point(108, 113);
            btnCreaAlumno.Name = "btnCreaAlumno";
            btnCreaAlumno.Size = new Size(109, 23);
            btnCreaAlumno.TabIndex = 6;
            btnCreaAlumno.Text = "CREAR ALUMNO";
            btnCreaAlumno.UseVisualStyleBackColor = true;
            btnCreaAlumno.Click += btnCreaAlumno_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(233, 60);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(117, 60);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 4;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(0, 60);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(100, 23);
            txtDni.TabIndex = 3;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(261, 42);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 2;
            lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(147, 42);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(51, 15);
            lblApellido.TabIndex = 1;
            lblApellido.Text = "Apellido";
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(22, 42);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(27, 15);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // grpAsignaMateria
            // 
            grpAsignaMateria.Controls.Add(cmbMaterias);
            grpAsignaMateria.Controls.Add(lblMateria);
            grpAsignaMateria.Controls.Add(btnAsignar);
            grpAsignaMateria.Location = new Point(189, 246);
            grpAsignaMateria.Name = "grpAsignaMateria";
            grpAsignaMateria.Size = new Size(217, 171);
            grpAsignaMateria.TabIndex = 1;
            grpAsignaMateria.TabStop = false;
            grpAsignaMateria.Text = "Asignar Materia";
            // 
            // cmbMaterias
            // 
            cmbMaterias.FormattingEnabled = true;
            cmbMaterias.Location = new Point(57, 66);
            cmbMaterias.Name = "cmbMaterias";
            cmbMaterias.Size = new Size(121, 23);
            cmbMaterias.TabIndex = 9;
            // 
            // lblMateria
            // 
            lblMateria.AutoSize = true;
            lblMateria.Location = new Point(85, 37);
            lblMateria.Name = "lblMateria";
            lblMateria.Size = new Size(55, 15);
            lblMateria.TabIndex = 8;
            lblMateria.Text = "MATERIA";
            // 
            // btnAsignar
            // 
            btnAsignar.Location = new Point(73, 125);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(75, 23);
            btnAsignar.TabIndex = 7;
            btnAsignar.Text = "ASIGNAR";
            btnAsignar.UseVisualStyleBackColor = true;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // lstAlumnosCreados
            // 
            lstAlumnosCreados.FormattingEnabled = true;
            lstAlumnosCreados.ItemHeight = 15;
            lstAlumnosCreados.Location = new Point(3, 188);
            lstAlumnosCreados.Name = "lstAlumnosCreados";
            lstAlumnosCreados.Size = new Size(161, 244);
            lstAlumnosCreados.TabIndex = 7;
            // 
            // lstAlumnosInscriptosProgramacion
            // 
            lstAlumnosInscriptosProgramacion.FormattingEnabled = true;
            lstAlumnosInscriptosProgramacion.ItemHeight = 15;
            lstAlumnosInscriptosProgramacion.Location = new Point(450, 194);
            lstAlumnosInscriptosProgramacion.Name = "lstAlumnosInscriptosProgramacion";
            lstAlumnosInscriptosProgramacion.Size = new Size(161, 244);
            lstAlumnosInscriptosProgramacion.TabIndex = 8;
            // 
            // lstAlumnosInscriptosLaboratorio
            // 
            lstAlumnosInscriptosLaboratorio.FormattingEnabled = true;
            lstAlumnosInscriptosLaboratorio.ItemHeight = 15;
            lstAlumnosInscriptosLaboratorio.Location = new Point(627, 194);
            lstAlumnosInscriptosLaboratorio.Name = "lstAlumnosInscriptosLaboratorio";
            lstAlumnosInscriptosLaboratorio.Size = new Size(161, 244);
            lstAlumnosInscriptosLaboratorio.TabIndex = 9;
            // 
            // lblAlumnosCreados
            // 
            lblAlumnosCreados.AutoSize = true;
            lblAlumnosCreados.Location = new Point(3, 170);
            lblAlumnosCreados.Name = "lblAlumnosCreados";
            lblAlumnosCreados.Size = new Size(101, 15);
            lblAlumnosCreados.TabIndex = 10;
            lblAlumnosCreados.Text = "Alumnos Creados";
            // 
            // lblInscriptosProgramacion
            // 
            lblInscriptosProgramacion.AutoSize = true;
            lblInscriptosProgramacion.Location = new Point(450, 176);
            lblInscriptosProgramacion.Name = "lblInscriptosProgramacion";
            lblInscriptosProgramacion.Size = new Size(136, 15);
            lblInscriptosProgramacion.TabIndex = 11;
            lblInscriptosProgramacion.Text = "Inscriptos Programacion";
            // 
            // lblInscriptosLaboratorio
            // 
            lblInscriptosLaboratorio.AutoSize = true;
            lblInscriptosLaboratorio.Location = new Point(627, 176);
            lblInscriptosLaboratorio.Name = "lblInscriptosLaboratorio";
            lblInscriptosLaboratorio.Size = new Size(122, 15);
            lblInscriptosLaboratorio.TabIndex = 12;
            lblInscriptosLaboratorio.Text = "Inscriptos Laboratorio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblInscriptosLaboratorio);
            Controls.Add(lblInscriptosProgramacion);
            Controls.Add(lblAlumnosCreados);
            Controls.Add(lstAlumnosInscriptosLaboratorio);
            Controls.Add(lstAlumnosInscriptosProgramacion);
            Controls.Add(lstAlumnosCreados);
            Controls.Add(grpAsignaMateria);
            Controls.Add(grpAltaALumno);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Torrilla DIV 2C";
            Load += Form1_Load;
            grpAltaALumno.ResumeLayout(false);
            grpAltaALumno.PerformLayout();
            grpAsignaMateria.ResumeLayout(false);
            grpAsignaMateria.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpAltaALumno;
        private GroupBox grpAsignaMateria;
        private TextBox txtDni;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private Button btnCreaAlumno;
        private Button btnAsignar;
        private Label lblMateria;
        private ListBox lstAlumnosCreados;
        private ListBox lstAlumnosInscriptosProgramacion;
        private ListBox lstAlumnosInscriptosLaboratorio;
        private ComboBox cmbMaterias;
        private Label lblAlumnosCreados;
        private Label lblInscriptosProgramacion;
        private Label lblInscriptosLaboratorio;
    }
}