using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class cajero
    {
        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private int contador = 0;
        public int Contador
        {
            get { return contador; }
            set { contador = value; }
        }

        public string pasarCliente()
        {
            contador++;
            contadorClientesBanco.contadorGeneral++;
            return colaBancoClientes.dequeueCola() + "-->" + nombre;
        }
    }
}
