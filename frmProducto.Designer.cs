
namespace Progra3
{
    partial class frmProducto
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkEstado = new System.Windows.Forms.CheckBox();
            this.comboModelo = new System.Windows.Forms.ComboBox();
            this.modeloBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progra3 = new Progra3.progra3();
            this.comboMarca = new System.Windows.Forms.ComboBox();
            this.marcaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdProducto = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.marcaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.modeloBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productoTableAdapter = new Progra3.progra3TableAdapters.productoTableAdapter();
            this.marcaTableAdapter = new Progra3.progra3TableAdapters.marcaTableAdapter();
            this.modeloTableAdapter = new Progra3.progra3TableAdapters.modeloTableAdapter();
            this.iDproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDmarcaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.iDmodeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.estadoregistroDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progra3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.checkEstado);
            this.splitContainer1.Panel1.Controls.Add(this.comboModelo);
            this.splitContainer1.Panel1.Controls.Add(this.comboMarca);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescripcion);
            this.splitContainer1.Panel1.Controls.Add(this.txtIdProducto);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1506, 658);
            this.splitContainer1.SplitterDistance = 502;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(271, 366);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 60);
            this.btnEliminar.TabIndex = 12;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(61, 366);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 60);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modelo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Estado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id Producto:";
            // 
            // checkEstado
            // 
            this.checkEstado.AutoSize = true;
            this.checkEstado.Checked = true;
            this.checkEstado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkEstado.Location = new System.Drawing.Point(61, 312);
            this.checkEstado.Name = "checkEstado";
            this.checkEstado.Size = new System.Drawing.Size(84, 21);
            this.checkEstado.TabIndex = 5;
            this.checkEstado.Text = "Activado";
            this.checkEstado.UseVisualStyleBackColor = true;
            // 
            // comboModelo
            // 
            this.comboModelo.DataSource = this.modeloBindingSource;
            this.comboModelo.DisplayMember = "descripcion";
            this.comboModelo.FormattingEnabled = true;
            this.comboModelo.Location = new System.Drawing.Point(212, 234);
            this.comboModelo.Name = "comboModelo";
            this.comboModelo.Size = new System.Drawing.Size(121, 24);
            this.comboModelo.TabIndex = 4;
            this.comboModelo.ValueMember = "ID_modelo";
            // 
            // modeloBindingSource
            // 
            this.modeloBindingSource.DataMember = "modelo";
            this.modeloBindingSource.DataSource = this.progra3;
            // 
            // progra3
            // 
            this.progra3.DataSetName = "progra3";
            this.progra3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboMarca
            // 
            this.comboMarca.DataSource = this.marcaBindingSource;
            this.comboMarca.DisplayMember = "descripcion";
            this.comboMarca.FormattingEnabled = true;
            this.comboMarca.Location = new System.Drawing.Point(61, 234);
            this.comboMarca.Name = "comboMarca";
            this.comboMarca.Size = new System.Drawing.Size(121, 24);
            this.comboMarca.TabIndex = 3;
            this.comboMarca.ValueMember = "ID_marca";
            // 
            // marcaBindingSource
            // 
            this.marcaBindingSource.DataMember = "marca";
            this.marcaBindingSource.DataSource = this.progra3;
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(61, 125);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 67);
            this.txtDescripcion.TabIndex = 2;
            // 
            // txtIdProducto
            // 
            this.txtIdProducto.Location = new System.Drawing.Point(61, 60);
            this.txtIdProducto.Name = "txtIdProducto";
            this.txtIdProducto.Size = new System.Drawing.Size(272, 22);
            this.txtIdProducto.TabIndex = 1;
            this.txtIdProducto.Leave += new System.EventHandler(this.txtIdProducto_Leave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDproductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.iDmarcaDataGridViewTextBoxColumn,
            this.iDmodeloDataGridViewTextBoxColumn,
            this.estadoregistroDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.productoBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 658);
            this.dataGridView1.TabIndex = 0;
            // 
            // marcaBindingSource1
            // 
            this.marcaBindingSource1.DataMember = "marca";
            this.marcaBindingSource1.DataSource = this.progra3;
            // 
            // modeloBindingSource1
            // 
            this.modeloBindingSource1.DataMember = "modelo";
            this.modeloBindingSource1.DataSource = this.progra3;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataMember = "producto";
            this.productoBindingSource.DataSource = this.progra3;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // marcaTableAdapter
            // 
            this.marcaTableAdapter.ClearBeforeFill = true;
            // 
            // modeloTableAdapter
            // 
            this.modeloTableAdapter.ClearBeforeFill = true;
            // 
            // iDproductoDataGridViewTextBoxColumn
            // 
            this.iDproductoDataGridViewTextBoxColumn.DataPropertyName = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn.HeaderText = "ID_producto";
            this.iDproductoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDproductoDataGridViewTextBoxColumn.Name = "iDproductoDataGridViewTextBoxColumn";
            this.iDproductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDproductoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDmarcaDataGridViewTextBoxColumn
            // 
            this.iDmarcaDataGridViewTextBoxColumn.DataPropertyName = "ID_marca";
            this.iDmarcaDataGridViewTextBoxColumn.DataSource = this.marcaBindingSource1;
            this.iDmarcaDataGridViewTextBoxColumn.DisplayMember = "descripcion";
            this.iDmarcaDataGridViewTextBoxColumn.HeaderText = "ID_marca";
            this.iDmarcaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDmarcaDataGridViewTextBoxColumn.Name = "iDmarcaDataGridViewTextBoxColumn";
            this.iDmarcaDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDmarcaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDmarcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDmarcaDataGridViewTextBoxColumn.ValueMember = "ID_marca";
            this.iDmarcaDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDmodeloDataGridViewTextBoxColumn
            // 
            this.iDmodeloDataGridViewTextBoxColumn.DataPropertyName = "ID_modelo";
            this.iDmodeloDataGridViewTextBoxColumn.DataSource = this.modeloBindingSource1;
            this.iDmodeloDataGridViewTextBoxColumn.DisplayMember = "descripcion";
            this.iDmodeloDataGridViewTextBoxColumn.HeaderText = "ID_modelo";
            this.iDmodeloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDmodeloDataGridViewTextBoxColumn.Name = "iDmodeloDataGridViewTextBoxColumn";
            this.iDmodeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDmodeloDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDmodeloDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDmodeloDataGridViewTextBoxColumn.ValueMember = "ID_modelo";
            this.iDmodeloDataGridViewTextBoxColumn.Width = 125;
            // 
            // estadoregistroDataGridViewCheckBoxColumn
            // 
            this.estadoregistroDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.estadoregistroDataGridViewCheckBoxColumn.DataPropertyName = "estado_registro";
            this.estadoregistroDataGridViewCheckBoxColumn.HeaderText = "estado_registro";
            this.estadoregistroDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.estadoregistroDataGridViewCheckBoxColumn.Name = "estadoregistroDataGridViewCheckBoxColumn";
            this.estadoregistroDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 658);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmProducto";
            this.Text = "Mantenimiento de Productos";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progra3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marcaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modeloBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkEstado;
        private System.Windows.Forms.ComboBox comboModelo;
        private System.Windows.Forms.ComboBox comboMarca;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private progra3 progra3;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private progra3TableAdapters.productoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.BindingSource marcaBindingSource;
        private progra3TableAdapters.marcaTableAdapter marcaTableAdapter;
        private System.Windows.Forms.BindingSource modeloBindingSource;
        private progra3TableAdapters.modeloTableAdapter modeloTableAdapter;
        private System.Windows.Forms.BindingSource marcaBindingSource1;
        private System.Windows.Forms.BindingSource modeloBindingSource1;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDmarcaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDmodeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn estadoregistroDataGridViewCheckBoxColumn;
    }
}