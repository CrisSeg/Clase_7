/*
 * Creado por SharpDevelop.
 * Usuario: nico_
 * Fecha: 7/5/2025
 * Hora: 23:39
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace Clase_7
{
	/// <summary>
	/// Description of AlumnoDecoradoAsterisco.
	/// </summary>
	public class AlumnoDecoradoAsterisco: AlumnoDecorado
	{
		public AlumnoDecoradoAsterisco(IAlumno a): base(a)
		{
		}
		
		public override string mostrarCalificacion(){
			string resAsterisco = "";
			for (int i = 0; i < base.mostrarCalificacion().Length + 4; i++) {
				resAsterisco += "*";
			}
			
			resAsterisco += "\n*" + base.mostrarCalificacion() + "*\n";
			
			for (int i = 0; i < base.mostrarCalificacion().Length + 4; i++) {
				resAsterisco += "*";
			}
			
			return resAsterisco;
		}
		
	}
}
