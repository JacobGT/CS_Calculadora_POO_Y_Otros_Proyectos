
namespace Progra3
{
    partial class frmMunicipios
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
            this.comboIdDepartamento = new System.Windows.Forms.ComboBox();
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.progra3 = new Progra3.progra3();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.dgvMunicipios = new System.Windows.Forms.DataGridView();
            this.municipiosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.municipiosTableAdapter = new Progra3.progra3TableAdapters.municipiosTableAdapter();
            this.departamentosTableAdapter = new Progra3.progra3TableAdapters.departamentosTableAdapter();
            this.departamentosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idmunicipioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iddepartamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progra3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.comboIdDepartamento);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txtID);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.btnEditar);
            this.splitContainer1.Panel1.Controls.Add(this.btnEliminar);
            this.splitContainer1.Panel1.Controls.Add(this.btnAgregar);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtDescripcion);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMunicipios);
            this.splitContainer1.Size = new System.Drawing.Size(1782, 727);
            this.splitContainer1.SplitterDistance = 594;
            this.splitContainer1.TabIndex = 0;
            // 
            // comboIdDepartamento
            // 
            this.comboIdDepartamento.DataSource = this.departamentosBindingSource;
            this.comboIdDepartamento.DisplayMember = "descripcion";
            this.comboIdDepartamento.FormattingEnabled = true;
            this.comboIdDepartamento.Location = new System.Drawing.Point(97, 140);
            this.comboIdDepartamento.Name = "comboIdDepartamento";
            this.comboIdDepartamento.Size = new System.Drawing.Size(458, 24);
            this.comboIdDepartamento.TabIndex = 74;
            this.comboIdDepartamento.ValueMember = "id_departamento";
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "departamentos";
            this.departamentosBindingSource.DataSource = this.progra3;
            // 
            // progra3
            // 
            this.progra3.DataSetName = "progra3";
            this.progra3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 73;
            this.label2.Text = "ID Municipio:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(97, 53);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(458, 22);
            this.txtID.TabIndex = 72;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(335, 469);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(149, 58);
            this.btnBuscar.TabIndex = 71;
            this.btnBuscar.Text = "Buscar Por \"ID\"";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(71, 469);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(149, 58);
            this.btnEditar.TabIndex = 70;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(335, 385);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(149, 58);
            this.btnEliminar.TabIndex = 69;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(71, 385);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(149, 58);
            this.btnAgregar.TabIndex = 68;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            this.btnAgregar.Enter += new System.EventHandler(this.btnAgregar_Enter);
            this.btnAgregar.MouseEnter += new System.EventHandler(this.btnAgregar_MouseEnter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "ID Departamento:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(97, 208);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(458, 129);
            this.txtDescripcion.TabIndex = 65;
            // 
            // dgvMunicipios
            // 
            this.dgvMunicipios.AllowUserToAddRows = false;
            this.dgvMunicipios.AllowUserToDeleteRows = false;
            this.dgvMunicipios.AutoGenerateColumns = false;
            this.dgvMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmunicipioDataGridViewTextBoxColumn,
            this.iddepartamentoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn});
            this.dgvMunicipios.DataSource = this.municipiosBindingSource;
            this.dgvMunicipios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMunicipios.Location = new System.Drawing.Point(0, 0);
            this.dgvMunicipios.Name = "dgvMunicipios";
            this.dgvMunicipios.ReadOnly = true;
            this.dgvMunicipios.RowHeadersWidth = 51;
            this.dgvMunicipios.RowTemplate.Height = 24;
            this.dgvMunicipios.Size = new System.Drawing.Size(1184, 727);
            this.dgvMunicipios.TabIndex = 0;
            // 
            // municipiosBindingSource
            // 
            this.municipiosBindingSource.DataMember = "municipios";
            this.municipiosBindingSource.DataSource = this.progra3;
            // 
            // municipiosTableAdapter
            // 
            this.municipiosTableAdapter.ClearBeforeFill = true;
            // 
            // departamentosTableAdapter
            // 
            this.departamentosTableAdapter.ClearBeforeFill = true;
            // 
            // departamentosBindingSource1
            // 
            this.departamentosBindingSource1.DataMember = "departamentos";
            this.departamentosBindingSource1.DataSource = this.progra3;
            // 
            // idmunicipioDataGridViewTextBoxColumn
            // 
            this.idmunicipioDataGridViewTextBoxColumn.DataPropertyName = "id_municipio";
            this.idmunicipioDataGridViewTextBoxColumn.HeaderText = "ID Municipio";
            this.idmunicipioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idmunicipioDataGridViewTextBoxColumn.Name = "idmunicipioDataGridViewTextBoxColumn";
            this.idmunicipioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idmunicipioDataGridViewTextBoxColumn.Width = 125;
            // 
            // iddepartamentoDataGridViewTextBoxColumn
            // 
            this.iddepartamentoDataGridViewTextBoxColumn.DataPropertyName = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.DataSource = this.departamentosBindingSource1;
            this.iddepartamentoDataGridViewTextBoxColumn.DisplayMember = "descripcion";
            this.iddepartamentoDataGridViewTextBoxColumn.HeaderText = "ID Departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iddepartamentoDataGridViewTextBoxColumn.Name = "iddepartamentoDataGridViewTextBoxColumn";
            this.iddepartamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddepartamentoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iddepartamentoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iddepartamentoDataGridViewTextBoxColumn.ValueMember = "id_departamento";
            this.iddepartamentoDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1782, 727);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMunicipios";
            this.Text = "frmMunicipios";
            this.Load += new System.EventHandler(this.frmMunicipios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progra3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMunicipios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.municipiosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvMunicipios;
        private progra3 progra3;
        private System.Windows.Forms.BindingSource municipiosBindingSource;
        private progra3TableAdapters.municipiosTableAdapter municipiosTableAdapter;
        private System.Windows.Forms.ComboBox comboIdDepartamento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.BindingSource departamentosBindingSource;
        private progra3TableAdapters.departamentosTableAdapter departamentosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmunicipioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iddepartamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource departamentosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
    }
}