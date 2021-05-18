using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            try
            {
                colaBancoClientes.peekCola();
            } catch (Exception)
            {
                MessageBox.Show("No hay más clientes por atender.", "Cola vacía.");
                return null;
            }
            contador++;
            contadorClientesBanco.contadorGeneral++;
            return colaBancoClientes.dequeueCola() + "-->" + nombre;

        }
    }
}
