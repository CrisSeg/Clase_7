using System;

namespace Clase_7
{
	public interface IAlumno : Comparable
	{
		string getNombre();
		void setNombre(string n);
		int getDni();
		void setDni(int d);
        int getLegajo();
		void setLegajo(int l);
        int getPromedio();
		void setPromedio(int p);
        void setCalificacion(int c);
		int getCalificacion();
		void setNvaEstrategia(EstrategiaDeComparacion nvaEstrategia);
		
		void prestandoAtencion();
		void distraerse();
		void actualizar(Observado o);
		int responderPregunta(int pregunta);
		string mostrarCalificacion();
	}
}
