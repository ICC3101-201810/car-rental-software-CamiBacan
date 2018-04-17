using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Empresa : Cliente, IVerificable
    {
        bool permiso;
        
        public Empresa(string Nombre, string Rut, bool Permiso) : base (Nombre, Rut)
        {
            permiso = Permiso;
        }

        public bool GetPermiso()
        {
            return permiso;
        }

        public void Verificar(Persona p, Empresa e)
        {
            if (e.GetPermiso() == true)
            {
                Console.WriteLine("Empresa tiene Permiso");
            }
            else
            {
                Console.WriteLine("Empresa no tiene Permiso");
            }
        }
    }
}
