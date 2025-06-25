using System;

namespace Clase_7
{
	public class FabricaDealumnoMuyEstudioso: FabricaDeComparables
	{
		public override Comparable crearAleatorio(){
			return new AlumnoMuyEstudioso(responsable.stringAleatorio(5), responsable.numeroAleatorio(1000000), responsable.numeroAleatorio(1000), responsable.numeroAleatorio(10));
		}
		public override Comparable crearPorTeclado(){
			return new AlumnoMuyEstudioso(responsable.stringPorTeclado(), responsable.numeroPorTeclado(), responsable.numeroPorTeclado(), responsable.numeroPorTeclado());
		}

		public override Comparable crearPorLectorDeArchivos()
		{
			return new AlumnoMuyEstudioso(responsable.stringDesdeArchivo(5), Convert.ToInt32(responsable.numeroDesdeArchivo(1.0)), Convert.ToInt32(responsable.numeroDesdeArchivo(1.0)), Convert.ToInt32(responsable.numeroDesdeArchivo(1.0)));
        }
    }
}
