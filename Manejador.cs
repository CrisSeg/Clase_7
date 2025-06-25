using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public abstract class Manejador
    {
        private Manejador sucesor;

        public Manejador(Manejador sucesor) {
            this.sucesor = sucesor;
        }

        //Implemento la interface publica de los manejadores

        //interface del generarDatosAleatorios
        public virtual int numeroAleatorio(int max)
        {
            if (sucesor != null)
            {
                return sucesor.numeroAleatorio(max);
            }

            return 0;
        }
        public virtual string stringAleatorio(int cantidad)
        {
            if (sucesor != null)
            {
                return sucesor.stringAleatorio(cantidad);
            }

            return "";
        }

        //interface lectorDeDatos
        public virtual int numeroPorTeclado()
        {
            if (sucesor != null)
            {
                return sucesor.numeroPorTeclado();
            }

            return 0;
        }

        public virtual string stringPorTeclado()
        {
            if (sucesor != null)
            {
                return sucesor.stringPorTeclado();
            }

            return "";
        }

        //Interface ObtencionDeDatos
        public virtual double numeroDesdeArchivo(double max)
        {
            if(sucesor != null)
            {
                return sucesor.numeroDesdeArchivo(max);
            }

            return 0.0;
        }

        public virtual string stringDesdeArchivo(int cant)
        {
            if(sucesor != null)
            {
                return sucesor.stringDesdeArchivo(cant);
            }

            return "";
        }
    }
}
