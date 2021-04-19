using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class cola
    {
        Queue<int> fila = new Queue<int>();
        public Queue<int> Fila { get; set; }

        int valorTemp;
        public int ValorTemp { get; set; }

        string contenido;
        public string Contenido { get; set; }

        public string iteracionCola()
        {
            contenido = "";
            foreach (int item in fila)
            {
                contenido += "==> " + item + "\r\n";
            }
            return contenido;
        }

        public void enqueueCola(int num)
        {
            fila.Enqueue(num);
        }

        public int peekCola()
        {
            return fila.Peek();
        }

        public int dequeueCola()
        {
            return fila.Dequeue();
        }

        public int countCola()
        {
            return fila.Count();
        }

        public void clearCola()
        {
            fila.Clear();
        }
    }
}
