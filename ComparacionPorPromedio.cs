using System;

namespace Clase_7
{
	public class ComparacionPorPromedio: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getPromedio() == a2.getPromedio();
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getPromedio() < a2.getPromedio();
		}
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getPromedio() > a2.getPromedio();
		}
	}
}
