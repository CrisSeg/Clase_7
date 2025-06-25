using System;

namespace Clase_7
{
    public class FabricaAlumnoCompuesto : FabricaDeComparables
    {
        public override Comparable crearAleatorio()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                AlumnoProxy al = new AlumnoProxy(responsable.stringAleatorio(5), responsable.numeroAleatorio(1000000), responsable.numeroAleatorio(1000), responsable.numeroAleatorio(10), 5);
                compuesto.agregarHijos(al);
            }
            return compuesto;
        }
        public override Comparable crearPorTeclado()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                AlumnoProxy al = new AlumnoProxy(responsable.stringPorTeclado(), responsable.numeroPorTeclado(), responsable.numeroPorTeclado(), responsable.numeroPorTeclado(), 5);
                compuesto.agregarHijos(al);
            }
            return compuesto;
        }

        public override Comparable crearPorLectorDeArchivos()
        {
            AlumnoCompuesto compuesto = new AlumnoCompuesto();

            for (int i = 0; i < 5; i++)
            {
                AlumnoProxy al = new AlumnoProxy(responsable.stringDesdeArchivo(5), Convert.ToInt32(responsable.numeroDesdeArchivo(1000.0)), Convert.ToInt32(responsable.numeroDesdeArchivo(1000.0)), Convert.ToInt32(responsable.numeroDesdeArchivo(10.0)), 5);
                compuesto.agregarHijos(al);
            }
            return compuesto;
        }
    }
}
