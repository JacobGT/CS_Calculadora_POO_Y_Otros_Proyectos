using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class cliente
    {
        private int id_cliente, id_municipio, id_departamento, id_industria, credito;
        private bool estado;
        private string descripcion_cliente, direccion, telefono, dias_credito;

        public int Id_Cliente { get; set; }
        public int Id_Municipio { get; set; }
        public int Id_Departamento { get; set; }
        public int Id_Industria { get; set; }
        public int Credito { get; set; }
        public string Dias_Credito { get; set; }

        public bool Estado { get; set; }
        public string Descripcion_Cliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

    }
}
