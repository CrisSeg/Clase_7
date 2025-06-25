using System;

namespace Clase_7
{
	public class AlumnoDecoradoPAD: AlumnoDecorado
	{
		public AlumnoDecoradoPAD(IAlumno a): base(a)
		{
		}
		
		public override string mostrarCalificacion(){
			string estado;
			if (base.getCalificacion() >= 7) {
				estado = "Promocion";
			}
			if (base.getCalificacion() >= 4 && base.getCalificacion() < 7) {
				estado = "Aprobado";
			}
			else
				estado = "Desaprobado";
			
			return base.mostrarCalificacion() + "(" + estado + ")";
		}
	}
}
