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
    public partial class frmPilas : Form
    {
        pilas stack = new pilas();
        frmPilaImagenEjemplo frmEjemplo = new frmPilaImagenEjemplo();

        public frmPilas()
        {
            InitializeComponent();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            frmEjemplo.Show();
        }

        private void btnPush_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Metodo que introduce elementos al Stack";
        }

        private void btnPush_Click(object sender, EventArgs e)
        {
            stack.ValorTempo = int.Parse(txtDato.Text);
            stack.pushPila(stack.ValorTempo);
            txtMostrar.Text = "Elemento ingresado a la pila";
        }

        private void btnPop_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Saca el elemento que se encuentra hasta arriba del Stack.";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            stack.ValorTempo = stack.popPila();
            txtMostrar.Text = "Elemento sacado: " + stack.ValorTempo.ToString();
        }

        private void btnIterar_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = stack.iteracionPila();
        }

        private void btnPeek_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Visualiza el primer elemento del Stack sin sacarlo del Stack.";
        }

        private void btnCount_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Indica la cantidad de elementos que tiene el Stack.";
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            stack.ValorTempo = stack.peekPila();
            txtMostrar.Text = stack.ValorTempo.ToString();
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            stack.ValorTempo = stack.countPila();
            txtMostrar.Text = stack.ValorTempo.ToString();
        }

        private void btnClear_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Elimina todos los elementos del Stack.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            stack.clearPila();
            txtMostrar.Text = "";
            txtDato.Text = "";
        }

        private void btnIterar_MouseEnter(object sender, EventArgs e)
        {
            lblInfo.Text = "Iteramos el Stack para ver su contenido.";
        }
    }
}
