using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    //public enum Tipo { auto, acuatico, moto, camion, bus, maqPesada };

    public class Vehiculos
    {
        private string patente;
        //private Tipo tipo;

        public Vehiculos(string Patente/*, Tipo tip*/)
        {
           patente = Patente;
            //tipo = tip;
        }

        public string GetPatente()
        {
            return patente;
        }
    }

    public class Auto : Vehiculos
    {
        int Precio;

        public Auto(string patente, int precio) : base(patente)
        {
            Precio = precio;
        }
    }

    public class Acuatico : Vehiculos
    {
        int Precio;

        public Acuatico(string patente, int precio) : base(patente)
        {
            Precio = precio;
        }
    }

    public class Moto : Vehiculos
    {
        int Precio;

        public Moto(string patente, int precio) : base(patente)
        {
            Precio = precio;
        }
    }

    public class Camion : Vehiculos
    {
        int Precio;

        public Camion(string patente, int precio) : base(patente)
        {
            Precio = precio;
        }
    }

    public class Bus : Vehiculos
    {
        int Precio;

        public Bus(string patente, int precio) : base(patente)
        {
            Precio = precio;
        }
    }

    public class MaqPesada : Vehiculos
    {
        int Precio;

        public MaqPesada(string patente, int precio) : base(patente)
        {
            Precio = precio;
        }
    }
}
