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
    public partial class frmIndustrias : Form
    {
        industrias industry = new industrias();
        public frmIndustrias()
        {
            InitializeComponent();
        }

        private void frmIndustrias_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.industrias' table. You can move, or remove it, as needed.
            this.industriasTableAdapter.Fill(this.progra3.industrias);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            industry.Descripcion = txtDescripcion.Text;

            DataRow registro = this.progra3.industrias.NewRow();
            registro["descripcion"] = industry.Descripcion;

            this.progra3.industrias.Rows.Add(registro);
            this.industriasTableAdapter.Update(this.progra3.industrias);
            this.dgvIndustrias.Refresh();
        }

        private void btnAgregar_Enter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            industry.Id_Industria = int.Parse(txtID.Text);
            industry.Descripcion = txtDescripcion.Text;

            DataRow registro = progra3.industrias.FindByid_industria(industry.Id_Industria);
            registro["descripcion"] = industry.Descripcion;

            this.industriasTableAdapter.Update(this.progra3.industrias);
            this.industriasTableAdapter.Fill(this.progra3.industrias);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            industry.Id_Industria = int.Parse(txtID.Text);
            DataRow registro = progra3.industrias.FindByid_industria(industry.Id_Industria);
            registro.Delete();
            this.industriasTableAdapter.Update(this.progra3.industrias);

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
                industry.Id_Industria = int.Parse(txtID.Text);

                DataRow registro = progra3.industrias.FindByid_industria(industry.Id_Industria);
                industry.Descripcion = registro["descripcion"].ToString();
                txtDescripcion.Text = industry.Descripcion;
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
                industry.Id_Industria = int.Parse(txtID.Text);

                DataRow registro = progra3.industrias.FindByid_industria(industry.Id_Industria);
                industry.Descripcion = registro["descripcion"].ToString();
                txtDescripcion.Text = industry.Descripcion;
            }
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
    }
}
