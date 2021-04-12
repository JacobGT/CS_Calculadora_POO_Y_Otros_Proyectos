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
    public partial class frmMunicipios : Form
    {

        municipios muni = new municipios();

        public frmMunicipios()
        {
            InitializeComponent();
        }

        private void frmMunicipios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.progra3.departamentos);
            // TODO: This line of code loads data into the 'progra3.municipios' table. You can move, or remove it, as needed.
            this.municipiosTableAdapter.Fill(this.progra3.municipios);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            muni.Descripcion = txtDescripcion.Text;
            muni.Id_Departamento = int.Parse(comboIdDepartamento.SelectedValue.ToString());

            DataRow registro = this.progra3.municipios.NewRow();
            registro["descripcion"] = muni.Descripcion;
            registro["id_departamento"] = muni.Id_Departamento;

            this.progra3.municipios.Rows.Add(registro);
            this.municipiosTableAdapter.Update(this.progra3.municipios);
            this.dgvMunicipios.Refresh();
        }

        private void btnAgregar_Enter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            muni.Id_Municipio = int.Parse(txtID.Text);
            muni.Descripcion = txtDescripcion.Text;
            muni.Id_Departamento = int.Parse(comboIdDepartamento.SelectedValue.ToString());

            DataRow registro = progra3.municipios.FindByid_municipio(muni.Id_Municipio);
            registro["descripcion"] = muni.Descripcion;
            registro["id_departamento"] = muni.Id_Departamento;

            this.municipiosTableAdapter.Update(this.progra3.municipios);
            this.municipiosTableAdapter.Fill(this.progra3.municipios);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            muni.Id_Municipio = int.Parse(txtID.Text);
            DataRow registro = progra3.municipios.FindByid_municipio(muni.Id_Municipio);
            registro.Delete();
            this.municipiosTableAdapter.Update(this.progra3.municipios);

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
                muni.Id_Municipio = int.Parse(txtID.Text);

                DataRow registro = progra3.municipios.FindByid_municipio(muni.Id_Municipio);
                muni.Descripcion = registro["descripcion"].ToString();
                muni.Id_Departamento = int.Parse(registro["id_departamento"].ToString());
                txtDescripcion.Text = muni.Descripcion;
                comboIdDepartamento.SelectedValue = muni.Id_Departamento;
            }
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            btnBuscar.PerformClick();
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
    }
}
