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
    public partial class frmListas : Form
    {
        public frmListas()
        {
            InitializeComponent();
        }

        private Lista list = new Lista();

        private void btnInsertarNodo_Click(object sender, EventArgs e)
        {
            list.InstertarNodo(int.Parse(txtValor.Text));
            txtValor.Text = "";
        }

        private void btnMostrarLista_Click(object sender, EventArgs e)
        {
            txtMostrarLista.Text = list.Mostrar();
        }
    }
}
