
namespace Progra3
{
    partial class frmColaClientes
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCola = new System.Windows.Forms.TextBox();
            this.btnbSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cola";
            // 
            // txtCola
            // 
            this.txtCola.Location = new System.Drawing.Point(12, 57);
            this.txtCola.Multiline = true;
            this.txtCola.Name = "txtCola";
            this.txtCola.Size = new System.Drawing.Size(515, 710);
            this.txtCola.TabIndex = 4;
            this.txtCola.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnbSync
            // 
            this.btnbSync.BackColor = System.Drawing.SystemColors.Window;
            this.btnbSync.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbSync.Location = new System.Drawing.Point(398, 12);
            this.btnbSync.Name = "btnbSync";
            this.btnbSync.Size = new System.Drawing.Size(129, 39);
            this.btnbSync.TabIndex = 5;
            this.btnbSync.Text = "⟲ Refresh";
            this.btnbSync.UseVisualStyleBackColor = false;
            this.btnbSync.Click += new System.EventHandler(this.btnbSync_Click);
            // 
            // frmColaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(539, 779);
            this.Controls.Add(this.btnbSync);
            this.Controls.Add(this.txtCola);
            this.Controls.Add(this.label1);
            this.Name = "frmColaClientes";
            this.Text = "Cola";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCola;
        private System.Windows.Forms.Button btnbSync;
    }
}