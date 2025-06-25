using System;

namespace Clase_7
{
	public class FabricaDeNumeros: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Numero(responsable.numeroAleatorio(1000));
		}
		
		public override Comparable crearPorTeclado(){
			return new Numero(responsable.numeroPorTeclado());
		}

		public override Comparable crearPorLectorDeArchivos()
		{
			return new Numero(Convert.ToInt32( responsable.numeroDesdeArchivo(1000.0)));
		}
    }
}
