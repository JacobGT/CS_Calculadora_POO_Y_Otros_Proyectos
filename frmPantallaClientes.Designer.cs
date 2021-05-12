
namespace Progra3
{
    partial class frmPantallaClientes
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
            this.txtPantalla = new System.Windows.Forms.TextBox();
            this.txtContador = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPantalla
            // 
            this.txtPantalla.BackColor = System.Drawing.SystemColors.WindowText;
            this.txtPantalla.ForeColor = System.Drawing.SystemColors.Window;
            this.txtPantalla.Location = new System.Drawing.Point(1, 48);
            this.txtPantalla.Multiline = true;
            this.txtPantalla.Name = "txtPantalla";
            this.txtPantalla.Size = new System.Drawing.Size(562, 652);
            this.txtPantalla.TabIndex = 0;
            // 
            // txtContador
            // 
            this.txtContador.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtContador.ForeColor = System.Drawing.SystemColors.Window;
            this.txtContador.Location = new System.Drawing.Point(463, 706);
            this.txtContador.Multiline = true;
            this.txtContador.Name = "txtContador";
            this.txtContador.Size = new System.Drawing.Size(100, 46);
            this.txtContador.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pantalla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(163, 706);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Clientes atendidos hoy:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnReset.Location = new System.Drawing.Point(12, 706);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(134, 39);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Borrar Pantalla";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.WindowText;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRefresh.Location = new System.Drawing.Point(422, 6);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(129, 39);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "⟲ Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmPantallaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(563, 755);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContador);
            this.Controls.Add(this.txtPantalla);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Name = "frmPantallaClientes";
            this.Text = "Pantalla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPantalla;
        private System.Windows.Forms.TextBox txtContador;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnRefresh;
    }
}