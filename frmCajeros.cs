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
    public partial class frmCajeros : Form
    {
        cajero caj1 = new cajero();
        cajero caj2 = new cajero();
        cajero caj3 = new cajero();
        cajero caj4 = new cajero();
        cajero caj5 = new cajero();
        cajero caj6 = new cajero();

        public frmCajeros()
        {
            InitializeComponent();
            nombrar();
        }

        public void nombrar()
        {
            caj1.Nombre = "C1";
            caj2.Nombre = "C2";
            caj3.Nombre = "C3";
            caj4.Nombre = "C4";
            caj5.Nombre = "C5";
            caj6.Nombre = "C6";
        }

        private void btnC1_Click(object sender, EventArgs e)
        {
            listaBancoClientes.addLista(caj1.pasarCliente());
            lblC1.Text = caj1.Contador.ToString();
        }

        private void btnC2_Click(object sender, EventArgs e)
        {
            listaBancoClientes.addLista(caj2.pasarCliente());
            lblC2.Text = caj2.Contador.ToString();
        }

        private void btnC3_Click(object sender, EventArgs e)
        {
            listaBancoClientes.addLista(caj3.pasarCliente());
            lblC3.Text = caj3.Contador.ToString();
        }

        private void btnC4_Click(object sender, EventArgs e)
        {
            listaBancoClientes.addLista(caj4.pasarCliente());
            lblC4.Text = caj4.Contador.ToString();
        }

        private void btnC5_Click(object sender, EventArgs e)
        {
            listaBancoClientes.addLista(caj5.pasarCliente());
            lblC5.Text = caj5.Contador.ToString();
        }

        private void btnC6_Click(object sender, EventArgs e)
        {
            listaBancoClientes.addLista(caj6.pasarCliente());
            lblC6.Text = caj6.Contador.ToString();
        }
    }
}
