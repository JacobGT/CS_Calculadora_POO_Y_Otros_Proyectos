using System;
using System.IO;
using System.Globalization;
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
                client.Id_Cliente = int.Parse(txtID.Text);

                DataRow registro = progra3.clientes.FindByid_cliente(client.Id_Cliente);
                client.Descripcion_Cliente = registro["descripcion_cliente"].ToString();
                client.Direccion = registro["direccion"].ToString();
                client.Telefono = registro["telefono"].ToString();
                client.Id_Municipio = int.Parse(registro["id_municipio"].ToString());
                client.Id_Departamento = int.Parse(registro["id_departamento"].ToString());
                client.Id_Industria = int.Parse(registro["id_industria"].ToString());
                client.Credito = int.Parse(registro["credito"].ToString());
                client.Dias_Credito = (registro["dias_credito"].ToString());
                if ((bool)registro["estado"])
                {
                    client.Estado = true;
                }
                else
                {
                    client.Estado = false;
                }

                txtDescripcion.Text = client.Descripcion_Cliente;
                txtDireccion.Text = client.Direccion;
                txtTelefono.Text = client.Telefono;
                comboMunicipio.SelectedValue = client.Id_Municipio;
                comboDepartamento.SelectedValue = client.Id_Departamento;
                comboIndustria.SelectedValue = client.Id_Industria;
                txtCredito.Text = client.Credito.ToString();
                dtpDiasCredito.Value = DateTime.ParseExact(client.Dias_Credito, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                checkEstado.Checked = client.Estado;


            }
                    
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            client.Descripcion_Cliente = txtDescripcion.Text;
            client.Direccion = txtDireccion.Text;
            client.Telefono = txtTelefono.Text;
            client.Id_Municipio = int.Parse(comboMunicipio.SelectedValue.ToString());
            client.Id_Departamento = int.Parse(comboDepartamento.SelectedValue.ToString());
            client.Id_Industria = int.Parse(comboIndustria.SelectedValue.ToString());
            client.Credito = int.Parse(txtCredito.Text);
            client.Dias_Credito = dtpDiasCredito.Value.ToString("dd/MM/yyyy");
            client.Estado = checkEstado.Checked;

            DataRow registro = this.progra3.clientes.NewRow();
            registro["descripcion_cliente"] = client.Descripcion_Cliente;
            registro["direccion"] = client.Direccion;
            registro["telefono"] = client.Telefono;
            registro["id_municipio"] = client.Id_Municipio;
            registro["id_departamento"] = client.Id_Departamento;
            registro["id_industria"] = client.Id_Industria;
            registro["credito"] = client.Credito;
            registro["dias_credito"] = client.Dias_Credito;
            registro["estado"] = client.Estado;

            this.progra3.clientes.Rows.Add(registro);
            this.clientesTableAdapter.Update(this.progra3.clientes);
            this.dgvClientes.Refresh();

            
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            client.Id_Cliente = int.Parse(txtID.Text);
            client.Descripcion_Cliente = txtDescripcion.Text;
            client.Direccion = txtDireccion.Text;
            client.Telefono = txtTelefono.Text;
            client.Id_Municipio = int.Parse(comboMunicipio.SelectedValue.ToString());
            client.Id_Departamento = int.Parse(comboDepartamento.SelectedValue.ToString());
            client.Id_Industria = int.Parse(comboIndustria.SelectedValue.ToString());
            client.Credito = int.Parse(txtCredito.Text);
            client.Dias_Credito = dtpDiasCredito.Value.ToString("dd/MM/yyyy");
            client.Estado = checkEstado.Checked;

            DataRow registro = progra3.clientes.FindByid_cliente(client.Id_Cliente);
            registro["descripcion_cliente"] = client.Descripcion_Cliente;
            registro["direccion"] = client.Direccion;
            registro["telefono"] = client.Telefono;
            registro["id_municipio"] = client.Id_Municipio;
            registro["id_departamento"] = client.Id_Departamento;
            registro["id_industria"] = client.Id_Industria;
            registro["credito"] = client.Credito;
            registro["dias_credito"] = client.Dias_Credito;
            registro["estado"] = client.Estado;


            this.clientesTableAdapter.Update(this.progra3.clientes);
            this.clientesTableAdapter.Fill(this.progra3.clientes);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            client.Id_Cliente = int.Parse(txtID.Text);
            DataRow registro = progra3.clientes.FindByid_cliente(client.Id_Cliente);
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
                /*DataRow registro = progra3.clientes.FindByid_cliente(int.Parse(txtID.Text));
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
                }*/

                client.Id_Cliente = int.Parse(txtID.Text);

                DataRow registro = progra3.clientes.FindByid_cliente(client.Id_Cliente);
                client.Descripcion_Cliente = registro["descripcion_cliente"].ToString();
                client.Direccion = registro["direccion"].ToString();
                client.Telefono = registro["telefono"].ToString();
                client.Id_Municipio = int.Parse(registro["id_municipio"].ToString());
                client.Id_Departamento = int.Parse(registro["id_departamento"].ToString());
                client.Id_Industria = int.Parse(registro["id_industria"].ToString());
                client.Credito = int.Parse(registro["credito"].ToString());
                client.Dias_Credito = (registro["dias_credito"].ToString());
                if ((bool)registro["estado"])
                {
                    client.Estado = true;
                }
                else
                {
                    client.Estado = false;
                }

                txtDescripcion.Text = client.Descripcion_Cliente;
                txtDireccion.Text = client.Direccion;
                txtTelefono.Text = client.Telefono;
                comboMunicipio.SelectedValue = client.Id_Municipio;
                comboDepartamento.SelectedValue = client.Id_Departamento;
                comboIndustria.SelectedValue = client.Id_Industria;
                txtCredito.Text = client.Credito.ToString();
                dtpDiasCredito.Value = DateTime.ParseExact(client.Dias_Credito, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                checkEstado.Checked = client.Estado;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            txtID.Text = "";
        }
    }
}
