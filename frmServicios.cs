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
    public partial class frmServicios : Form
    {
        servicios dmServicio = new servicios();
        servicios caServicio = new servicios();
        servicios tServicio = new servicios();
        servicios acServicio = new servicios();
        servicios tcServicio = new servicios();
        servicios psServicio = new servicios();

        public frmServicios()
        {
            InitializeComponent();
        }

        private void pb1_Click(object sender, EventArgs e)
        {
            acServicio.agregarCola("AC");
        }

        private void pb2_Click(object sender, EventArgs e)
        {
            tcServicio.agregarCola("TC");
        }

        private void pb3_Click(object sender, EventArgs e)
        {
            psServicio.agregarCola("PS");
        }

        private void pb4_Click(object sender, EventArgs e)
        {
            tServicio.agregarCola("T");
        }

        private void pb5_Click(object sender, EventArgs e)
        {
            caServicio.agregarCola("CA");
        }

        private void pb6_Click(object sender, EventArgs e)
        {
            dmServicio.agregarCola("DM");
        }
    }
}
