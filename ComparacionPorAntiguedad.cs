using System;

namespace Clase_7
{
	public class ComparacionPorAntiguedad: EstrategiaDeComparacionProf
	{
		public bool sosIgual(Profesor p1, Profesor p2){
			return p1.getAntiguedad() == p2.getAntiguedad();
		}
		
		public bool sosMenor(Profesor p1, Profesor p2){
			return p1.getAntiguedad() < p2.getAntiguedad();
		}
 		
		public bool sosMayor(Profesor p1, Profesor p2){
			return p1.getAntiguedad() > p2.getAntiguedad();
		}
	}
}
