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
    public partial class frmFibonacci : Form
    {
        public frmFibonacci()
        {
            InitializeComponent();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "0";
            }

            double num = Convert.ToDouble(txtNumero.Text);

            if (num < 0)
            {
                txtResultado.Text = "No se pueden usar numeros negativos.";
            }
            else if (num == 0)
            {
                txtResultado.Text = "0";
            }
            else if (num == 1 || num == 2)
            {
                txtResultado.Text = "1";
            }
            else
            {
                double num1 = 1;
                double num2 = 1;
                double respuesta = 0;

                for(int i = 1; i<(num-1); i++)
                {
                    respuesta = num1 + num2;
                    num1 = num2;
                    num2 = respuesta;
                }
                txtResultado.Text = respuesta.ToString();
            }
        }

        public double fibonacci(double num)
        {
            /*if (num == 0)
            {
                return 0;
            }
            else if (num == 1 || num == 2)
            {
                return 1;
            }*/

            if (num <= 1)
            {
                return num;
            }
            else
            {
                return fibonacci(num - 1) + fibonacci(num - 2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNumero.Text == "")
            {
                txtNumero.Text = "0";
            }

            double num = Convert.ToDouble(txtNumero.Text);

            if (num < 0)
            {
                txtResultado.Text = "No se pueden usar numeros negativos.";
            }
            else
            {
                double respuesta = fibonacci(num);
                txtResultado.Text = respuesta.ToString();
            }
        }
    }
}
