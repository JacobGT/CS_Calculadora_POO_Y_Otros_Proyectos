using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra3
{
    class alumno : persona
    {
        private string carrera, curso;
        private int zona, parcial1, parcial2, final;

        public string Carrera
        {
            get
            {
                return this.carrera;
            }
            set
            {
                this.carrera = value;
            }
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

        public int Zona
        {
            get
            {
                return this.zona;
            }
            set
            {
                this.zona = value;
            }
        }

        public int Parcial1
        {
            get
            {
                return this.parcial1;
            }
            set
            {
                this.parcial1 = value;
            }
        }

        public int Parcial2
        {
            get
            {
                return this.parcial2;
            }
            set
            {
                this.parcial2 = value;
            }
        }

        public int Final
        {
            get
            {
                return this.final;
            }
            set
            {
                this.final = value;
            }
        }

        public double calcularNotaFinal()
        {
            return (this.zona + this.parcial1 + this.parcial2 + this.final) / 4;

        }
    }
}
