using System;

namespace Clase_7
{
    class Program
    {
        public static void Main(string[] args)
        {
            Pila pila = new Pila();
            Aula aula = new Aula();

            pila.setOrdenInicio(new OrdenInicio(aula));
            pila.setOrdenLlegaAlumno(new OrdenLlegaAlumno(aula));
            pila.setOrdenAulaLlena(new OrdenAulaLlena(aula));

            //Llenar(pila, 5);
            //Llenar(pila, 6);

            Llenar(pila, 1, 5);
            LlenarPorTeclado(pila, 4, 2);
            LlenarPorLectorDeArchivos(pila, 7, 1);

            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }

        public static void llenar(Coleccionable c)
        {
            Random rn = new Random();

            for (int i = 0; i < 20; i++)
            {
                Comparable com = new Numero(rn.Next());
                c.agregar(com);
            }
        }

        //Clase 2 Ejercicio 6
        public static void imprimirElementos(Coleccionable col)
        {
            Iterador ite = col.crearIterador();

            ite.primero();
            while (!ite.fin())
            {
                Console.WriteLine(ite.actual().toString());
                ite.siguiente();
            }
        }

        //Clase 2 Ejercicio 8
        public static void cambiarEstrategia(Coleccionable col, EstrategiaDeComparacion est)
        {
            Iterador ite = col.crearIterador();

            ite.primero();
            while (!ite.fin())
            {
                ((Alumno)ite.actual()).setNvaEstrategia(est);
                ite.siguiente();
            }
        }

        //Clase 3 Ejercicio 6
        public static void Llenar(Coleccionable col, int op, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Comparable c = FabricaDeComparables.crearAleatorio(op);
                col.agregar(c);
            }
        }

        public static void LlenarPorTeclado(Coleccionable col, int op, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Comparable c = FabricaDeComparables.crearPorTeclado(op);
                col.agregar(c);
            }
        }

        public static void LlenarPorLectorDeArchivos(Coleccionable col, int op, int cant)
        {
            for (int i = 0; i < cant; i++)
            {
                Comparable c = FabricaDeComparables.crearPorLectorDeArchivos(op);
                col.agregar(c);
            }
        }

        public static void informar(Coleccionable col, int op)
        {
            Console.WriteLine(col.cuantos());
            Console.WriteLine(col.minimo().toString());
            Console.WriteLine(col.maximo().toString());

            Comparable c = FabricaDeComparables.crearPorTeclado(op);
            if (col.contiene(c))
            {
                Console.WriteLine("El elemento leido esta en la coleccion");
            }
            else
                Console.WriteLine("El elemento leido no esta en la coleccion");
        }

        public static void dictadoDeClases(Profesor p)
        {
            for (int i = 0; i < 5; i++)
            {
                p.hablarALaClase();
                p.escribirEnElPizarron();
            }
        }
    }
}