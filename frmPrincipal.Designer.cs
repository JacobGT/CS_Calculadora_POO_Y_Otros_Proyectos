
namespace Progra3
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ejemplosDePOOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sumar2NumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restar2NumerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.catedraticoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ejemplosDePOOToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1330, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuPrincipal";
            // 
            // ejemplosDePOOToolStripMenuItem
            // 
            this.ejemplosDePOOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sumar2NumerosToolStripMenuItem,
            this.restar2NumerosToolStripMenuItem,
            this.calculadoraToolStripMenuItem,
            this.herenciaToolStripMenuItem});
            this.ejemplosDePOOToolStripMenuItem.Name = "ejemplosDePOOToolStripMenuItem";
            this.ejemplosDePOOToolStripMenuItem.Size = new System.Drawing.Size(139, 24);
            this.ejemplosDePOOToolStripMenuItem.Text = "Ejemplos de POO";
            this.ejemplosDePOOToolStripMenuItem.Click += new System.EventHandler(this.ejemplosDePOOToolStripMenuItem_Click);
            // 
            // sumar2NumerosToolStripMenuItem
            // 
            this.sumar2NumerosToolStripMenuItem.Name = "sumar2NumerosToolStripMenuItem";
            this.sumar2NumerosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.sumar2NumerosToolStripMenuItem.Text = "Sumar 2 numeros";
            this.sumar2NumerosToolStripMenuItem.Click += new System.EventHandler(this.sumar2NumerosToolStripMenuItem_Click);
            // 
            // restar2NumerosToolStripMenuItem
            // 
            this.restar2NumerosToolStripMenuItem.Name = "restar2NumerosToolStripMenuItem";
            this.restar2NumerosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.restar2NumerosToolStripMenuItem.Text = "Restar 2 numeros";
            this.restar2NumerosToolStripMenuItem.Click += new System.EventHandler(this.restar2NumerosToolStripMenuItem_Click);
            // 
            // calculadoraToolStripMenuItem
            // 
            this.calculadoraToolStripMenuItem.Name = "calculadoraToolStripMenuItem";
            this.calculadoraToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.calculadoraToolStripMenuItem.Text = "Calculadora";
            this.calculadoraToolStripMenuItem.Click += new System.EventHandler(this.calculadoraToolStripMenuItem_Click);
            // 
            // herenciaToolStripMenuItem
            // 
            this.herenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catedraticoToolStripMenuItem});
            this.herenciaToolStripMenuItem.Name = "herenciaToolStripMenuItem";
            this.herenciaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.herenciaToolStripMenuItem.Text = "Herencia";
            this.herenciaToolStripMenuItem.Click += new System.EventHandler(this.herenciaToolStripMenuItem_Click);
            // 
            // catedraticoToolStripMenuItem
            // 
            this.catedraticoToolStripMenuItem.Name = "catedraticoToolStripMenuItem";
            this.catedraticoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.catedraticoToolStripMenuItem.Text = "Catedratico";
            this.catedraticoToolStripMenuItem.Click += new System.EventHandler(this.catedraticoToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1330, 722);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Formulario Principal Progra 3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ejemplosDePOOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sumar2NumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem restar2NumerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem catedraticoToolStripMenuItem;
    }
}

