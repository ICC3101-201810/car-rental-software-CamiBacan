using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Arriendo
    {
        Cliente cliente;
        Accesorios accesorio;
        Vehiculos vehiculo;

        public Arriendo(Cliente client, Accesorios acc, Vehiculos veh)
        {
            cliente = client;
            accesorio = acc;
            vehiculo = veh;
        }

        public Cliente GetCliente()
        {
            return cliente;
        }

        public Accesorios GetAccesorios()
        {
            return accesorio;
        }
        
        public Vehiculos GetVehiculos()
        {
            return vehiculo;
        }
    }
}
