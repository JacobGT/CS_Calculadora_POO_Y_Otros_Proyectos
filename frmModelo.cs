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
    public partial class frmModelo : Form
    {
        public frmModelo()
        {
            InitializeComponent();
        }

        private void frmModelo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'progra3.marca' table. You can move, or remove it, as needed.
            this.marcaTableAdapter.Fill(this.progra3.marca);
            // TODO: This line of code loads data into the 'progra3.modelo' table. You can move, or remove it, as needed.
            this.modeloTableAdapter.Fill(this.progra3.modelo);

        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            this.modeloTableAdapter.Update(this.progra3.modelo);
            this.modeloTableAdapter.Fill(this.progra3.modelo);
        }
    }
}
