using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class credito : cliente
    {
        private int consumo, días_saltar;
        private string dias_restantes;

        public int Consumo { get; set; }

        public int Dias_Saltar { get; set; }

        public string Dias_Restantes { get; set; }

        public string fechaActual()
        {
            return DateTime.Now.ToString("dd/MM/yyyy");
        }

    }
}
