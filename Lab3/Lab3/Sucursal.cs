using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Sucursal
    {
        private int nroSucursal;
        private string direccion;

        public Sucursal(int sucursal, string Direccion)
        {
            nroSucursal = sucursal;
            direccion = Direccion;
        }

        public int GetNroSucursal()
        {
            return nroSucursal;
        }

        public string GetDireccion()
        {
            return direccion;
        }
    }
}
