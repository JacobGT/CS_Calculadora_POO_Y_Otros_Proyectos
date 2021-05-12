using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    static class listaBancoClientes
    {
        static List<string> lista = new List<string>();

        public static List<string> Lista { get; set; }

        public static string iteracion;
        public static string Iteracion { get; set; }
        public static string iteracionLista()
        {
            iteracion = "";
            foreach (string item in lista)
            {
                iteracion += " ==> " + item + "\r\n";
            }
            return iteracion;
        }

        public static void addLista(string value)
        {
            lista.Add(value);
        }

        public static int countLista()
        {
            return lista.Count();
        }

        public static bool containsLista(string value)
        {
            return lista.Contains<string>(value);
        }

        public static int indexOfLista(string value)
        {
            return lista.IndexOf(value);
        }

        public static void insertLista(int numA, string valor)
        {
            lista.Insert(numA, valor);
        }

        public static void removeAtLista(int num)
        {
            lista.RemoveAt(num);
        }

        public static void removeLista(string value)
        {
            lista.Remove(value);
        }

        public static void reverseLista()
        {
            lista.Reverse();
        }

        public static void sortLista()
        {
            lista.Sort();
        }

        public static void clearLista()
        {
            lista.Clear();
        }
    }
}
