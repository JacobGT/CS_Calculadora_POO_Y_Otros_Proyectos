using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class Lista
    {
        private Nodo primero;
        private Nodo actual;

        public Lista() { }

        public bool ListaVacia()
        {
            if (primero == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InstertarNodo(int valor)
        {
            Nodo anterior;
            if (this.ListaVacia() == true)
            {
                primero = new Nodo(valor, primero);
            }
            else
            {
                anterior = primero;
                while (anterior.Nodo_Referencia != null)
                {
                    anterior = anterior.Nodo_Referencia;
                    anterior.Nodo_Referencia = new Nodo(valor, anterior.Nodo_Referencia);
                }
                actual = new Nodo(valor, null);
            }
        }
        public string Mostrar()
        {
            string valores = "";
            Nodo auxiliar;
            auxiliar = primero;
            while(auxiliar != null)
            {
                valores = valores + auxiliar.Dato.ToString() + " ==> ";
                auxiliar = auxiliar.Nodo_Referencia;
            }
            return valores;
        }
    }
}
