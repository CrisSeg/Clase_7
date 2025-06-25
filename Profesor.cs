using System;
using System.Collections.Generic;

namespace Clase_7
{
	public class Profesor: Persona, Observado
	{
		//Ejercicio 8
		private int antiguedad;
		private EstrategiaDeComparacionProf estrategia;
		private List<Observador> observadores;
		private bool hablando;
		
		public Profesor(string n, int d, int a): base(n, d)
		{
			this.nombre = n;
			this.dni = d;
			this.antiguedad = a;
			estrategia = new ComparacionPorAntiguedad();
			this.observadores = new List<Observador>();
		}
		
		public override string getNombre()
		{
			return this.nombre;
		}
		
		public override int getDni(){
			return this.dni;
		}
		
		public int getAntiguedad(){
			return this.antiguedad;
		}
		
		public override bool sosIgual(Comparable c)
		{
			return this.estrategia.sosIgual(this, (Profesor)c);
		}

		public override bool sosMenor(Comparable c)
		{
			return this.estrategia.sosMenor(this, (Profesor)c);
		}

		public override bool sosMayor(Comparable c)
		{
			return this.estrategia.sosMayor(this, (Profesor)c);
		}

		public override string toString()
		{
			return base.toString() + string.Format(" Antiguedad: {0}", antiguedad);;
		}
		
		public void setNvaEstrategia(EstrategiaDeComparacionProf nvaEstrategia){
			this.estrategia = nvaEstrategia;
		}
		
		public void hablarALaClase(){
			Console.WriteLine("Hablando de algun tema");
			this.hablando= true;
			this.notificar();
		}
		
		public void escribirEnElPizarron(){
			Console.WriteLine("Esccribiendo en el pizarron");
			this.hablando = false;
			this.notificar();
		}
		
		public bool isHablando(){
			return this.hablando;
		}
		
		//implemento la interface observado
		public void agregraObservador(Observador o){
			this.observadores.Add(o);
		}
		
		public void quitarObsevador(Observador o){
			this.observadores.Remove(o);
		}
		
		public void notificar(){
			foreach (Observador observador in observadores) {
				observador.actualizar(this);
			}
		}
	}
}
