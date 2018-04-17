using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            bool i = true;

            while (i == true)
            {
                Console.WriteLine("Hola! Bienvenido a Carrrrrental\n\nSeleccione opción:" +
                    "\n 1. Seleccionar sucursal\n 2. Crear sucursal");
                String accion;
                accion = Console.ReadLine();
                if (accion == "1")
                {
                    Sucursal s;
                    Rentacar bb;
                    break;
                }
                else if (accion == "2")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

            Console.ReadKey();
        }
    }
}
