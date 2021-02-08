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
                txtPantalla.Text += "/";
                txtTempHist.Text += "/";
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
            txtGrafica.Text = "";
            calc.Operando1 = 0;
            calc.Operando1 = 0;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPantalla.Text += "+";
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
                calc.Expresion = txtPantalla.Text;
                calc.UltimaRespuesta = calc.igual();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
            } catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
            
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            try
            {
                txtPantalla.Text += "-";
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
                txtPantalla.Text += "*";
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
                    calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                    calc.UltimaRespuesta = calc.Operando1;
                    txtPantalla.Text = Convert.ToString(calc.masMenos());
                    txtTempHist.Text = Convert.ToString(calc.masMenos());
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
            txtTempHist.Text += "(";
        }

        private void btnParenthesisRight_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ")";
            txtTempHist.Text += ")";

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
                case '!':
                    btnFactorial.PerformClick();
                    break;
                case '(':
                    btnParenthesisLeft.PerformClick();
                    break;
                case ')':
                    btnParenthesisRight.PerformClick();
                    break;
                case 'e':
                    btnEuler.PerformClick();
                    break;
                case 'π':
                    btnPi.PerformClick();
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
            try
            {
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.valorAbs();
                txtPantalla.Text = Convert.ToString(calc.UltimaRespuesta);
                txtTempHist.Text += "|" + calc.Operando1.ToString() + "| = " + txtPantalla.Text;
            }catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {

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
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                txtPantalla.Text = "";
                txtTempHist.Text += "^";
                txtGrafica.Text = calc.Operando1.ToString() + "^";
                btnOk.Enabled = true;
                btnOk.ForeColor = Color.Red;
                btnIgual.Enabled = false;
                calc.Operacion = "potencia";
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
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                txtTempHist.Text = "√" + txtTempHist.Text;
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
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
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                txtTempHist.Text = "³√" + txtTempHist.Text;
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
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
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
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
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando2 = Convert.ToDouble(txtPantalla.Text);
                txtPantalla.Text = "";
                txtTempHist.Text += "^√";
                txtGrafica.Text = calc.Operando2.ToString() + "^√";
                btnOk.Enabled = true;
                btnOk.ForeColor = Color.Red;
                btnIgual.Enabled = false;
                calc.Operacion = "raiz";
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
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
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
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = 10;
                calc.Operando2 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.potencia();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text += "10^" + calc.Operando2.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando2 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando1 = Math.E;
                calc.UltimaRespuesta = calc.potencia();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text += "e^" + calc.Operando2.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.sin();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "sin" + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.cos();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "cos" + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.tan();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "tan" + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.asin();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "sin^-1 " + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.acos();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "cos^-1 " + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.atan();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "tan^-1 " + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.sinh();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "sinh" + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.cosh();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "cosh" + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.UltimaRespuesta = calc.tanh();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();
                txtTempHist.Text = "tanh" + calc.Operando1.ToString() + "=" + txtPantalla.Text;
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
                txtTempHist.Text += "e";
            }
            catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (calc.Operacion == "potencia")
                {
                    calc.Operando2 = Convert.ToDouble(txtPantalla.Text);
                    calc.UltimaRespuesta = calc.potencia();
                    txtGrafica.Text += calc.Operando2.ToString() + "=" + calc.UltimaRespuesta.ToString();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    btnOk.Enabled = false;
                    btnOk.ForeColor = Color.White;
                    btnIgual.Enabled = true;
                    btnClear.Enabled = true;
                } else if (calc.Operacion == "raiz")
                {
                    calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                    calc.UltimaRespuesta = calc.raizNum();
                    txtGrafica.Text += calc.Operando1.ToString() + "=" + calc.UltimaRespuesta.ToString();
                    txtPantalla.Text = calc.UltimaRespuesta.ToString();
                    btnOk.Enabled = false;
                    btnOk.ForeColor = Color.White;
                    btnIgual.Enabled = true;
                    btnClear.Enabled = true;
                }
                


            }
            catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }


        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando2 = 2;
                txtTempHist.Text += "^2";
                calc.UltimaRespuesta = calc.potencia();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();

            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }

        }

        private void btnCubo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando2 = 3;
                txtTempHist.Text += "^3";
                calc.UltimaRespuesta = calc.potencia();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();

            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            try
            {
                if (txtPantalla.Text == "")
                {
                    txtPantalla.Text = "0";
                }
                calc.Operando1 = Convert.ToDouble(txtPantalla.Text);
                calc.Operando2 = -1;
                txtTempHist.Text += "^-1";
                calc.UltimaRespuesta = calc.potencia();
                txtPantalla.Text = calc.UltimaRespuesta.ToString();

            }
            catch (Exception error)
            {
                txtPantalla.Text = Convert.ToString(error);
            }
        }

        private void btnGrafica_Click(object sender, EventArgs e)
        {
            btnX.Enabled = true;
            btnY.Enabled = true;
            btnOk.Enabled = true;
            txtGrafica.Text = txtPantalla.Text;
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                txtPantalla.Text += "x";
                txtTempHist.Text += "x";
                txtGrafica.Text += "x";
            } catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
            
        }

        private void btnY_Click(object sender, EventArgs e)
        {
            try
            {
                txtPantalla.Text += "y";
                txtTempHist.Text += "y";
                txtGrafica.Text += "y";
            }
            catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGrafica.Text = "";
            btnClear.Enabled = false;
        }
    }
}
