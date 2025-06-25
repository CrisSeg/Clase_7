using System;
using System.Collections.Generic;

namespace Clase_7
{
	public class LectorDeDatos : Manejador
	{
		public LectorDeDatos(Manejador sucesor): base(sucesor) { }
		public override int numeroPorTeclado(){
			Console.WriteLine("Escriba un numero: ");
			int n = int.Parse(Console.ReadLine());
			return n;
		}
		
		public override string stringPorTeclado(){
			Console.WriteLine("Escribe un string: ");
			string s = Console.ReadLine();
			return s;
		}
	}
}
