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
    public partial class frmCalculadora : Form
    {

        calcular calc = new calcular();

        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "1";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                calc.Operador = "dividir";
                txtPantalla.Text = "";
                txtTempHist.Text += "%";
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "0";
            txtTempHist.Text += "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "1";
            txtTempHist.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "2";
            txtTempHist.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "3";
            txtTempHist.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "4";
            txtTempHist.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "5";
            txtTempHist.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "6";
            txtTempHist.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "7";
            txtTempHist.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "8";
            txtTempHist.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "9";
            txtTempHist.Text += "9";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ".";
            txtTempHist.Text += ".";
        }

        private void btnStartOver_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "";
            txtTempHist.Text = "";
            calc.Operando1 = 0;
            calc.Operando1 = 0;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                calc.Operador = "sumar";
                txtPantalla.Text = "";
                txtTempHist.Text += "+";
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            try
            {
                if (calc.Operador == "sumar")
                {
                    if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                    {
                        txtPantalla.Text = "0";
                    }
                    double op2 = Convert.ToDouble(txtPantalla.Text);
                    calc.Operando2 = op2;
                    calc.UltimaRespuesta = calc.sumar();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    txtTempHist.Text += "=" + calc.UltimaRespuesta.ToString();
                }
                else if (calc.Operador == "restar")
                {
                    if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                    {
                        txtPantalla.Text = "0";
                    }
                    double op2 = Convert.ToDouble(txtPantalla.Text);
                    calc.Operando2 = op2; 
                    calc.UltimaRespuesta = calc.restar();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    txtTempHist.Text += "=" + calc.UltimaRespuesta.ToString();
                }
                else if (calc.Operador == "multiplicar")
                {
                    if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                    {
                        txtPantalla.Text = "1";
                    }
                    double op2 = Convert.ToDouble(txtPantalla.Text);
                    calc.Operando2 = op2;
                    calc.UltimaRespuesta = calc.multiplicar();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    txtTempHist.Text += "=" + calc.UltimaRespuesta.ToString();
                }
                else if (calc.Operador == "dividir")
                {
                    if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                    {
                        txtPantalla.Text = "1";
                    }
                    else if (txtPantalla.Text == "0")
                    {
                        txtPantalla.Text = "No es permitido division entre 0";
                    }
                    double op2 = Convert.ToDouble(txtPantalla.Text);
                    calc.Operando2 = op2;
                    calc.UltimaRespuesta = calc.dividir();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    txtTempHist.Text += "=" + calc.UltimaRespuesta.ToString();
                }
                else if (calc.Operador == "potencia")
                {
                    if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                    {
                        txtPantalla.Text = "0";
                    }
                    double op2 = Convert.ToDouble(txtPantalla.Text);
                    calc.Operando2 = op2;
                    calc.UltimaRespuesta = calc.potencia();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    txtTempHist.Text += "=" + calc.UltimaRespuesta.ToString();
                }else if (calc.Operador == "raiz")
                {
                    if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                    {
                        txtPantalla.Text = "0";
                    }
                    double op2 = Convert.ToDouble(txtPantalla.Text);
                    calc.Operando2 = op2;
                    calc.UltimaRespuesta = calc.raizNum();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    txtTempHist.Text += "=" + calc.UltimaRespuesta.ToString();
                }
                else
                {
                    txtPantalla.Text = "Syntax Error";
                }
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                calc.Operador = "restar";
                txtPantalla.Text = "";
                txtTempHist.Text += "-";
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "1";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                calc.Operador = "multiplicar";
                txtPantalla.Text = "";
                txtTempHist.Text += "*";
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnNegativo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text += "-";
                    txtTempHist.Text += "-";
                }
                else
                {
                    double operadorTemporal = Convert.ToDouble(txtPantalla.Text);

                    if (operadorTemporal > 0)
                    {
                        operadorTemporal -= (operadorTemporal * 2);
                        txtPantalla.Text = Convert.ToString(operadorTemporal);
                        txtTempHist.Text = Convert.ToString(operadorTemporal);
                    }
                    else
                    {
                        operadorTemporal += (Math.Abs(operadorTemporal) * 2);
                        txtPantalla.Text = Convert.ToString(operadorTemporal);
                        txtTempHist.Text = Convert.ToString(operadorTemporal);
                    }
                }
                
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void txtPantalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                txtPantalla.Text = txtPantalla.Text.Substring(0, (txtPantalla.Text.Length - 1));
                txtTempHist.Text = txtTempHist.Text.Substring(0, (txtTempHist.Text.Length - 1));
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnParenthesisLeft_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "(";
        }

        private void btnParenthesisRight_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ")";
        }

        private void btnMultiplicar_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void frmCalculadora_KeyPress(object sender, KeyPressEventArgs e)
        {
   
        }

        private void txtPantalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    btn0.PerformClick();
                    break;
                case '1':
                    btn1.PerformClick();
                    break;
                case '2':
                    btn2.PerformClick();
                    break;
                case '3':
                    btn3.PerformClick();
                    break;
                case '4':
                    btn4.PerformClick();
                    break;
                case '5':
                    btn5.PerformClick();
                    break;
                case '6':
                    btn6.PerformClick();
                    break;
                case '7':
                    btn7.PerformClick();
                    break;
                case '8':
                    btn8.PerformClick();
                    break;
                case '9':
                    btn9.PerformClick();
                    break;
                case '+':
                    btnSumar.PerformClick();
                    break;
                case '-':
                    btnRestar.PerformClick();
                    break;
                case '*':
                    btnMultiplicar.PerformClick();
                    break;
                case '/':
                case '%':
                    btnDividir.PerformClick();
                    break;
                case '=':
                    btnIgual.PerformClick();
                    break;
                case '.':
                    btnPunto.PerformClick();
                    break;
                case '±':
                    btnPositivoNegativo.PerformClick();
                    break;
                case '^':
                    btnPotencia.PerformClick();
                    break;
                default:
                    break;
            }
        }

        private void txtPantalla_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                btnDelete.PerformClick();
            }else if (e.KeyCode == Keys.Enter)
            {
                btnIgual.PerformClick();
            }
        }

        private void btnValorAbsoluto_Click(object sender, EventArgs e)
        {
            double valorAbsoluto = Math.Abs(Convert.ToDouble(txtPantalla.Text));
            txtPantalla.Text = Convert.ToString(valorAbsoluto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double eValor = 2.71828;

        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = calc.UltimaRespuesta.ToString();
            txtTempHist.Text = calc.UltimaRespuesta.ToString();
        }

        private void btnPotencia_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                calc.Operador = "potencia";
                txtPantalla.Text = "";
                txtTempHist.Text += "^";
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                txtTempHist.Text += "!";
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = 1;
                while (calc.Operando1 >= 1)
                {
                    calc.UltimaRespuesta *= calc.Operando1;
                    calc.Operando1--;
                }
                txtPantalla.Text = Convert.ToString(calc.UltimaRespuesta);
                txtTempHist.Text += "=" + Convert.ToString(calc.UltimaRespuesta);
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnRaizCuadrada_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                txtTempHist.Text = "√" + txtTempHist.Text;
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                calc.UltimaRespuesta = calc.raizCuadrada();
                txtPantalla.Text = Convert.ToString(calc.UltimaRespuesta);
                txtTempHist.Text += "=" + Convert.ToString(calc.UltimaRespuesta);
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                txtTempHist.Text = "³√" + txtTempHist.Text;
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                calc.Operando2 = 3;
                calc.UltimaRespuesta = calc.raizNum();
                txtPantalla.Text = Convert.ToString(calc.UltimaRespuesta);
                txtTempHist.Text += "=" + Convert.ToString(calc.UltimaRespuesta);
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            try
            {
                txtPantalla.Text += Convert.ToString(Math.PI);
                txtTempHist.Text += "π";
            }
            catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                calc.UltimaRespuesta = Convert.ToDouble(txtPantalla.Text);
                calc.Operando2 = 10;
                txtTempHist.Text = "log " + txtPantalla.Text;
                calc.UltimaRespuesta = calc.logNum();
                txtPantalla.Text = Convert.ToString(calc.UltimaRespuesta);
                txtTempHist.Text += Convert.ToString(calc.UltimaRespuesta);
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnRaizX_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                txtTempHist.Text = txtPantalla.Text + "^ⁿ√";
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1; 
                calc.Operador = "raiz";
                txtPantalla.Text = "";
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            try
            {
                calc.UltimaRespuesta = Convert.ToDouble(txtPantalla.Text);
                txtTempHist.Text = "ln " + txtPantalla.Text;
                calc.Operando2 = Math.E;
                calc.UltimaRespuesta = calc.logNum();
                txtPantalla.Text = Convert.ToString(calc.UltimaRespuesta);
                txtTempHist.Text += Convert.ToString(calc.UltimaRespuesta);
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btn10x_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = 10;
                calc.Operador = "potencia";
                txtPantalla.Text = "";
                txtTempHist.Text += "10^";
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = Math.E;
                calc.Operador = "potencia";
                txtPantalla.Text = "";
                txtTempHist.Text += "e^";
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnFact_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.factorial().ToString();
                txtTempHist.Text += "! = " + calc.factorial().ToString();
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnHyperbola_Click(object sender, EventArgs e)
        {

        }

        private void btnSeno_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.sin().ToString();
                txtTempHist.Text += "sin" + op1 + "=" + calc.factorial().ToString();
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnCosine_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.cos().ToString();
                txtTempHist.Text += "cos" + op1 + "=" + calc.cos().ToString();
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnTangent_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.tan().ToString();
                txtTempHist.Text += "tan" + op1 + "=" + calc.tan().ToString();
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnSinInverse_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.asin().ToString();
                txtTempHist.Text += "sin^-1" + op1 + "=" + txtPantalla.Text;
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnCosInverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.acos().ToString();
                txtTempHist.Text += "cos^-1" + op1 + "=" + txtPantalla.Text;
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnTanInverse_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.atan().ToString();
                txtTempHist.Text += "tan^-1" + op1 + "=" + txtPantalla.Text;
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnHyperSin_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.sinh().ToString();
                txtTempHist.Text += "sinh" + op1 + "=" + txtPantalla.Text;
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnHyperCos_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.cosh().ToString();
                txtTempHist.Text += "cosh" + op1 + "=" + txtPantalla.Text;
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnHyperTan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "" || txtPantalla.Text == " ")
                {
                    txtPantalla.Text = "0";
                }
                double op1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = op1;
                txtPantalla.Text = calc.tanh().ToString();
                txtTempHist.Text += "tanh" + op1 + "=" + txtPantalla.Text;
            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void txtTempHist_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEuler_Click(object sender, EventArgs e)
        {
            try
            {
                txtPantalla.Text += Convert.ToString(Math.E);
                txtTempHist.Text += "π";
            }
            catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }
    }
}
