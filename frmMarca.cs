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
    public partial class frmMarca : Form
    {
        public frmMarca()
        {
            InitializeComponent();
        }

        private void dgvMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.progra3.marca);

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataRow registro = progra3.Tables[1].NewRow(); // en lugar de llamar por valor numerico podemos llamarlo con su nombre con this.baseDeDatos.Tabla
            registro["descripcion"] = txtIngresarDescripcion.Text;
            progra3.Tables[1].Rows.Add(registro);
            this.marcaTableAdapter.Update(this.progra3.marca);
            this.dgvMarcas.Refresh();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            DataRow registro = progra3.marca.FindByID_marca(int.Parse(txtIdMod.Text));
            registro["descripcion"] = txtModDescripcion.Text;
            this.marcaTableAdapter.Update(this.progra3.marca);
            this.marcaTableAdapter.Fill(this.progra3.marca);
        }

        private void txtIdMod_Leave(object sender, EventArgs e)
        {
            DataRow registro = progra3.marca.FindByID_marca(int.Parse(txtIdMod.Text)); // Esta es una opcion
            // DataRow registro = progra3.Tables[1].find(txtIdMod.Text); Esta es la otra
            txtModDescripcion.Text = registro["descripcion"].ToString();
        }

        private void txtIdEliminar_Leave(object sender, EventArgs e)
        {
            DataRow registro = progra3.marca.FindByID_marca(int.Parse(txtIdEliminar.Text));
            txtEliminarDescripcion.Text = registro["descripcion"].ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DataRow registro = progra3.marca.FindByID_marca(int.Parse(txtIdEliminar.Text));
            registro.Delete();
            this.marcaTableAdapter.Update(this.progra3.marca);

            txtEliminarDescripcion.Text = "Elemento Eliminado de la Base de Datos Correctamente.";
            txtIdEliminar.Text = "";
        }
    }
}
