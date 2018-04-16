using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public enum Tipo { auto, acuatico, moto, camion, bus, maqPesada };

    public class Vehiculos
    {
        private string patente;
        private Tipo tipo;

        public Vehiculos(string Patente, Tipo tip)
        {
           patente = Patente;
            tipo = tip;
        }

        public string GetPatente()
        {
            return patente;
        }
    }


}
