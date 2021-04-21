
namespace Progra3
{
    partial class frmList
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
            this.btnIterar = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnInfo = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtMostrar = new System.Windows.Forms.TextBox();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnRemoveAt = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnIndexOf = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnIterar
            // 
            this.btnIterar.Location = new System.Drawing.Point(72, 400);
            this.btnIterar.Name = "btnIterar";
            this.btnIterar.Size = new System.Drawing.Size(103, 45);
            this.btnIterar.TabIndex = 24;
            this.btnIterar.Text = "Iterar";
            this.btnIterar.UseVisualStyleBackColor = true;
            this.btnIterar.Click += new System.EventHandler(this.btnIterar_Click);
            this.btnIterar.MouseEnter += new System.EventHandler(this.btnIterar_MouseEnter);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(72, 298);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(103, 45);
            this.btnRemove.TabIndex = 23;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            this.btnRemove.MouseEnter += new System.EventHandler(this.btnRemove_MouseEnter);
            // 
            // btnInfo
            // 
            this.btnInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfo.Location = new System.Drawing.Point(350, 400);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Size = new System.Drawing.Size(103, 45);
            this.btnInfo.TabIndex = 22;
            this.btnInfo.Text = "+ info";
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(211, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(103, 45);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnClear_MouseEnter);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(49, 136);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(0, 17);
            this.lblInfo.TabIndex = 20;
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(72, 478);
            this.txtMostrar.Multiline = true;
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(381, 300);
            this.txtMostrar.TabIndex = 19;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(211, 349);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(103, 45);
            this.btnCount.TabIndex = 18;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            this.btnCount.MouseEnter += new System.EventHandler(this.btnCount_MouseEnter);
            // 
            // btnRemoveAt
            // 
            this.btnRemoveAt.Location = new System.Drawing.Point(211, 303);
            this.btnRemoveAt.Name = "btnRemoveAt";
            this.btnRemoveAt.Size = new System.Drawing.Size(103, 40);
            this.btnRemoveAt.TabIndex = 17;
            this.btnRemoveAt.Text = "Remove At";
            this.btnRemoveAt.UseVisualStyleBackColor = true;
            this.btnRemoveAt.Click += new System.EventHandler(this.btnRemoveAt_Click);
            this.btnRemoveAt.MouseEnter += new System.EventHandler(this.btnRemoveAt_MouseEnter);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(72, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(103, 40);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(192, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 14;
            this.label1.Text = "Listas";
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(52, 61);
            this.txtValor.Multiline = true;
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(185, 32);
            this.txtValor.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Index:";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(303, 58);
            this.txtIndex.Multiline = true;
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(185, 32);
            this.txtIndex.TabIndex = 25;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(211, 244);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(103, 45);
            this.btnInsert.TabIndex = 29;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            this.btnInsert.MouseEnter += new System.EventHandler(this.btnInsert_MouseEnter);
            // 
            // btnIndexOf
            // 
            this.btnIndexOf.Location = new System.Drawing.Point(350, 298);
            this.btnIndexOf.Name = "btnIndexOf";
            this.btnIndexOf.Size = new System.Drawing.Size(103, 40);
            this.btnIndexOf.TabIndex = 28;
            this.btnIndexOf.Text = "Index Of";
            this.btnIndexOf.UseVisualStyleBackColor = true;
            this.btnIndexOf.Click += new System.EventHandler(this.btnIndexOf_Click);
            this.btnIndexOf.MouseEnter += new System.EventHandler(this.btnIndexOf_MouseEnter);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(72, 349);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(103, 40);
            this.btnContains.TabIndex = 27;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            this.btnContains.MouseEnter += new System.EventHandler(this.btnContains_MouseEnter);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(350, 247);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(103, 45);
            this.btnReverse.TabIndex = 30;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            this.btnReverse.MouseEnter += new System.EventHandler(this.btnReverse_MouseEnter);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(350, 344);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(103, 45);
            this.btnSort.TabIndex = 31;
            this.btnSort.Text = "Sort";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            this.btnSort.MouseEnter += new System.EventHandler(this.btnSort_MouseEnter);
            // 
            // frmList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 802);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnIndexOf);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.btnIterar);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInfo);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnRemoveAt);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor);
            this.Name = "frmList";
            this.Text = "frmList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIterar;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnInfo;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtMostrar;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnRemoveAt;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnIndexOf;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnSort;
    }
}