using System;

namespace Clase_7
{
	public class AlumnoMuyEstudioso: Alumno
	{
		public AlumnoMuyEstudioso(string nombre, int dni, int legajo, int promedio): base(nombre, dni, legajo, promedio){
		}

		public int respoderPregunta(int pregunta) { return pregunta % 3; }
    }
}
