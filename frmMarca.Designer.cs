
namespace Progra3
{
    partial class frmMarca
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabMantenimiento = new System.Windows.Forms.TabControl();
            this.tbpIngreso = new System.Windows.Forms.TabPage();
            this.tbpModificacion = new System.Windows.Forms.TabPage();
            this.tbpEliminacion = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIngresarDescripcion = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.txtModDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIdMod = new System.Windows.Forms.TextBox();
            this.txtIdEliminar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txtEliminarDescripcion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvMarcas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabMantenimiento.SuspendLayout();
            this.tbpIngreso.SuspendLayout();
            this.tbpModificacion.SuspendLayout();
            this.tbpEliminacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.tabMantenimiento);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvMarcas);
            this.splitContainer1.Size = new System.Drawing.Size(1311, 666);
            this.splitContainer1.SplitterDistance = 659;
            this.splitContainer1.TabIndex = 0;
            // 
            // tabMantenimiento
            // 
            this.tabMantenimiento.Controls.Add(this.tbpIngreso);
            this.tabMantenimiento.Controls.Add(this.tbpModificacion);
            this.tabMantenimiento.Controls.Add(this.tbpEliminacion);
            this.tabMantenimiento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMantenimiento.Location = new System.Drawing.Point(0, 0);
            this.tabMantenimiento.Name = "tabMantenimiento";
            this.tabMantenimiento.SelectedIndex = 0;
            this.tabMantenimiento.Size = new System.Drawing.Size(659, 666);
            this.tabMantenimiento.TabIndex = 0;
            // 
            // tbpIngreso
            // 
            this.tbpIngreso.Controls.Add(this.btnIngresar);
            this.tbpIngreso.Controls.Add(this.txtIngresarDescripcion);
            this.tbpIngreso.Controls.Add(this.label1);
            this.tbpIngreso.Location = new System.Drawing.Point(4, 25);
            this.tbpIngreso.Name = "tbpIngreso";
            this.tbpIngreso.Padding = new System.Windows.Forms.Padding(3);
            this.tbpIngreso.Size = new System.Drawing.Size(651, 637);
            this.tbpIngreso.TabIndex = 0;
            this.tbpIngreso.Text = "Ingreso";
            this.tbpIngreso.UseVisualStyleBackColor = true;
            // 
            // tbpModificacion
            // 
            this.tbpModificacion.Controls.Add(this.txtIdMod);
            this.tbpModificacion.Controls.Add(this.label3);
            this.tbpModificacion.Controls.Add(this.btnModificar);
            this.tbpModificacion.Controls.Add(this.txtModDescripcion);
            this.tbpModificacion.Controls.Add(this.label2);
            this.tbpModificacion.Location = new System.Drawing.Point(4, 25);
            this.tbpModificacion.Name = "tbpModificacion";
            this.tbpModificacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpModificacion.Size = new System.Drawing.Size(651, 637);
            this.tbpModificacion.TabIndex = 1;
            this.tbpModificacion.Text = "Modificacion";
            this.tbpModificacion.UseVisualStyleBackColor = true;
            // 
            // tbpEliminacion
            // 
            this.tbpEliminacion.Controls.Add(this.txtEliminarDescripcion);
            this.tbpEliminacion.Controls.Add(this.label5);
            this.tbpEliminacion.Controls.Add(this.txtIdEliminar);
            this.tbpEliminacion.Controls.Add(this.label4);
            this.tbpEliminacion.Controls.Add(this.btnEliminar);
            this.tbpEliminacion.Location = new System.Drawing.Point(4, 25);
            this.tbpEliminacion.Name = "tbpEliminacion";
            this.tbpEliminacion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpEliminacion.Size = new System.Drawing.Size(651, 637);
            this.tbpEliminacion.TabIndex = 2;
            this.tbpEliminacion.Text = "Eliminacion";
            this.tbpEliminacion.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descripcion:";
            // 
            // txtIngresarDescripcion
            // 
            this.txtIngresarDescripcion.Location = new System.Drawing.Point(110, 25);
            this.txtIngresarDescripcion.Multiline = true;
            this.txtIngresarDescripcion.Name = "txtIngresarDescripcion";
            this.txtIngresarDescripcion.Size = new System.Drawing.Size(512, 100);
            this.txtIngresarDescripcion.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(21, 139);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(83, 30);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(17, 213);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(83, 30);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // txtModDescripcion
            // 
            this.txtModDescripcion.Location = new System.Drawing.Point(106, 29);
            this.txtModDescripcion.Multiline = true;
            this.txtModDescripcion.Name = "txtModDescripcion";
            this.txtModDescripcion.Size = new System.Drawing.Size(527, 100);
            this.txtModDescripcion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "ID:";
            // 
            // txtIdMod
            // 
            this.txtIdMod.Location = new System.Drawing.Point(106, 157);
            this.txtIdMod.Name = "txtIdMod";
            this.txtIdMod.Size = new System.Drawing.Size(217, 22);
            this.txtIdMod.TabIndex = 7;
            // 
            // txtIdEliminar
            // 
            this.txtIdEliminar.Location = new System.Drawing.Point(103, 134);
            this.txtIdEliminar.Name = "txtIdEliminar";
            this.txtIdEliminar.Size = new System.Drawing.Size(217, 22);
            this.txtIdEliminar.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(14, 183);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(83, 30);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // txtEliminarDescripcion
            // 
            this.txtEliminarDescripcion.Location = new System.Drawing.Point(103, 15);
            this.txtEliminarDescripcion.Multiline = true;
            this.txtEliminarDescripcion.Name = "txtEliminarDescripcion";
            this.txtEliminarDescripcion.Size = new System.Drawing.Size(527, 100);
            this.txtEliminarDescripcion.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Descripcion:";
            // 
            // dgvMarcas
            // 
            this.dgvMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarcas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMarcas.Location = new System.Drawing.Point(0, 0);
            this.dgvMarcas.Name = "dgvMarcas";
            this.dgvMarcas.RowHeadersWidth = 51;
            this.dgvMarcas.RowTemplate.Height = 24;
            this.dgvMarcas.Size = new System.Drawing.Size(648, 666);
            this.dgvMarcas.TabIndex = 0;
            // 
            // frmMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 666);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmMarca";
            this.Text = "Mantenimiento de Marca";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabMantenimiento.ResumeLayout(false);
            this.tbpIngreso.ResumeLayout(false);
            this.tbpIngreso.PerformLayout();
            this.tbpModificacion.ResumeLayout(false);
            this.tbpModificacion.PerformLayout();
            this.tbpEliminacion.ResumeLayout(false);
            this.tbpEliminacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarcas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabMantenimiento;
        private System.Windows.Forms.TabPage tbpIngreso;
        private System.Windows.Forms.TabPage tbpModificacion;
        private System.Windows.Forms.TabPage tbpEliminacion;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtIngresarDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtModDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEliminarDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvMarcas;
    }
}