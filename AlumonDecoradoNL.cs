using System;

namespace Clase_7
{
	public class AlumonDecoradoNL: AlumnoDecorado
	{
		public AlumonDecoradoNL(IAlumno a): base(a)
		{
		}
		
		public override string mostrarCalificacion(){
			string[] numeros = {"Cero", "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Diez"};
			return base.mostrarCalificacion() + "(" + numeros[base.getCalificacion()] + ")";
		}
	}
}
