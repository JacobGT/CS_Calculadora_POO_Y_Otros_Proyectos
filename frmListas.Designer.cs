
namespace Progra3
{
    partial class frmListas
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
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnInsertarNodo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMostrarLista = new System.Windows.Forms.TextBox();
            this.btnMostrarLista = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor a Insertar:";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(178, 34);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(326, 22);
            this.txtValor.TabIndex = 1;
            // 
            // btnInsertarNodo
            // 
            this.btnInsertarNodo.Location = new System.Drawing.Point(166, 99);
            this.btnInsertarNodo.Name = "btnInsertarNodo";
            this.btnInsertarNodo.Size = new System.Drawing.Size(156, 38);
            this.btnInsertarNodo.TabIndex = 2;
            this.btnInsertarNodo.Text = "Insertar Nodo";
            this.btnInsertarNodo.UseVisualStyleBackColor = true;
            this.btnInsertarNodo.Click += new System.EventHandler(this.btnInsertarNodo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(183, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Resultado";
            // 
            // txtMostrarLista
            // 
            this.txtMostrarLista.Location = new System.Drawing.Point(17, 236);
            this.txtMostrarLista.Multiline = true;
            this.txtMostrarLista.Name = "txtMostrarLista";
            this.txtMostrarLista.Size = new System.Drawing.Size(475, 228);
            this.txtMostrarLista.TabIndex = 4;
            // 
            // btnMostrarLista
            // 
            this.btnMostrarLista.Location = new System.Drawing.Point(130, 493);
            this.btnMostrarLista.Name = "btnMostrarLista";
            this.btnMostrarLista.Size = new System.Drawing.Size(192, 65);
            this.btnMostrarLista.TabIndex = 5;
            this.btnMostrarLista.Text = "Mostrar Lista";
            this.btnMostrarLista.UseVisualStyleBackColor = true;
            this.btnMostrarLista.Click += new System.EventHandler(this.btnMostrarLista_Click);
            // 
            // frmListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 701);
            this.Controls.Add(this.btnMostrarLista);
            this.Controls.Add(this.txtMostrarLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsertarNodo);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label1);
            this.Name = "frmListas";
            this.Text = "Demostracion de Listas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnInsertarNodo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMostrarLista;
        private System.Windows.Forms.Button btnMostrarLista;
    }
}