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
        // otra solucion es cambiar el acces modifier por un protected en lugar de hacer sus getters y setters
        private double tazaHoraExtra = 0;

        public empleado(double horaExtra)
        {
            tazaHoraExtra = horaExtra;
        }

        public double TazaHoraExtra
        {
            get
            {
                return this.tazaHoraExtra;
            }
            set
            {
                this.tazaHoraExtra = value;
            }
        }

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
            return this.sueldo/30 * tazaHoraExtra;

        }

        public string escribirMiNombre(string Nombre)
        {
            return "Hola, mi nombre de empleado es" + Nombre;
        }

        public string contestarLlamadas()
        {
            return "Hola, soy un empleado... ¿Quien habla y como le puedo ayudar?";
        }
    }
}
