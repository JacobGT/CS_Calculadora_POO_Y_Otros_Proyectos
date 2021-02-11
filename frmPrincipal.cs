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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sumar2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSumar sum = new frmSumar();
            sum.MdiParent = this;
            sum.Show();
        }

        private void restar2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRestar rest = new frmRestar();
            rest.MdiParent = this;
            rest.Show();
        }

        private void multiplicar2NumerosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void calculadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCalculadora calculadora = new frmCalculadora();
            calculadora.MdiParent = this;
            calculadora.Show();
        }

        private void herenciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void catedraticoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCatedratico profe = new frmCatedratico();
            profe.MdiParent = this;
            profe.Show();
        }

        private void graficadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void ejemplosDePOOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
