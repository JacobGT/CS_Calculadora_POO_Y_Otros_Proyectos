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

    }
}
