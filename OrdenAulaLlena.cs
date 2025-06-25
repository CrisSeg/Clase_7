using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class OrdenAulaLlena: OrdenEnAula1
    {
        private Aula aula;

        public OrdenAulaLlena(Aula aula)
        {
            this.aula = aula;
        }

        public void ejecutar()
        {
            aula.claseLista();
        }
    }
}
