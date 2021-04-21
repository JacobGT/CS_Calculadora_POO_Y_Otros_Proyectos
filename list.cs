using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class list
    {
        List<int> lista = new List<int>();

        public List<int> Lista { get; set; }

        public string iteracion;
        public string Iteracion { get; set; }
        public string iteracionLista()
        {
            iteracion = "";
            foreach (int item in lista)
            {
                iteracion += "==> " + item + "\r\n";
            }
            return iteracion;
        }

        public void addLista(int num)
        {
            lista.Add(num);
        }

        public int countLista()
        {
            return lista.Count();
        }

        public bool containsLista(int num)
        {
            return lista.Contains<int>(num);
        }

        public int indexOfLista(int num)
        {
            return lista.IndexOf(num);
        }

        public void insertLista(int numA,int numB)
        {
            lista.Insert(numA, numB);
        }

        public void removeAtLista(int num)
        {
            lista.RemoveAt(num);
        }

        public void removeLista(int num)
        {
            lista.Remove(num);
        }

        public void reverseLista()
        {
            lista.Reverse();
        }

        public void sortLista()
        {
            lista.Sort();
        }

        public void clearLista()
        {
            lista.Clear();
        }
    }
}
