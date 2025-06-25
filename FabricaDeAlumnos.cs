using System;

namespace Clase_7
{
	public class FabricaDeAlumnos: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new Alumno(responsable.stringAleatorio(5), responsable.numeroAleatorio(10000000), responsable.numeroAleatorio(1000), responsable.numeroAleatorio(10));
		}
		
		public override Comparable crearPorTeclado(){
			return new Alumno(responsable.stringPorTeclado(), responsable.numeroPorTeclado(), responsable.numeroPorTeclado(), responsable.numeroPorTeclado());
		}

        public override Comparable crearPorLectorDeArchivos()
		{
			return new Alumno(responsable.stringDesdeArchivo(5), Convert.ToInt32(responsable.numeroDesdeArchivo(10000000.0)), Convert.ToInt32(responsable.numeroDesdeArchivo(1000.0)), Convert.ToInt32(responsable.numeroDesdeArchivo(10.0)));
		}
    }
}
