using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Empresa : Cliente
    {
        bool permiso;
        
        public Empresa(string Nombre, string Rut, bool Permiso) : base (Nombre, Rut)
        {
            permiso = Permiso;
        }

        public void Verificar(Persona p)
        {
            if (p.GetLicense() == true)
            {
                Console.WriteLine("Persona tiene licencia");
            }
            else
            {
                Console.WriteLine("Persona no tiene licencia");
            }
        }
    }
}
