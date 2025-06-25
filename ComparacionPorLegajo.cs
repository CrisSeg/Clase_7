using System;

namespace Clase_7
{
	public class ComparacionPorLegajo: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2){
			return a1.getLegajo() == a2.getLegajo();
		}
		public bool sosMenor(IAlumno a1, IAlumno a2){
			return a1.getLegajo() < a2.getLegajo();
		}
		public bool sosMayor(IAlumno a1, IAlumno a2){
			return a1.getLegajo() > a2.getLegajo();
		}
	}
}
