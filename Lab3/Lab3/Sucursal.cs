using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Sucursal
    {
        private int nroSucursal;
        private string direccion;
        private string nombre;

        public Sucursal(int sucursal, string Direccion, string Nombre)
        {
            nroSucursal = sucursal;
            direccion = Direccion;
            nombre = Nombre;
        }

        public int GetNroSucursal()
        {
            return nroSucursal;
        }

        public string GetDireccion()
        {
            return direccion;
        }

        public string GetNombre()
        {
            return nombre;
        }

    }
}
