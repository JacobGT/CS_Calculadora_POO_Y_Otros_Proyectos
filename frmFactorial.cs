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
    public partial class frmFactorial : Form
    {
        public frmFactorial()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (numFact.Text == "")
            {
                numFact.Text = "0";
            }

            double num = Convert.ToDouble(numFact.Text);
            for (double i=num-1; i>=1; i--)
            {
                num *= i;
            }

            txtResultado.Text = num.ToString();
        }

        public double factorial(double num)
        {
            if (num == 0)
            {
                return 1;
            }
            else
            {
                return (num * factorial(num - 1));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (numFact.Text == "")
            {
                numFact.Text = "0";
            }

            double num = Convert.ToDouble(numFact.Text);
            double respuesta = factorial(num);
            txtResultado.Text = respuesta.ToString();
        }
    }
}
