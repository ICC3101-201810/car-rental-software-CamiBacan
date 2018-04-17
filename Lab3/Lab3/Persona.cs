using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Persona : Cliente , IVerificable
    {
        bool licencia;

        public Persona(string nombre, string rut, bool license) : base(nombre,rut)
        {
            licencia = license;
        }

        public bool GetLicense()
        {
            return licencia;
        }

        public void IVerificable.Verificar()
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
