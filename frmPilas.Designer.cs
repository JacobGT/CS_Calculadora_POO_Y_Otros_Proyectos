
namespace Progra3
{
    partial class frmPilas
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPush = new System.Windows.Forms.Button();
            this.btnPop = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnIterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(117, 53);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(317, 32);
            this.txtDato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pilas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Dato:";
            // 
            // btnPush
            // 
            this.btnPush.Location = new System.Drawing.Point(74, 173);
            this.btnPush.Name = "btnPush";
            this.btnPush.Size = new System.Drawing.Size(103, 40);
            this.btnPush.TabIndex = 4;
            this.btnPush.Text = "Push";
            this.btnPush.UseVisualStyleBackColor = true;
            this.btnPush.Click += new System.EventHandler(this.btnPush_Click);
            this.btnPush.MouseEnter += new System.EventHandler(this.btnPush_MouseEnter);
            // 
            // btnPop
            // 
            this.btnPop.Location = new System.Drawing.Point(213, 173);
            this.btnPop.Name = "btnPop";
            this.btnPop.Size = new System.Drawing.Size(103, 40);
            this.btnPop.TabIndex = 5;
            this.btnPop.Text = "Pop";
            this.btnPop.UseVisualStyleBackColor = true;
            this.btnPop.Click += new System.EventHandler(this.btnPop_Click);
            this.btnPop.MouseEnter += new System.EventHandler(this.btnPop_MouseEnter);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(213, 249);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(103, 45);
            this.btnCount.TabIndex = 6;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            this.btnCount.MouseEnter += new System.EventHandler(this.btnCount_MouseEnter);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(74, 327);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(381, 300);
            this.txtMostrar.TabIndex = 7;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(50, 99);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 8;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(352, 249);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 39);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(335, 645);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(120, 47);
            this.btnInfo.TabIndex = 10;
            this.btnInfo.Text = "+ info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(352, 173);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(103, 45);
            this.btnPeek.TabIndex = 11;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            this.btnPeek.MouseEnter += new System.EventHandler(this.btnPeek_MouseEnter);
            // 
            // btnIterar
            // 
            this.btnIterar.Location = new System.Drawing.Point(74, 249);
            this.btnIterar.Name = "btnIterar";
            this.btnIterar.Size = new System.Drawing.Size(103, 45);
            this.btnIterar.TabIndex = 12;
            this.btnIterar.Text = "Iterar";
            this.btnIterar.UseVisualStyleBackColor = true;
            this.btnIterar.Click += new System.EventHandler(this.btnIterar_Click);
            this.btnIterar.MouseEnter += new System.EventHandler(this.btnIterar_MouseEnter);
            // 
            // frmPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 721);
            this.Controls.Add(this.btnIterar);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnPop);
            this.Controls.Add(this.btnPush);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Name = "frmPilas";
            this.Text = "frmPilas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnPush;
        private System.Windows.Forms.Button btnPop;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnIterar;
    }
}