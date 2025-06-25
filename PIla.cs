using System;
using System.Collections.Generic;

namespace Clase_7
{
	public class Pila : Coleccionable, Iterable, Ordenable
	{

		List<Comparable> p;
		private OrdenEnAula1 ordenInicio, ordenAulaLlena;
		private OrdenEnAula2 ordenLlegaAlumno;
		public Pila()
		{
			this.p = new List<Comparable>();
		}
		
		public void apilar(Comparable c){
			this.p.Add(c);

            if (p.Count == 1 && ordenInicio != null)
			{
				ordenInicio.ejecutar();
			}
            if (ordenLlegaAlumno != null)
            {
                ordenLlegaAlumno.ejecutar(c);
            }
            if (p.Count == 40 && ordenAulaLlena != null)
            {
                ordenAulaLlena.ejecutar();
            }

        }
		
		public Comparable desApilar(){
			Comparable aux = this.p[p.Count-1];
			p.RemoveAt(p.Count-1);
			return aux;
		}
		
		public Comparable getElementos(int i){
			return this.p[i];
		}
		
		public int cuantos(){
			return this.p.Count;
		}
		public Comparable minimo(){
			Comparable min = this.p[0];
			
			for (int i = 1; i < p.Count; i++) {
				if (this.p[i].sosMenor(min)) {
					min = this.p[i];
				}
			}
			
			return min;
		}
		public Comparable maximo(){
			Comparable max = this.p[0];
			
			for (int i = 1; i < p.Count; i++) {
				if (this.p[i].sosMayor(max)) {
					max = this.p[i];
				}
			}
			
			return max;
		}
		public void agregar(Comparable c){
			apilar(c);
		}
		
		public bool contiene(Comparable c){
			for (int i = 0; i < p.Count; i++) {
				if (this.p[i].sosIgual(c)) {
					return true;
				}
			}
			return false;
		}
		
		//Implementamos la interface iterable
		public Iterador crearIterador(){
			return new iteradorDePila(this);
		}

        //Implementamos la interface ordenable
        public void setOrdenInicio(OrdenEnAula1 a)
		{
			ordenInicio = a;
		}
        public void setOrdenLlegaAlumno(OrdenEnAula2 a)
		{
			ordenLlegaAlumno = a;
		}
        public void setOrdenAulaLlena(OrdenEnAula1 a)
		{
			ordenAulaLlena = a;
		}

    }
}
