using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class catedratico : empleado
    {
        private string curso;
        public catedratico(double horaExtra) :base(horaExtra)
        {
            this.curso = "Ingeniería en Sistemas";
            TazaHoraExtra = horaExtra;
        }


        public string Curso
        {
            get
            {
                return this.curso;
            }
            set
            {
                this.curso = value;
            }
        }

        public string escribirMiNombre(string Nombre)
        {
            return "Catedratico: " + Nombre;
        }

        public string escribirMiNombre(string Nombre, string Apellido)
        {
            return "Catedratico: " + Nombre + " " + Apellido;
        }

        // Pense que era necesario implementar esto en la clase catedratico, pero segun las instrucciones, solo 
        // en la clase empleado y que se refleje en el objejeto profesor
        /*public string contestarLlamadas()
        {
            return "Buenos días, soy el catedratico. ¿Con quien tengo el gusto?";
        }*/

        public string Saludar()
        {
            return "Bienvenidos jovenes, les habla su catedratico.";
        }

        public string DarNota(String nota)
        {
            return "Tu nota es: " + nota;
        }
    }
}
