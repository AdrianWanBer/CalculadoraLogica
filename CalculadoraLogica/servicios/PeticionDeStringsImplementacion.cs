using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraLogica.servicios
{
    internal class PeticionDeStringsImplementacion : PeticionDeStringsInterface
    {
        /// <summary>
        /// awb - 111023
        /// Crearemos la operacion de recojer las palabras que escriba el usuario para luego exportarlas
        /// </summary>
        public string peticionString()
        {
            string usuarioEscrito;
            Console.WriteLine("Escriba su palabra: ");
            usuarioEscrito = Console.ReadLine();
            return usuarioEscrito;
        }
    }
}
