using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class calcular
    {
        private double operando1 = 0, operando2 = 0, ultimaRespuesta = 0;
        private string expresion = "", operacion = "";

        public string Operacion
        {
            get
            {
                return this.operacion;
            }
            set
            {
                this.operacion = value;
            }
        }

        public string Expresion
        {
            get
            {
                return this.expresion;
            }
            set
            {
                this.expresion = value;
            }
        }

        public double Operando1
        {
            get
            {
                return this.operando1;
            }
            set
            {
                this.operando1 = value;
            }
        }

        public double Operando2
        {
            get
            {
                return this.operando2;
            }
            set
            {
                this.operando2 = value;
            }
        }

        public double UltimaRespuesta
        {
            get
            {
                return this.ultimaRespuesta;
            }
            set
            {
                this.ultimaRespuesta = value;
            }
        }

        public double sumar()
        {
            return this.Operando1 + this.Operando2;
        }

        public double restar()
        {
            return this.Operando1 - this.Operando2;
        }

        public double multiplicar()
        {
            return this.Operando1 * this.Operando2;
        }

        public double dividir()
        {
            return this.Operando1 / this.Operando2;
        }

        public double potencia()
        {
            return Math.Pow(this.operando1, this.operando2); 
        }

        public double raizCuadrada()
        {
            return Math.Sqrt(operando1);
        }

        public double raizNum()
        {
            return Math.Pow(operando1, 1.0 / operando2);
        }

        public double logNum()
        {
            return Math.Log(Operando1, Operando2);
        }

        public double valorAbs()
        {
            return Math.Abs(Convert.ToDouble(this.operando1));
        }

        public double factorial()
        {
            int fact = 1;
            for (int i = 1; i <= operando1; i++)
            {
                fact *= i;
            }
            return fact;
        }

        public double sin()
        {
            return Math.Sin((operando1 * (Math.PI)) / 180);
        }

        public double cos()
        {
            return Math.Cos((operando1 * (Math.PI)) / 180);
        }

        public double tan()
        {
            return Math.Tan((operando1 * (Math.PI)) / 180);
        }
        public double asin()
        {
            return (Math.Asin(operando1)) * (180/Math.PI);
        }
        public double acos()
        {
            return (Math.Acos(operando1)) * (180 / Math.PI);
        }
        public double atan()
        {
            return (Math.Atan(operando1)) * (180 / Math.PI);
        }
        public double sinh()
        {
            return Math.Sinh(operando1);
        }
        public double cosh()
        {
            return Math.Cosh(operando1);
        }
        public double tanh()
        {
            return Math.Tanh(operando1);
        }

        public double masMenos()
        {
            if (this.operando1 > 0)
            {
                operando1 -= (operando1 * 2);
                return operando1;
            }
            else
            {
                operando1 += (Math.Abs(operando1) * 2);
                return operando1;
            }
        }

        public double igual()
        {
            // DataTable es una estructura de datos que nos permite guardar informacion tabulada
            System.Data.DataTable table = new System.Data.DataTable();
            // Este es el quivalente al metodo .Eval() en python
            ultimaRespuesta = Convert.ToDouble(table.Compute(this.expresion.ToString(), String.Empty));
            // Y sirve como que si fueran operaciones en Excel
            return ultimaRespuesta;
        }
    }
}
