using System;
using System.Xml.Serialization;

namespace Clase_7
{
	public abstract class Persona : Comparable
	{
		protected string nombre;
		protected int dni;
		
		public Persona(string n, int d){
			this.nombre=n;
			this.dni=d;
		}
		
		public abstract string getNombre();
		
		public void setNombre(string n){
			this.nombre = n;
		}
		
		public abstract int getDni();

		public void setDni(int d) {
			this.dni = d;
		}

		
		//Implemento la interfaz comparable
		public virtual bool sosIgual(Comparable c)
		{
    		return this.dni == ((Persona)c).dni;
		}

		public virtual bool sosMenor(Comparable c)
		{
    		return this.dni < ((Persona)c).dni;
		}

		public virtual bool sosMayor(Comparable c)
		{
    		return this.dni > ((Persona)c).dni;        }

		public virtual string toString()
		{
			return string.Format("Nombre: {0}, Dni: {1}", nombre, dni);
		}
		
		
	}
}
