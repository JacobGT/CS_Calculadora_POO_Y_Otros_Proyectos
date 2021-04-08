using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Progra3
{
    public partial class frmClientes : Form
    {
        cliente client = new cliente();

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.departamentos' table. You can move, or remove it, as needed.
            this.departamentosTableAdapter.Fill(this.progra3.departamentos);
            // TODO: This line of code loads data into the 'progra3.industrias' table. You can move, or remove it, as needed.
            this.industriasTableAdapter.Fill(this.progra3.industrias);
            // TODO: This line of code loads data into the 'progra3.municipios' table. You can move, or remove it, as needed.
            this.municipiosTableAdapter.Fill(this.progra3.municipios);
            // TODO: This line of code loads data into the 'progra3.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.progra3.clientes);

        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            if(txtID.Text != "")
            {
                DataRow registro = progra3.clientes.FindByid_cliente(int.Parse(txtID.Text));
                txtDescripcion.Text = registro["descripcion_cliente"].ToString();
                txtDireccion.Text = registro["direccion"].ToString();
                txtTelefono.Text = registro["telefono"].ToString();
                comboMunicipio.SelectedValue = int.Parse(registro["id_municipio"].ToString());
                comboDepartamento.SelectedValue = int.Parse(registro["id_departamento"].ToString());
                comboIndustria.SelectedValue = int.Parse(registro["id_industria"].ToString());
                txtCredito.Text = registro["credito"].ToString();
                txtDiasCredito.Text = registro["dias_credito"].ToString();
                if ((bool)registro["estado"])
                {
                    checkEstado.Checked = true;
                }
                else
                {
                    checkEstado.Checked = false;
                }
            }
                    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataRow registro = this.progra3.clientes.NewRow();
            registro["descripcion_cliente"] = txtDescripcion.Text;
            registro["direccion"] = txtDireccion.Text;
            registro["telefono"] = txtTelefono.Text;
            registro["id_municipio"] = comboMunicipio.SelectedValue.ToString();
            registro["id_departamento"] = comboDepartamento.SelectedValue.ToString();
            registro["id_industria"] = comboIndustria.SelectedValue.ToString();
            registro["credito"] = txtCredito.Text;
            registro["dias_credito"] = txtDiasCredito.Text;
            bool estado = true;
            if (checkEstado.Checked != true)
            {
                estado = false;
            }
            registro["estado"] = estado;

            this.progra3.clientes.Rows.Add(registro);
            this.clientesTableAdapter.Update(this.progra3.clientes);
            this.dgvClientes.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataRow registro = progra3.clientes.FindByid_cliente(int.Parse(txtID.Text));
            registro["descripcion_cliente"] = txtDescripcion.Text;
            registro["direccion"] = txtDireccion.Text;
            registro["telefono"] = txtTelefono.Text;
            registro["id_municipio"] = comboMunicipio.SelectedValue.ToString();
            registro["id_departamento"] = comboDepartamento.SelectedValue.ToString();
            registro["id_industria"] = comboIndustria.SelectedValue.ToString();
            registro["credito"] = txtCredito.Text;
            registro["dias_credito"] = txtDiasCredito.Text;
            bool estado = true;
            if (checkEstado.Checked != true)
            {
                estado = false;
            }
            registro["estado"] = estado;


            this.clientesTableAdapter.Update(this.progra3.clientes);
            this.clientesTableAdapter.Fill(this.progra3.clientes);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRow registro = progra3.clientes.FindByid_cliente(int.Parse(txtID.Text));
            registro.Delete();
            this.clientesTableAdapter.Update(this.progra3.clientes);

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
                DataRow registro = progra3.clientes.FindByid_cliente(int.Parse(txtID.Text));
                txtDescripcion.Text = registro["descripcion_cliente"].ToString();
                txtDireccion.Text = registro["direccion"].ToString();
                txtTelefono.Text = registro["telefono"].ToString();
                comboMunicipio.SelectedValue = int.Parse(registro["id_municipio"].ToString());
                comboDepartamento.SelectedValue = int.Parse(registro["id_departamento"].ToString());
                comboIndustria.SelectedValue = int.Parse(registro["id_industria"].ToString());
                txtCredito.Text = registro["credito"].ToString();
                txtDiasCredito.Text = registro["dias_credito"].ToString();
                if ((bool)registro["estado"])
                {
                    checkEstado.Checked = true;
                }
                else
                {
                    checkEstado.Checked = false;
                }
            }
        }
    }
}
