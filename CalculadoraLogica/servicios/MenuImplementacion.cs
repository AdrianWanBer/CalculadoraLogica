using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {
        public int menuYSeleccion()
        {
            /// <summary>
            /// awb - 111023
            /// Crearemos los metedos de mostrarySeleccion el menu para exportar la seleccion a Program.cs
            /// </summary>
            int seleccionDelUsuario;
            Console.WriteLine("-------------------------");
            Console.WriteLine("| Seleccione una opción |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("|                       |");
            Console.WriteLine("|       1. Cerrar       |");
            Console.WriteLine("|      2. igualdad      |");
            Console.WriteLine("|     3. desigualdad    |");
            Console.WriteLine("|                       |");
            Console.WriteLine("|-----------------------|");

            seleccionDelUsuario = Console.ReadKey(true).KeyChar - ('0');
            return seleccionDelUsuario;
        }

    }
}
