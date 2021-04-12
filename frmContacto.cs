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
    public partial class frmContacto : Form
    {
        contacto contact = new contacto();
        public frmContacto()
        {
            InitializeComponent();
        }

        private void frmContacto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.clientes' table. You can move, or remove it, as needed.
            this.clientesTableAdapter.Fill(this.progra3.clientes);
            // TODO: This line of code loads data into the 'progra3.contactos' table. You can move, or remove it, as needed.
            this.contactosTableAdapter.Fill(this.progra3.contactos);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            contact.Id_Cliente = int.Parse(comboIdCliente.SelectedValue.ToString());
            contact.Nombre_Cliente = txtNombreContacto.Text;
            contact.Correo = txtCorreo.Text;
            contact.Telefono = txtTelefono.Text;

            DataRow registro = this.progra3.contactos.NewRow();
            registro["id_cliente"] = contact.Id_Cliente;
            registro["nombre_contacto"] = contact.Nombre_Cliente;
            registro["correo"] = contact.Correo;
            registro["telefono"] = contact.Telefono;

            this.progra3.contactos.Rows.Add(registro);
            this.contactosTableAdapter.Update(this.progra3.contactos);
            this.dgvContacto.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            contact.Id_Contacto = int.Parse(txtIdContacto.Text);
            contact.Id_Cliente = int.Parse(comboIdCliente.SelectedValue.ToString());
            contact.Nombre_Cliente = txtNombreContacto.Text;
            contact.Correo = txtCorreo.Text;
            contact.Telefono = txtTelefono.Text;

            DataRow registro = progra3.contactos.FindByid_contacto(contact.Id_Contacto);
            registro["id_cliente"] = contact.Id_Cliente;
            registro["nombre_contacto"] = contact.Nombre_Cliente;
            registro["correo"] = contact.Correo;
            registro["telefono"] = contact.Telefono;

            this.contactosTableAdapter.Update(this.progra3.contactos);
            this.contactosTableAdapter.Fill(this.progra3.contactos);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            contact.Id_Contacto = int.Parse(txtIdContacto.Text);
            DataRow registro = progra3.contactos.FindByid_contacto(contact.Id_Contacto);
            registro.Delete();
            this.contactosTableAdapter.Update(this.progra3.contactos);
        }

        private void btnBuscarContacto_Click(object sender, EventArgs e)
        {
            if (txtIdContacto.Text != "")
            {
                contact.Id_Contacto = int.Parse(txtIdContacto.Text);

                DataRow registro = progra3.contactos.FindByid_contacto(contact.Id_Contacto);
                contact.Id_Cliente = int.Parse(registro["id_cliente"].ToString());
                contact.Nombre_Cliente = registro["nombre_contacto"].ToString();
                contact.Correo = registro["correo"].ToString();
                contact.Telefono = registro["telefono"].ToString();

                txtIdContacto.Text = contact.Id_Contacto.ToString();
                comboIdCliente.SelectedValue = contact.Id_Cliente;
                txtNombreContacto.Text = contact.Nombre_Cliente;
                txtCorreo.Text = contact.Correo;
                txtTelefono.Text = contact.Telefono;

            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
        
        }

        private void txtIdContacto_Leave(object sender, EventArgs e)
        {
            if (txtIdContacto.Text != "")
            {
                contact.Id_Contacto = int.Parse(txtIdContacto.Text);

                DataRow registro = progra3.contactos.FindByid_contacto(contact.Id_Contacto);
                contact.Id_Cliente = int.Parse(registro["id_cliente"].ToString());
                contact.Nombre_Cliente = registro["nombre_contacto"].ToString();
                contact.Correo = registro["correo"].ToString();
                contact.Telefono = registro["telefono"].ToString();

                txtIdContacto.Text = contact.Id_Contacto.ToString();
                comboIdCliente.SelectedValue = contact.Id_Cliente;
                txtNombreContacto.Text = contact.Nombre_Cliente;
                txtCorreo.Text = contact.Correo;
                txtTelefono.Text = contact.Telefono;
            }
        }

        private void btnAgregar_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_MouseEnter(object sender, EventArgs e)
        {
            txtIdContacto.Text = "";
        }
    }
}
