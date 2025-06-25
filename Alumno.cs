using System;
using System.Collections.Generic;

namespace Clase_7
{
	public class Alumno : Persona, Comparable, Observador, IAlumno
	{
		private int legajo;
		private int promedio, calificacion;
		private EstrategiaDeComparacion estrategia;
		public static Random rn = new Random();
		public Alumno(string n, int d, int l, int p): base(n, d){
			this.nombre = n;
			this.dni = d;
			this.legajo = l;
			this.promedio = p;
			estrategia = new ComparacionPorLegajo();
		}
		
		public override string getNombre()
		{
			return this.nombre;
		}
		
		public override int getDni(){
			return this.dni;
		}
		
		public int getLegajo(){
			return this.legajo;
		}

		public void setLegajo(int l) {
			this.legajo = l;
		}
		
		public int getPromedio(){
			return this.promedio;
		}
		
		public void setPromedio(int p)
		{
			this.promedio = p;	
		}

		public void setCalificacion(int c){
			this.calificacion = c;
		}
		
		public int getCalificacion(){
			return this.calificacion;
		}
		
		public void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.estrategia = nvaEstrategia;
		}
		
		public override bool sosIgual(Comparable c)
        {
			return this.estrategia.sosIgual(this, (IAlumno)c);
        }

        public override bool sosMenor(Comparable c)
        {
            return this.estrategia.sosMenor(this, (IAlumno)c);
        }

        public override bool sosMayor(Comparable c)
        {
        	return this.estrategia.sosMayor(this, ((IAlumno)c));
        }
        
		public override string toString()
		{
			return base.toString() + string.Format(" Legajo: {0}, Promedio: {1}", legajo, promedio);
		}
		
		//Practica 3 Ejercicio 11
		public void prestandoAtencion(){
			Console.WriteLine("Prestando atencion");
		}
		
		public void distraerse(){
			string[] l = new string[]{"Mirando el celular", "Dibujando en el margen de la carpeta", "Tirando aviones de papel"};
			
			Console.WriteLine(l[rn.Next(0,3)]);
		}
		
		//implemento la interface observador
		public void actualizar(Observado o){
			if (((Profesor)o).isHablando()) {
				this.prestandoAtencion();
			}
			else
				this.distraerse();
		}
		
		//Practica 4 Ejercicio 1
		public int responderPregunta(int pregunta)
		{
			return rn.Next(1,3);
		}
		
		public string mostrarCalificacion(){
			return string.Format("Nombre: {0} Calificacion: {1}", nombre, calificacion);
		}
	}
}
