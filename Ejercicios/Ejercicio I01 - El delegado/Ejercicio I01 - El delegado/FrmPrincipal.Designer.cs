namespace Ejercicio_I01___El_delegado
{
    partial class FrmPrincipal
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
            menuInicio = new MenuStrip();
            altaToolStripMenuItem = new ToolStripMenuItem();
            testDelegadoToolStripMenuItem = new ToolStripMenuItem();
            alumnoToolStripMenuItem = new ToolStripMenuItem();
            mostrarToolStripMenuItem = new ToolStripMenuItem();
            menuInicio.SuspendLayout();
            SuspendLayout();
            // 
            // menuInicio
            // 
            menuInicio.Items.AddRange(new ToolStripItem[] { altaToolStripMenuItem, mostrarToolStripMenuItem });
            menuInicio.Location = new Point(0, 0);
            menuInicio.Name = "menuInicio";
            menuInicio.Size = new Size(800, 24);
            menuInicio.TabIndex = 1;
            menuInicio.Text = "menuStrip1";
            // 
            // altaToolStripMenuItem
            // 
            altaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { testDelegadoToolStripMenuItem, alumnoToolStripMenuItem });
            altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            altaToolStripMenuItem.Size = new Size(40, 20);
            altaToolStripMenuItem.Text = "Alta";
            // 
            // testDelegadoToolStripMenuItem
            // 
            testDelegadoToolStripMenuItem.Name = "testDelegadoToolStripMenuItem";
            testDelegadoToolStripMenuItem.Size = new Size(180, 22);
            testDelegadoToolStripMenuItem.Text = "Test Delegados";
            testDelegadoToolStripMenuItem.Click += testDelegadoToolStripMenuItem_Click;
            // 
            // alumnoToolStripMenuItem
            // 
            alumnoToolStripMenuItem.Name = "alumnoToolStripMenuItem";
            alumnoToolStripMenuItem.Size = new Size(180, 22);
            alumnoToolStripMenuItem.Text = "Alumno";
            // 
            // mostrarToolStripMenuItem
            // 
            mostrarToolStripMenuItem.Enabled = false;
            mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            mostrarToolStripMenuItem.Size = new Size(60, 20);
            mostrarToolStripMenuItem.Text = "Mostrar";
            mostrarToolStripMenuItem.Click += mostrarToolStripMenuItem_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuInicio);
            IsMdiContainer = true;
            MainMenuStrip = menuInicio;
            Name = "FrmPrincipal";
            Text = "Principal";
            WindowState = FormWindowState.Maximized;
            Load += FrmPrincipal_Load;
            menuInicio.ResumeLayout(false);
            menuInicio.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuInicio;
        private ToolStripMenuItem altaToolStripMenuItem;
        private ToolStripMenuItem testDelegadoToolStripMenuItem;
        private ToolStripMenuItem alumnoToolStripMenuItem;
        private ToolStripMenuItem mostrarToolStripMenuItem;
    }
}