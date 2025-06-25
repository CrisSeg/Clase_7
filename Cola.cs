using System;
using System.Collections.Generic;

namespace Clase_7
{
	public class Cola : Coleccionable, Iterable, Ordenable
	{
		private List<Comparable> ele;
		private OrdenEnAula1 ordenInicio, ordenAulaLlena;
		private OrdenEnAula2 ordenLlegaAlumno;
		public Cola()
		{
			this.ele = new List<Comparable>();
		}
		
		public void encolar(Comparable c){
			this.ele.Add(c);

            if (ele.Count == 1 && ordenInicio != null)
            {
				ordenInicio.ejecutar();   
            }
            if (ordenLlegaAlumno != null)
            {
				ordenLlegaAlumno.ejecutar(c);
            }
            if (ele.Count == 40 && ordenAulaLlena != null)
            {
				ordenAulaLlena.ejecutar();
            }

        }
		
		public Comparable desEncolar(){
			Comparable aux = this.ele[0];
			this.ele.RemoveAt(0);
			return aux;
		}
		
		public Comparable getElementos(int i){
			return this.ele[i];
		}
		
		public int cuantos(){
			return this.ele.Count;
		}
		
		public Comparable minimo(){
			Comparable aux = this.ele[0];
			
			for (int i = 1; i < this.ele.Count; i++) {
				if (this.ele[i].sosMenor(aux)) {
					aux = this.ele[i];
				}
			}
			
			return aux;
		}
		
		public Comparable maximo(){
			Comparable aux = this.ele[0];
			
			for (int i = 1; i < this.ele.Count; i++) {
				if (this.ele[i].sosMayor(aux)) {
					aux = this.ele[i];
				}
			}
			
			return aux;
		}
		
		public void agregar(Comparable c){
			encolar(c);
		}
		
		public bool contiene(Comparable c){
			for (int i = 0; i < this.ele.Count; i++) {
				if (this.ele[i].sosIgual(c)) {
					return true;
				}
			}
			
			return false;
		}
		
		//Implementamos la interface iterable
		public Iterador crearIterador(){
			return new iteradorDeCola(this);
		}

		//Implemento interface de ordenable
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
