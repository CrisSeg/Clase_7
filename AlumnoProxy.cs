/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 12/5/2025
 * Hora: 23:30
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase_7
{
	/// <summary>
	/// Description of AlumnoProxy.
	/// </summary>
	public class AlumnoProxy: IAlumno
	{
		private IAlumno aReal;
		private string nombre;
		private int dni, legajo, promedio, calificacion, opcion;
		private EstrategiaDeComparacion nvaEst;
		public AlumnoProxy(string nombre, int dni, int legajo, int promedio, int opcion)
		{
			this.nombre = nombre;
			this.dni = dni;
			this.legajo = legajo;
			this.promedio = promedio;
            this.opcion = opcion;
			nvaEst = new ComparacionPorLegajo();
		}
		
		//Implemento la interface alumnoProxy
		public string getNombre(){
			return this.nombre;
		}

        public void setNombre(string n) {
            this.nombre = n;
        }
		
		public int getDni(){
			return this.dni;
		}

        public void setDni(int d)
        {
            this.dni = d;
        }
		
		public int getLegajo(){
			return this.legajo;
		}

        public void setLegajo(int l)
        {
            this.legajo = l;
        }
		
		public int getPromedio(){
			return this.promedio;
		}

        public void setPromedio(int p)
        {
            this.promedio = p;
        }
		
		public void setCalificacion(int c) { 
            this.aReal.setCalificacion(c);
        }
		
		public int getCalificacion(){
			return this.calificacion;
		}
		public void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia){
			this.nvaEst = nvaEstrategia;
		}

        public bool sosIgual(Comparable c)
        {
            return this.aReal.sosIgual(c);
        }

        public bool sosMenor(Comparable c)
        { 
            return this.aReal.sosMenor(c);
        }

        public bool sosMayor(Comparable c)
        {
            return this.aReal.sosMayor(c);
        }
        public void prestandoAtencion() {
            this.aReal.prestandoAtencion();
        }
		public void distraerse()
		{
            this.aReal.distraerse();
        }
		public void actualizar(Observado o)
		{
            this.aReal.actualizar(o);
        }
		public int responderPregunta(int pregunta)
		{
            if (this.aReal == null)
            {
                this.aReal = (IAlumno)FabricaDeComparables.crearAleatorio(this.opcion);
                this.aReal.setNombre(this.nombre);
                this.aReal.setDni(this.dni);
                this.aReal.setLegajo(this.legajo);
                this.aReal.setPromedio(this.promedio);
            }

			return this.aReal.responderPregunta(pregunta);
        }
		public string mostrarCalificacion() {
            return this.aReal.mostrarCalificacion();
        }

        public string toString()
        {
            return this.aReal.toString();
        }
	}
}
