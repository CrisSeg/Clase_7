using System;
using System.Collections.Generic;
using System.Text;

namespace Clase_7
{
	public class GenerarDatosAleatorios : Manejador
	{
		private static GenerarDatosAleatorios unicaInstancia = null; 
		private static Random rn = new Random();

		private GenerarDatosAleatorios(Manejador sucesor): base(sucesor) { }
		public override int numeroAleatorio(int max){
			int num = rn.Next(0, max);
			return num;
		}
		
		public override string stringAleatorio(int cantidad){
			const string letras = "abcdefghijklmnopqrstuvwyz";
			StringBuilder palabra = new StringBuilder();
			
			for (int i = 0; i < cantidad; i++) {
				palabra.Append(letras[rn.Next(0, letras.Length)]);
			}
			
			return palabra.ToString();
		}

		//Implemenacion de Singleton
		public static GenerarDatosAleatorios getInstance(Manejador m)
		{
            if (unicaInstancia == null)
            {
				unicaInstancia = new GenerarDatosAleatorios(m);
            }
			return unicaInstancia;
        }
	}
}
