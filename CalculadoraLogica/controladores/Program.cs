using CalculadoraLogica.servicios;
using System.Xml;

namespace CalculadoraLogica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /// <summary>
            /// Crearemos las variables que usaremos e importamos los metodos
            /// awb 111023
            /// </summary>

            MenuInterfaz menu = new MenuImplementacion();
            PeticionDeStringsInterface peticiones = new PeticionDeStringsImplementacion();
            bool cerrarMenu = false;
            int opcionSeleccionada;

            //Este sera el while que mantendra el programa abierto
            while (!cerrarMenu)
            {
                /* Ejecutamos la interfaz grafica del menu para que el usuario seleccione
                   una opcion y recojamos los datos 
                */
                opcionSeleccionada = menu.menuYSeleccion();

                //Depenciendo de la opcion seleccionada se ejecutara distintos case en este switch
                switch (opcionSeleccionada)
                {
                    case 1:
                        //Operacion de cerrar menu
                        Console.WriteLine("Cerrando menu");
                        cerrarMenu = true;
                        break;
                    case 2:
                        //Operacion de igualdad
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------");
                        string primeraPalabra = peticiones.peticionString();
                        string segundaPalabra = peticiones.peticionString();
                        Console.WriteLine("La igaualdad es: ");
                        Console.WriteLine(primeraPalabra == segundaPalabra);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("");
                        break;
                    case 3:
                        //Operacion de desigualdad
                        Console.WriteLine("");
                        Console.WriteLine("-------------------------");
                        string primeraPalabraD = peticiones.peticionString();
                        string segundaPalabraD = peticiones.peticionString();
                        Console.WriteLine("La desigaualdad es: ");
                        Console.WriteLine(primeraPalabraD != segundaPalabraD);
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("");
                        break;

                }
                
            }
        }
    }
}
