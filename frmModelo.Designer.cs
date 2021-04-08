
namespace Progra3
{
    partial class frmModelo
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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvModelo = new System.Windows.Forms.DataGridView();
            this.progra3 = new Progra3.progra3();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modeloTableAdapter = new Progra3.progra3TableAdapters.modeloTableAdapter();
            this.iDmodeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGuardarDatos = new System.Windows.Forms.Button();
            this.marcaTableAdapter = new Progra3.progra3TableAdapters.marcaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progra3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnGuardarDatos);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvModelo);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvModelo
            // 
            this.dgvModelo.AllowUserToOrderColumns = true;
            this.dgvModelo.AutoGenerateColumns = false;
            this.dgvModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModelo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDmodeloDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvModelo.DataSource = this.modeloBindingSource;
            this.dgvModelo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvModelo.Location = new System.Drawing.Point(0, 0);
            this.dgvModelo.Name = "dgvModelo";
            this.dgvModelo.RowHeadersWidth = 51;
            this.dgvModelo.RowTemplate.Height = 24;
            this.dgvModelo.Size = new System.Drawing.Size(530, 450);
            this.dgvModelo.TabIndex = 0;
            // 
            // progra3
            // 
            this.progra3.DataSetName = "progra3";
            this.progra3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.progra3;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // iDmodeloDataGridViewTextBoxColumn
            // 
            this.iDmodeloDataGridViewTextBoxColumn.DataPropertyName = "ID_modelo";
            this.iDmodeloDataGridViewTextBoxColumn.HeaderText = "ID Modelo";
            this.iDmodeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDmodeloDataGridViewTextBoxColumn.Name = "iDmodeloDataGridViewTextBoxColumn";
            this.iDmodeloDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // btnGuardarDatos
            // 
            this.btnGuardarDatos.Location = new System.Drawing.Point(65, 44);
            this.btnGuardarDatos.Name = "btnGuardarDatos";
            this.btnGuardarDatos.Size = new System.Drawing.Size(114, 65);
            this.btnGuardarDatos.TabIndex = 0;
            this.btnGuardarDatos.Text = "Guardar Datos";
            this.btnGuardarDatos.UseVisualStyleBackColor = true;
            this.btnGuardarDatos.Click += new System.EventHandler(this.btnGuardarDatos_Click);
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // frmModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmModelo";
            this.Text = "Mantenimiento de Datos";
            this.Load += new System.EventHandler(this.frmModelo_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModelo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progra3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvModelo;
        private progra3 progra3;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private progra3TableAdapters.modeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDmodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnGuardarDatos;
        private progra3TableAdapters.marcaTableAdapter marcaTableAdapter;
    }
}