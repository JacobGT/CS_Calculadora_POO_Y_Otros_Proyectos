using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class Nodo
    {
        private int dato = 0; // Se puede poner cualquier dato y valor
        private Nodo nodo_referencia;

        public Nodo()
        {

        }
        public Nodo(int valor, Nodo referencia)
        {
            this.dato = valor;
            this.nodo_referencia = referencia;
        }

        public int Dato
        {
            get
            {
                return this.dato;
            }

            set
            {
                this.dato = value;
            }
        }

        public Nodo Nodo_Referencia
        {
            get
            {
                return this.nodo_referencia;
            }

            set
            {
                this.nodo_referencia = value;
            }
        }
    }
}
