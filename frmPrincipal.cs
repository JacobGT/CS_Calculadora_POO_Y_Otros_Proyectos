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

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMarca marca = new frmMarca();
            marca.MdiParent = this;
            marca.Show();
        }

        private void fibonacciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFibonacci fib = new frmFibonacci();
            fib.MdiParent = this;
            fib.Show();
        }

        private void factorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFactorial factorial = new frmFactorial();
            factorial.MdiParent = this;
            factorial.Show();
        }

        private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModelo model = new frmModelo();
            model.MdiParent = this;
            model.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProducto producto = new frmProducto();
            producto.MdiParent = this;
            producto.Show();
        }

        private void parcial2MantenimientoListasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tablaClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes clientes = new frmClientes();
            clientes.MdiParent = this;
            clientes.Show();
        }

        private void ejemploIngresarYVisualizarListasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListas lists = new frmListas();
            lists.MdiParent = this;
            lists.Show();
        }

        private void tablaDeContactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmContacto contact = new frmContacto();
            contact.MdiParent = this;
            contact.Show();
        }

        private void tablaDepartamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartamento department = new frmDepartamento();
            department.MdiParent = this;
            department.Show();
        }

        private void tablaMunicipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMunicipios muni = new frmMunicipios();
            muni.MdiParent = this;
            muni.Show();
        }

        private void tablaIndustriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIndustrias industry = new frmIndustrias();
            industry.MdiParent = this;
            industry.Show();
        }

        private void cREDITOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCredito credit = new frmCredito();
            credit.MdiParent = this;
            credit.Show();
        }

        private void pilasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPilas stack = new frmPilas();
            stack.MdiParent = this;
            stack.Show();
        }

        private void colasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCola queue = new frmCola();
            queue.MdiParent = this;
            queue.Show();
        }

        private void listsV2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmList lista = new frmList();
            lista.MdiParent = this;
            lista.Show();
        }
    }
}
