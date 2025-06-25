using System;

namespace Clase_7
{
	public class FabricaDeProfesores: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Profesor(responsable.stringAleatorio(5), responsable.numeroAleatorio(10000000), responsable.numeroAleatorio(25));
		}
		
		public override Comparable crearPorTeclado()
		{
			return new Profesor(responsable.stringPorTeclado(), responsable.numeroPorTeclado(), responsable.numeroPorTeclado());
		}

        public override Comparable crearPorLectorDeArchivos()
		{
			return new Profesor(responsable.stringDesdeArchivo(5), Convert.ToInt32(responsable.numeroDesdeArchivo(1000.0)), Convert.ToInt32(responsable.numeroDesdeArchivo(25.0)));
		}
    }
}
