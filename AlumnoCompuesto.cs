
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_7
{
    public class AlumnoCompuesto: IAlumno
    {
        private List<IAlumno> hijos;

        public AlumnoCompuesto() {
            hijos = new List<IAlumno>();
        }

        public void agregarHijos(IAlumno a)
        {
            this.hijos.Add(a);
        }

        public string getNombre()
        {
            string nombres = " ";
            foreach (IAlumno hijo in hijos)
            {
                nombres += hijo.getNombre() + "\n";
            }

            return nombres;
        }
        public void setNombre(string n) {
            throw new NotImplementedException();
        }
        public int getDni() { throw new NotImplementedException();  }
        public void setDni(int d) { throw new NotImplementedException(); }
        public int getLegajo() { throw new NotImplementedException(); }
        public void setLegajo(int l) { throw new NotImplementedException(); }
        public int getPromedio() { throw new NotImplementedException(); }
        public void setPromedio(int p) { throw new NotImplementedException(); }
        public void setCalificacion(int c)
        {
            foreach (IAlumno hijo in hijos)
            {
                hijo.setCalificacion(c);
            }
        }
        public int getCalificacion() { throw new NotImplementedException(); }
        public void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia) { throw new NotImplementedException(); }

        public void prestandoAtencion() { throw new NotImplementedException(); }
        public void distraerse() { throw new NotImplementedException(); }
        public void actualizar(Observado o) { throw new NotImplementedException(); }
        public int responderPregunta(int pregunta)
        {
            if (hijos.Count == 0 || hijos == null)
            {
                throw new InvalidOperationException("No hay alumnos hijos.");
            }

            int respuesta;
            int respuestaMasVotada = 0;
            //Para contar los votos, voy a implementar un diccionario
            Dictionary<int, int> respuestas = new Dictionary<int, int>();

            foreach (IAlumno hijo in hijos)
            {
                respuesta = hijo.responderPregunta(pregunta);
                if (respuestas.ContainsKey(respuesta))
                {
                    respuestas[respuesta]++;   
                }
            }

            foreach (var elem in respuestas)
            {
                if (elem.Value > respuestaMasVotada)
                {
                    respuestaMasVotada = elem.Value;
                }
            }

            return respuestaMasVotada;
        }
        public string mostrarCalificacion()
        {
            string calificacion = " ";
            foreach (IAlumno hijo in hijos)
            {
                calificacion += hijo.getCalificacion() + "\n";
            }
            return calificacion;
        }

        public bool sosIgual(Comparable c)
        {
            foreach (IAlumno hijo in hijos)
            {
                if (hijo.sosIgual(c))
                {
                    return true;
                }
            }
            return false;
        }

        public bool sosMenor(Comparable c)
        {
            int contador = 0;

            foreach (IAlumno hijo in hijos)
            {
                if (hijo.sosMenor(c))
                {
                    contador++;
                }
            }
            if(contador == hijos.Count) { return true;  }
            return false;
        }
        public bool sosMayor(Comparable c)
        {
            int contador = 0;

            foreach (IAlumno hijo in hijos)
            {
                if (hijo.sosMayor(c))
                {
                    contador++;
                }
            }
            if (contador == hijos.Count) { return true; }
            return false;
        }
        public string toString()
        {
            throw new NotImplementedException();
        }
    }
}
