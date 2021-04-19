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
    public partial class frmColaImagenEjemplo : Form
    {
        public frmColaImagenEjemplo()
        {
            InitializeComponent();
        }

        private void frmColaImagenEjemplo_Load(object sender, EventArgs e)
        {

        }

        private void frmColaImagenEjemplo_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }
    }
}
