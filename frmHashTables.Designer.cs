
namespace Progra3
{
    partial class frmHashTables
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.txtValueDos = new System.Windows.Forms.TextBox();
            this.txtHash = new System.Windows.Forms.TextBox();
            this.txtValueUno = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnContains = new System.Windows.Forms.Button();
            this.btnSearchKey = new System.Windows.Forms.Button();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnIterar = new System.Windows.Forms.Button();
            this.btnHash = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hash Tables";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(23, 475);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(485, 306);
            this.txtInfo.TabIndex = 6;
            // 
            // txtValueDos
            // 
            this.txtValueDos.Location = new System.Drawing.Point(328, 238);
            this.txtValueDos.Name = "txtValueDos";
            this.txtValueDos.Size = new System.Drawing.Size(170, 22);
            this.txtValueDos.TabIndex = 7;
            // 
            // txtHash
            // 
            this.txtHash.Location = new System.Drawing.Point(71, 238);
            this.txtHash.Name = "txtHash";
            this.txtHash.Size = new System.Drawing.Size(158, 22);
            this.txtHash.TabIndex = 8;
            // 
            // txtValueUno
            // 
            this.txtValueUno.Location = new System.Drawing.Point(328, 96);
            this.txtValueUno.Name = "txtValueUno";
            this.txtValueUno.Size = new System.Drawing.Size(170, 22);
            this.txtValueUno.TabIndex = 9;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(71, 96);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(158, 22);
            this.txtKey.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(23, 308);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 47);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(199, 308);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(110, 47);
            this.btnRemove.TabIndex = 15;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnContains
            // 
            this.btnContains.Location = new System.Drawing.Point(388, 308);
            this.btnContains.Name = "btnContains";
            this.btnContains.Size = new System.Drawing.Size(110, 47);
            this.btnContains.TabIndex = 16;
            this.btnContains.Text = "Contains";
            this.btnContains.UseVisualStyleBackColor = true;
            this.btnContains.Click += new System.EventHandler(this.btnContains_Click);
            // 
            // btnSearchKey
            // 
            this.btnSearchKey.Location = new System.Drawing.Point(354, 386);
            this.btnSearchKey.Name = "btnSearchKey";
            this.btnSearchKey.Size = new System.Drawing.Size(144, 47);
            this.btnSearchKey.TabIndex = 17;
            this.btnSearchKey.Text = "Search Key";
            this.btnSearchKey.UseVisualStyleBackColor = true;
            this.btnSearchKey.Click += new System.EventHandler(this.btnSearchKey_Click);
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(199, 386);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(110, 47);
            this.btnCount.TabIndex = 18;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnIterar
            // 
            this.btnIterar.Location = new System.Drawing.Point(22, 386);
            this.btnIterar.Name = "btnIterar";
            this.btnIterar.Size = new System.Drawing.Size(110, 47);
            this.btnIterar.TabIndex = 19;
            this.btnIterar.Text = "Iterar";
            this.btnIterar.UseVisualStyleBackColor = true;
            this.btnIterar.Click += new System.EventHandler(this.btnIterar_Click);
            // 
            // btnHash
            // 
            this.btnHash.Location = new System.Drawing.Point(199, 151);
            this.btnHash.Name = "btnHash";
            this.btnHash.Size = new System.Drawing.Size(124, 45);
            this.btnHash.TabIndex = 20;
            this.btnHash.Text = "Hashing";
            this.btnHash.UseVisualStyleBackColor = true;
            this.btnHash.Click += new System.EventHandler(this.btnHash_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "Hash:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Value:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 17);
            this.label9.TabIndex = 28;
            this.label9.Text = "Key:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 27;
            this.label8.Text = "Value:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 455);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Hash Table:";
            // 
            // frmHashTables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 816);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnHash);
            this.Controls.Add(this.btnIterar);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.btnSearchKey);
            this.Controls.Add(this.btnContains);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtValueUno);
            this.Controls.Add(this.txtHash);
            this.Controls.Add(this.txtValueDos);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.label1);
            this.Name = "frmHashTables";
            this.Text = "hashTables";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtValueDos;
        private System.Windows.Forms.TextBox txtHash;
        private System.Windows.Forms.TextBox txtValueUno;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnContains;
        private System.Windows.Forms.Button btnSearchKey;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnIterar;
        private System.Windows.Forms.Button btnHash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
    }
}