
namespace Progra3
{
    partial class frmCola
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
            this.btnPeek = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDato = new System.Windows.Forms.TextBox();
            this.btnIterar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPeek
            // 
            this.btnPeek.Location = new System.Drawing.Point(320, 221);
            this.btnPeek.Name = "btnPeek";
            this.btnPeek.Size = new System.Drawing.Size(103, 45);
            this.btnPeek.TabIndex = 22;
            this.btnPeek.Text = "Peek";
            this.btnPeek.UseVisualStyleBackColor = true;
            this.btnPeek.Click += new System.EventHandler(this.btnPeek_Click);
            this.btnPeek.MouseEnter += new System.EventHandler(this.btnPeek_MouseEnter);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(303, 690);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(120, 47);
            this.btnInfo.TabIndex = 21;
            this.btnInfo.Text = "+ info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(320, 314);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 39);
            this.btnClear.TabIndex = 20;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(68, 177);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 19;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(42, 384);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(381, 300);
            this.txtMostrar.TabIndex = 18;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(189, 308);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(103, 45);
            this.btnCount.TabIndex = 17;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            this.btnCount.MouseEnter += new System.EventHandler(this.btnCount_MouseEnter);
            // 
            // btnDequeue
            // 
            this.btnDequeue.Location = new System.Drawing.Point(189, 221);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(103, 40);
            this.btnDequeue.TabIndex = 16;
            this.btnDequeue.Text = "Dequeue";
            this.btnDequeue.UseVisualStyleBackColor = true;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            this.btnDequeue.MouseEnter += new System.EventHandler(this.btnDequeue_MouseEnter);
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.Location = new System.Drawing.Point(61, 221);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(103, 40);
            this.btnEnqueue.TabIndex = 15;
            this.btnEnqueue.Text = "Enqueue";
            this.btnEnqueue.UseVisualStyleBackColor = true;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            this.btnEnqueue.MouseEnter += new System.EventHandler(this.btnEnqueue_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Dato:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "Colas";
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(93, 116);
            this.txtDato.Multiline = true;
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(317, 32);
            this.txtDato.TabIndex = 12;
            // 
            // btnIterar
            // 
            this.btnIterar.Location = new System.Drawing.Point(61, 308);
            this.btnIterar.Name = "btnIterar";
            this.btnIterar.Size = new System.Drawing.Size(103, 39);
            this.btnIterar.TabIndex = 23;
            this.btnIterar.Text = "Iterar";
            this.btnIterar.UseVisualStyleBackColor = true;
            this.btnIterar.Click += new System.EventHandler(this.btnIterar_Click);
            this.btnIterar.MouseEnter += new System.EventHandler(this.btnIterar_MouseEnter);
            // 
            // frmCola
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 759);
            this.Controls.Add(this.btnIterar);
            this.Controls.Add(this.btnPeek);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Name = "frmCola";
            this.Text = "frmCola";
            this.MouseEnter += new System.EventHandler(this.frmCola_MouseEnter);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPeek;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button btnIterar;
    }
}