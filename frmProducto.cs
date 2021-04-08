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
    public partial class frmProducto : Form
    {

        //public static string ccCadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source='C:\\Users\\jacob\\Progra\\USPG\\C#\\Progra3\\bin\\Debug\\progra3.mdb'";
        public static string ccCadenaConexion = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jacob\Progra\USPG\C#\Progra3\bin\Debug\progra3.mdb";
        public OleDbConnection cnProducto = new OleDbConnection(ccCadenaConexion);

        public frmProducto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.progra3.modelo);
            // TODO: This line of code loads data into the 'progra3.marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.progra3.marca);
            // TODO: This line of code loads data into the 'progra3.producto' table. You can move, or remove it, as needed.
            this.productoTableAdapter.Fill(this.progra3.producto);

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            OleDbCommand cmdProducto = new OleDbCommand();
            if(txtIdProducto.Text == "")
            {
                cmdProducto.CommandText = "insert into producto (descripcion,id_marca,id_modelo,estado_registro) values (@descripcion,@id_marca,@id_modelo,@estado_registro)";
            }
            else
            {
                cmdProducto.CommandText = "update producto set descripcion=@descripcion,id_marca=@id_marca,id_modelo=@id_modelo,estado_registro=@estado_registro where id_producto=@id_producto";
                cmdProducto.Parameters.AddWithValue("@id_producto", int.Parse(txtIdProducto.Text));
                // No actualiza
            }

            bool estado = true;
            if(checkEstado.Checked != true)
            {
                estado = false;
            }

            /*cmdProducto.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
            cmdProducto.Parameters.AddWithValue("@id_marca", comboMarca.SelectedValue.ToString());
            cmdProducto.Parameters.AddWithValue("@id_modelo", comboModelo.SelectedValue.ToString());
            cmdProducto.Parameters.AddWithValue("@estado_registro", estado);*/

            cmdProducto.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
            cmdProducto.Parameters.AddWithValue("@id_marca", comboMarca.SelectedValue.ToString());
            cmdProducto.Parameters.AddWithValue("@id_modelo", comboModelo.SelectedValue.ToString());
            cmdProducto.Parameters.AddWithValue("@estado_registro", estado);
            if (txtIdProducto.Text != "")
            {
                cmdProducto.Parameters.AddWithValue("@id_producto", txtIdProducto.Text);
            }

            cmdProducto.Connection = cnProducto;
            cnProducto.Open();
            cmdProducto.ExecuteNonQuery();
            cnProducto.Close();

            this.productoTableAdapter.Fill(this.progra3.producto);
        }

        private void txtIdProducto_Leave(object sender, EventArgs e)
        {
            if(txtIdProducto.Text != "")
            {
                OleDbCommand cmdProducto = new OleDbCommand();
                cmdProducto.CommandText = "select * from producto where id_producto = @id_producto";
                cmdProducto.Parameters.AddWithValue("@id_producto", int.Parse(txtIdProducto.Text));
                cmdProducto.Connection = cnProducto;
                cnProducto.Open();

                OleDbDataReader drProducto = cmdProducto.ExecuteReader();
                while(drProducto.Read())
                {
                    txtDescripcion.Text = drProducto[1].ToString();
                    comboMarca.SelectedValue = int.Parse(drProducto[2].ToString());

                    Console.WriteLine(int.Parse(drProducto[2].ToString()));
                    Console.WriteLine(drProducto[2].ToString());
                    Console.WriteLine(drProducto[2]);

                    comboModelo.SelectedValue = int.Parse(drProducto[3].ToString());
                    if((bool)drProducto[4])
                    {
                        checkEstado.Checked = true;
                    }
                    else
                    {
                        checkEstado.Checked = false;
                    }
                }
                cnProducto.Close();
                drProducto.Close();

                this.productoTableAdapter.Fill(this.progra3.producto);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtIdProducto.Text != "")
            {
                OleDbCommand cmdProducto = new OleDbCommand();
                cmdProducto.CommandText = "delete from producto where id_producto = @id_producto";
                cmdProducto.Parameters.AddWithValue("@id_producto", int.Parse(txtIdProducto.Text));
                cmdProducto.Connection = cnProducto;
                cnProducto.Open();
                cmdProducto.ExecuteNonQuery();
                cnProducto.Close();
                this.productoTableAdapter.Fill(this.progra3.producto);
            }
        }
    }
}
