using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Es muy importante importar la libreria de abajo, para que funcionen los metodos de los charts.
using System.Windows.Forms.DataVisualization.Charting;


namespace Progra3
{
    public partial class frmCalculadora : Form
    {

        calcular calc = new calcular();
        graficar graf = new graficar();

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
            try
            {
                txtPantalla.Text = "";
                txtTempHist.Text = "";
                txtGrafica.Text = "";
                btnFuncX.Enabled = true;
                btnX.Enabled = true;
                calc.Operando1 = 0;
                calc.Operando1 = 0;
                lblVar.Text = "";
                for (int i = 0; i < graf.NumFunc; i++)
                {
                    chart1.Series[i].Points.Clear();
                }
            } catch (Exception error)
            {
            }
            
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
                case 'x':
                    btnX.PerformClick();
                    break;
                case ',':
                    btnComa.PerformClick();
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
            try
            {
                // Mostramos como funciona la graficadora y los requerimientos
                MessageBox.Show("Para que la gráficadora funcione, la equacion TIENE" +
                    "\n que estár de esta forma:" +
                    "\n x + n = y   O   y + n = x" +
                    "\n f(x) = x    O   f(y)=y", "Instrucciones", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                // Cambiamos de tamaño la calculadora para que se puedan ver lo elementos necesarios para graficar
                this.Size = new Size(1000, 700);
                // Desactivamos botones que provoquen posibles errores y los que no vayamos a ultilizar
                // Y activamos los que si utilizaremos
                btnOk.Enabled = true;
                btnPotencia.Enabled = false;
                btnCuadrado.Enabled = false;
                btnCubo.Enabled = false;
                btnIgual.Enabled = false;
                btnGrafCuadrado.Enabled = false;
                //btnGrafCubo.Enabled = false;
                btnGraf.Enabled = false;
                btnGraficarLinea.Enabled = false;
                btnGraficarPunto.Enabled = false;
            } catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
            

        }

        private void btnX_Click(object sender, EventArgs e)
        {
            try
            {
                btnGrafCuadrado.Enabled = false;
                txtPantalla.Text += "x";
                txtTempHist.Text += "x";
                graf.SinPotencia = true;
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
                graf.SinPotencia = true;
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

        private void btnFuncX_Click(object sender, EventArgs e)
        {
            lblVar.Text = "= y";
            btnGrafCuadrado.Enabled = true;
            //btnGrafCubo.Enabled = true;
            btnGraficarLinea.Enabled = true;
            btnGraficarPunto.Enabled = true;
            btnX.Enabled = true;
        }

        private void btnFuncY_Click(object sender, EventArgs e)
        {
            lblVar.Text = "= y";
            btnFuncX.Enabled = false;
            btnGrafCuadrado.Enabled = true;
            //btnGrafCubo.Enabled = true;
            btnGraficarLinea.Enabled = true;
            btnGraficarPunto.Enabled = true;
        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void btnCloseGraf_Click(object sender, EventArgs e)
        {
            this.Size = new Size(400, 700);
            lblVar.Text = "";
            btnOk.Enabled = false;
            btnPotencia.Enabled = true;
            btnCuadrado.Enabled = true;
            btnCubo.Enabled = true;
            btnIgual.Enabled = true;
            btnGrafCuadrado.Enabled = true;
            btnGraf.Enabled = true;
            btnGraficarLinea.Enabled = false;
            btnGraficarPunto.Enabled = false;

        }

        private void btnGrafCuadrado_Click(object sender, EventArgs e)
        {
            btnX.Enabled = false;
            txtPantalla.Text += "x**2";
            graf.Cuadrado = true;
            
        }

        private void btnGrafCubo_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += "x**3";
            graf.Cuadrado = true;
        }

        private void btnGraficarLinea_Click(object sender, EventArgs e)
        {
            try
            {
                string seriesName1 = "f" + graf.NumFunc;
                Series ecuacion = chart1.Series.Add(seriesName1);

                ecuacion.ChartArea = chart1.ChartAreas[0].Name;
                ecuacion.Name = seriesName1;
                ecuacion.ChartType = SeriesChartType.Line;

                graf.Funcion = txtPantalla.Text;
                if (txtPrueba1.Text == "")
                {
                    graf.Pruebas[0] = 0.0;
                }
                else
                {
                    graf.Pruebas[0] = Convert.ToDouble(txtPrueba1.Text);
                }
                if (txtPrueba2.Text == "")
                {
                    graf.Pruebas[1] = 1.0;
                }
                else
                {
                    graf.Pruebas[1] = Convert.ToDouble(txtPrueba2.Text);
                }
                if (txtPrueba3.Text == "")
                {
                    graf.Pruebas[2] = 2.0;
                }
                else
                {
                    graf.Pruebas[2] = Convert.ToDouble(txtPrueba3.Text);
                }
                if (txtPrueba4.Text == "")
                {
                    graf.Pruebas[3] = 3.0;
                }
                else
                {
                    graf.Pruebas[3] = Convert.ToDouble(txtPrueba4.Text);
                }
                if (txtPrueba5.Text == "")
                {
                    graf.Pruebas[4] = 4.0;
                }
                else
                {
                    graf.Pruebas[4] = Convert.ToDouble(txtPrueba5.Text);
                }



                if (graf.SinPotencia == true)
                {
                    graf.Solucion = graf.graficarLineaX();
                    graf.SinPotencia = false;
                }
                if (graf.Cuadrado == true)
                {
                    graf.Solucion = graf.graficarLineaXCuadrado();
                    graf.Cuadrado = false;
                }
                if (graf.Cubo == true)
                {
                    graf.Solucion = graf.graficarLineaXCubo();
                    graf.Cubo = false;
                }


                lblPrueba1.Text = "= " + graf.Solucion[0].ToString();
                lblPrueba2.Text = "= " + graf.Solucion[1].ToString();
                lblPrueba3.Text = "= " + graf.Solucion[2].ToString();
                lblPrueba4.Text = "= " + graf.Solucion[3].ToString();
                lblPrueba5.Text = "= " + graf.Solucion[4].ToString();

                chart1.ChartAreas[0].AxisX.Title = "x";
                chart1.ChartAreas[0].AxisY.Title = "y";
                for (int i = 0; i < 5; i++)
                {
                    chart1.Series["f" + graf.NumFunc.ToString()].Points.AddXY(graf.Pruebas[i], graf.Solucion[i]);
                }
                graf.NumFunc++;
            }
            catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }

        }

        private void btnGraficarPunto_Click(object sender, EventArgs e)
        {
            try
            {
                string seriesName2 = "pt" + graf.NumPuntos;
                Series punto = chart1.Series.Add(seriesName2);

                punto.ChartArea = chart1.ChartAreas[0].Name;
                punto.Name = seriesName2;
                punto.ChartType = SeriesChartType.Point;

                graf.Expresion = txtPantalla.Text;
                graf.Punto = graf.graficarPunto();
                chart1.Series["pt" + graf.NumPuntos].Points.AddXY(graf.Punto[0], graf.Punto[1]);
                graf.NumPuntos++;
            }
            catch (Exception error)
            {
                txtPantalla.Text = error.ToString();
            }
        }

        private void btnComa_Click(object sender, EventArgs e)
        {
            txtPantalla.Text += ",";
            txtTempHist.Text += ",";
        }
    }
}
