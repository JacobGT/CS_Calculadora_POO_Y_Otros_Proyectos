using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    static class colaBancoClientes
    {
        static Queue<string> fila = new Queue<string>();

        public static Queue<string> Fila { get; set; }

        static string valor;
        public static string  Valor { get; set; }

        static string contenido;
        public static string Contenido { get; set; }

        public static string iteracionCola()
        {
            contenido = "";
            int cont = 1;
            foreach (string item in fila)
            {
                contenido += cont.ToString() + " ==> " + item + "\r\n";
                cont++;
            }
            return contenido;
        }

        public static void enqueueCola(string value)
        {
            fila.Enqueue(value);
        }

        public static string peekCola()
        {
            return fila.Peek();
        }

        public static string dequeueCola()
        {
            return fila.Dequeue();
        }

        public static int countCola()
        {
            return fila.Count();
        }

        public static void clearCola()
        {
            fila.Clear();
        }
    }
}
