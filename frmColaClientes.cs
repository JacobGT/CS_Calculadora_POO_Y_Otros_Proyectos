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
    public partial class frmColaClientes : Form
    {
        //bool stop = false;

        public frmColaClientes()
        {
            InitializeComponent();
            txtCola.Text = colaBancoClientes.iteracionCola();
            //actualizar();
            refresh()
;        }


        /*public void actualizar()
        {
            DateTime tiempo = DateTime.Now + TimeSpan.FromSeconds(5);

            do 
            {
                txtCola.Text = "";
                txtCola.Text = colaBancoClientes.iteracionCola();
            } 
            while (DateTime.Now < tiempo && stop==false);
        }*/

        public async void refresh()
        {
            while (true)
            {
                txtCola.Text = colaBancoClientes.iteracionCola();
                try
                {
                    //Thread.Sleep(5000);
                    await Task.Delay(500);
                } catch (Exception)
                {

                }
                
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbSync_Click(object sender, EventArgs e)
        {
            txtCola.Text = "";
            txtCola.Text = colaBancoClientes.iteracionCola();
            /*if (btnbSync.Text == "⟲ Sync: ON")
            {
                btnbSync.Text = "⟲ Sync: OFF";
                stop = true;
            }
            else
            {
                btnbSync.Text = "⟲ Sync: ON";
                stop = false;
                actualizar();
            }*/
        }
    }
}
