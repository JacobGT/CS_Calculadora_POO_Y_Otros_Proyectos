using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class servicios
    { 
        private int contador = 1;

        public void agregarCola(string abreviacion)
        {
            colaBancoClientes.enqueueCola(abreviacion + this.contador.ToString());
            this.contador++;
        }
        
    }
}
