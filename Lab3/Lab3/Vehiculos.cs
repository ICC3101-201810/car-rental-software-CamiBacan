using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Vehiculos
    {
        string patente;
        enum Tipo {auto, acuatico,moto,camion,bus, maqPesada};

        public Vehiculos(string Patente)
        {
           patente = Patente;
        }
    }

}
