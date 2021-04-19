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
    public partial class frmCola : Form
    {
        cola queue = new cola();
        frmColaImagenEjemplo frmEjemplo = new frmColaImagenEjemplo();
        public frmCola()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmEjemplo.Show();
        }

        private void frmCola_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void btnEnqueue_Click(object sender, EventArgs e)
        {
            queue.ValorTemp = int.Parse(txtDato.Text);
            queue.enqueueCola(queue.ValorTemp);
            txtMostrar.Text = "Elemento agregado a la Cola";
        }

        private void btnPeek_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Muestra el primer elemento introducido al Queue";
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            queue.ValorTemp = queue.countCola();
            txtMostrar.Text = queue.ValorTemp.ToString();
        }

        private void btnIterar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = queue.iteracionCola();
        }

        private void btnIterar_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Itera los elementos adentro del Queue para visualizarlos.";
        }

        private void btnDequeue_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Eliminar el primer elemento ingresado en el Queue.";
        }

        private void btnDequeue_Click(object sender, EventArgs e)
        {
            queue.ValorTemp = queue.dequeueCola();
            txtMostrar.Text = "Elemento eliminado del Queue: " + queue.ValorTemp.ToString();
        }

        private void btnCount_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Muestra cuantos elementos existen en el Queue.";
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Elimina todos los elementos existentes en el Queue.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            queue.clearCola();
            txtMostrar.Text = "Cola borrada.";
        }

        private void btnEnqueue_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Agrega elementos al Queue.";
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            queue.ValorTemp = queue.peekCola();
            txtMostrar.Text = queue.ValorTemp.ToString();
        }
    }
}
