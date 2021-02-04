using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class empleado : persona
    {
        private string profesion, puesto;
        private double sueldo;

        public string Profession
        {
            get
            {
                return this.profesion;
            }
            set
            {
                this.profesion = value;
            }
        }

        public string Puesto
        {
            get
            {
                return this.puesto;
            }
            set
            {
                this.puesto = value;
            }
        }

        public double Sueldo
        {
            get
            {
                return this.sueldo;
            }
            set
            {
                this.sueldo = value;
            }
        }

        public double calcularIgss()
        {
            // No se como calcular el IGSS
            if (this.sueldo <= 4000)
            {
                return this.sueldo * .04;
            } else
            {
                return this.sueldo * .06;
            }
        }
        
        public double calcularHoraExtra()
        {
            return this.sueldo/30 * 1.5;

        }
    }
}
