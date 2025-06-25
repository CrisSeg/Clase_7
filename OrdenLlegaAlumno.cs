using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class OrdenLlegaAlumno: OrdenEnAula2
    {
        private Aula aula;

        public OrdenLlegaAlumno(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar(Comparable c)
        {
            aula.nuevoAlumno((IAlumno)c);
        }
    }
}
