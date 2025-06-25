using System;

namespace Clase_7
{
	public class ComparacionPorNombre: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getNombre() == a2.getNombre();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getNombre() != a2.getNombre();
		}
 		
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getNombre() != a2.getNombre();
		}
	}
}
