using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public abstract class Rentacar
    {
        List<Sucursal> sucursals;

        public List<Sucursal> GetSucursales()
        {
            return sucursals;
        }
    }
}
