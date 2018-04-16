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
            Cliente cl =  new Cliente("juanito perez", "123445", 0);
            Cliente cl1 = new Cliente("ssn", "123445", Cliente.TipoCliente.institucion);
            Vehiculos v1 = new Vehiculos("rfe4", Tipo.acuatico);

            Console.WriteLine(cl.GetNombre());
            Console.WriteLine(cl1.GetRut());
            Console.WriteLine(v1.GetPatente());

            Console.ReadKey();
        }
    }
}
