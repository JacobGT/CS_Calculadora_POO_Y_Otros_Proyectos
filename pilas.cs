using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class pilas
    {
        // Se puede utilizar cualquier tipo de objeto en una pila
        Stack<int> pila = new Stack<int>();
        public Stack<int> Pila { get; set; }

        int valorTempo;

        string contenido;

        public string Contenido { get; set; }

        public int ValorTempo { get; set; }

        public string iteracionPila()
        {
            contenido = "";
            foreach (int item in pila)
            {
                contenido += "==> " + item + "\r\n";
            }
            return contenido;
        }

        public void pushPila(int num)
        {
            pila.Push(num);
        }

        public int popPila()
        {
            return pila.Pop();
        }

        public int peekPila()
        {
            return pila.Peek();
        }

        public int countPila()
        {
            return pila.Count();
        }

        public void clearPila()
        {
            pila.Clear();
        }

    }
}
