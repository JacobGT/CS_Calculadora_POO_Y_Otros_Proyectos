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
    public partial class frmRestar : Form
    {
        public frmRestar()
        {
            InitializeComponent();
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            calcular calc = new calcular();
            if (txtOperando1.Text == "" || txtOperando1.Text == " ")
            {
                txtOperando1.Text = "0";
            }
            if (txtOperando2.Text == "" || txtOperando2.Text == " ")
            {
                txtOperando2.Text = "0";
            }
            double op1 = Convert.ToDouble(txtOperando1.Text);
            double op2 = double.Parse(txtOperando2.Text);
            calc.Operando1 = op1;
            calc.Operando2 = op2;
            txtResultado.Text = calc.restar().ToString();
            MessageBox.Show(calc.restar().ToString(), "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtOperando1.Text = "";
            txtOperando2.Text = "";
            txtResultado.Text = "";
        }
    }
}
