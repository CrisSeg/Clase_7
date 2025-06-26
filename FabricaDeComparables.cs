using System;
using System.Collections.Generic;

namespace Clase_7
{
	public abstract class FabricaDeComparables
	{
		protected static Manejador responsable;
		
		public static Comparable crearAleatorio(int opcion){
			generarCadenaResponsables();

            FabricaDeComparables fabrica = null;
			
			switch (opcion) {
					case 1: fabrica = new FabricaDeAlumnos(); break;
					case 2: fabrica = new FabricaDeNumeros(); break;
					case 3: fabrica =new FabricaDeProfesores(); break; 
					case 4: fabrica = new FabricaDealumnoMuyEstudioso(); break;
					case 5: fabrica = new FabricaDeAlumnoDecorado(); break;
					case 6: fabrica = new FabricaDeAlumnoMuyEstudiosoDec(); break;
					case 7: fabrica = new FabricaAlumnoCompuesto(); break;
			}
			
			return fabrica.crearAleatorio();
		}
	
		public static Comparable crearPorTeclado(int opcion){
			generarCadenaResponsables();
			FabricaDeComparables fabrica = null;
			
			switch (opcion) {
					case 1: fabrica = new FabricaDeAlumnos(); break;
					case 2: fabrica = new FabricaDeNumeros(); break;
					case 3: fabrica =new FabricaDeProfesores(); break; 
					case 4: fabrica = new FabricaDealumnoMuyEstudioso(); break;
					case 5: fabrica = new FabricaDeAlumnoDecorado(); break;
					case 6: fabrica = new FabricaDeAlumnoMuyEstudiosoDec(); break;
					case 7: fabrica = new FabricaAlumnoCompuesto(); break;
            }
			
			return fabrica.crearPorTeclado();
		}

		public static Comparable crearPorLectorDeArchivos(int opcion)
		{
			generarCadenaResponsables();
			FabricaDeComparables fabrica = null;

			switch (opcion)
			{
					case 1: fabrica = new FabricaDeAlumnos(); break;
					case 2: fabrica = new FabricaDeNumeros(); break;
					case 3: fabrica = new FabricaDeProfesores(); break;
					case 4: fabrica = new FabricaDealumnoMuyEstudioso(); break;
					case 5: fabrica = new FabricaDeAlumnoDecorado(); break;
					case 6: fabrica = new FabricaDeAlumnoMuyEstudiosoDec(); break;
					case 7: fabrica = new FabricaAlumnoCompuesto(); break;
            }
			return fabrica.crearPorLectorDeArchivos();
		}
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearPorTeclado();
		public abstract Comparable crearPorLectorDeArchivos();

		protected static void generarCadenaResponsables()
		{
			responsable = GenerarDatosAleatorios.getInstance(null);
			responsable = new LectorDeDatos(responsable);
			responsable = LectorDeArchivos.getInstance(responsable);
		}
	}
}
