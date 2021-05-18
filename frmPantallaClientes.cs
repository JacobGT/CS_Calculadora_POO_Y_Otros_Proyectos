using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Progra3
{
    public partial class frmPantallaClientes : Form
    {
        public frmPantallaClientes()
        {
            InitializeComponent();
            refresh();
        }

        public async void refresh()
        {
            while (true)
            {
                txtPantalla.Text = listaBancoClientes.iteracionLista();
                txtContador.Text = contadorClientesBanco.contadorGeneral.ToString();
                try
                {
                    await Task.Delay(500);
                }
                catch (Exception)
                {

                }

            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = listaBancoClientes.iteracionLista();
            txtContador.Text = contadorClientesBanco.contadorGeneral.ToString();

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            listaBancoClientes.clearLista();
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
