using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra3
{
    public partial class frmDepartamento : Form
    {
        departamento depa = new departamento();

        public frmDepartamento()
        {
            InitializeComponent();
        }

        private void frmDepartamento_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.progra3.departamentos);

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            depa.Descripcion = txtDescripcion.Text;

            DataRow registro = this.progra3.departamentos.NewRow();
            registro["descripcion"] = depa.Descripcion;

            this.progra3.departamentos.Rows.Add(registro);
            this.departamentosTableAdapter.Update(this.progra3.departamentos);
            this.dgvDepartamentos.Refresh();
        }

        private void btnAgregar_Enter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            depa.Id_Departamento = Int32.Parse(txtID.Text);
            depa.Descripcion = txtDescripcion.Text;

            DataRow registro = progra3.departamentos.FindByid_departamento(depa.Id_Departamento);
            registro["descripcion"] = depa.Descripcion;

            this.departamentosTableAdapter.Update(this.progra3.departamentos);
            this.departamentosTableAdapter.Fill(this.progra3.departamentos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            depa.Id_Departamento = int.Parse(txtID.Text);
            DataRow registro = progra3.departamentos.FindByid_departamento(depa.Id_Departamento);
            registro.Delete();
            this.departamentosTableAdapter.Update(this.progra3.departamentos);

            txtDescripcion.Text = "Elemento Eliminado de la Base de Datos.";
            txtID.Text = "";

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtDescripcion.Text = "Ingrese un ID para poder buscar un registro.";
            }
            else
            {
                depa.Id_Departamento = int.Parse(txtID.Text);

                DataRow registro = progra3.departamentos.FindByid_departamento(depa.Id_Departamento);
                depa.Descripcion =  registro["descripcion"].ToString();
                txtDescripcion.Text = depa.Descripcion;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                txtDescripcion.Text = "Ingrese un ID para poder buscar un registro.";
            }
            else
            {
                depa.Id_Departamento = int.Parse(txtID.Text);

                DataRow registro = progra3.departamentos.FindByid_departamento(depa.Id_Departamento);
                depa.Descripcion = registro["descripcion"].ToString();
                txtDescripcion.Text = depa.Descripcion;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
    }
}
