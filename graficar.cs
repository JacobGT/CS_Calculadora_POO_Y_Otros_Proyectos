using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace Progra3
{
    class graficar : calcular
    {
        private double[] solucion = new double[5];
        private double[] pruebas = new double[5];
        private string[] punto = new string[2];
        private int numFunc = 1;
        private int numPuntos = 1;
        private bool cuadrado = false;
        private bool cubo = false;
        private bool sinPotencia = false;
        // Usaremos el atributo heredado "expresion" para saber la funcion
        private string funcion;
        // y el atributo heredado "operacion" como operador bandera

        public string Funcion
        {
            get
            {
                return this.funcion;
            }
            set
            {
                this.funcion = value;
            }
        }

        public bool Cuadrado
        {
            get
            {
                return this.cuadrado;
            }
            set
            {
                this.cuadrado = value;
            }
        }

        public bool SinPotencia
        {
            get
            {
                return this.sinPotencia;
            }
            set
            {
                this.sinPotencia = value;
            }
        }

        public bool Cubo
        {
            get
            {
                return this.cubo;
            }
            set
            {
                this.cubo = value;
            }
        }

        public double[] Solucion
        {
            get
            {
                return this.solucion;
            }
            set
            {
                this.solucion = value;
            }
        }

        public double[] Pruebas
        {
            get
            {
                return this.pruebas;
            }
            set
            {
                this.pruebas = value;
            }
        }

        public string[] Punto
        {
            get
            {
                return this.punto;
            }
            set
            {
                this.punto = value;
            }
        }

        public int NumFunc
        {
            get
            {
                return this.numFunc;
            }
            set
            {
                this.numFunc = value;
            }
        }

        public int NumPuntos
        {
            get
            {
                return this.numPuntos;
            }
            set
            {
                this.numPuntos = value;
            }
        }

        // El siguiente codigo no me funciono, y me daba valores repetidos así que lo dividí en varias partes
        // las cuales son los metodos abajo de esta funcion
        /*public double[] graficarLinea()
        {
            if (this.funcIgualX == false)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (this.sinPotencia == true)
                    {
                        this.Expresion = this.Funcion.Replace("x", "*" + Convert.ToString(this.Pruebas[i]));
                        this.Funcion = this.Expresion;
                    }
                    if (this.cuadrado == true)
                    {
                        this.Expresion = this.Funcion.Replace("x**2", "*" + Convert.ToString(this.Pruebas[i] * this.Pruebas[i]));
                        this.Funcion = this.Expresion;
                    }
                    if (this.cubo == true)
                    {
                        this.Expresion = this.Funcion.Replace("x**3", "*" + Convert.ToString(this.Pruebas[i] * this.Pruebas[i] * this.Pruebas[i]));
                        this.Funcion = this.Expresion;
                    }

                    this.solucion[i] = this.igual();
                }
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    if (this.sinPotencia == true)
                    {
                        this.Expresion = this.Funcion.Replace("y", "*" + Convert.ToString(this.Pruebas[i]));
                        this.Funcion = this.Expresion;
                    }
                    if (this.cuadrado == true)
                    {
                        this.Expresion = this.Funcion.Replace("y**2", "*" + Convert.ToString(this.Pruebas[i] * this.Pruebas[i]));
                        this.Funcion = this.Expresion;
                    }
                    if (this.cubo == true)
                    {
                        this.Expresion = this.Funcion.Replace("y**3", "*" + Convert.ToString(this.Pruebas[i] * this.Pruebas[i] * this.Pruebas[i]));
                        this.Funcion = this.Expresion;
                    }

                    this.solucion[i] = this.igual();
                }
            }
            return (solucion);
        }*/

        public double[] graficarLineaX()
        {
            for (int i = 0; i < 5; i++)
            {
                this.Expresion = this.Funcion.Replace("x", "*" + Convert.ToString(this.Pruebas[i]));
                this.solucion[i] = this.igual();
            }
            return solucion;
        }

        public double[] graficarLineaXCuadrado()
        {
            for (int i = 0; i < 5; i++)
            {
                this.Expresion = this.Funcion.Replace("x**2", "*" + Convert.ToString(this.Pruebas[i] * this.Pruebas[i]));
                this.solucion[i] = this.igual();
            }
            return solucion;
        }

        // No pude implementar x al cubo, ya que me daba un error:
        // System.Data.SyntaxErrorException: 'Syntax error: Missing operand after 'x' operator.'
        public double[] graficarLineaXCubo()
        {
            for (int i = 0; i < 5; i++)
            {
                this.Expresion = this.Funcion.Replace("x**3", "*" + Convert.ToString(Math.Pow(this.Pruebas[i], 3)));
                this.solucion[i] = this.igual();
            }
            return solucion;
        }

        public string[] graficarPunto()
        {
            this.punto = this.Expresion.Split(',');
            return this.punto;
        }
    }
}
