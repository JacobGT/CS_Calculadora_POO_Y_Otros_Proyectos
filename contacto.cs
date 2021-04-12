using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class contacto
    {
        private int id_contacto, id_cliente;
        private string nombre_cliente, correo, telefono;

        public int Id_Contacto { get; set; }
        public int Id_Cliente { get; set; }

        public string Nombre_Cliente { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
    }
}
