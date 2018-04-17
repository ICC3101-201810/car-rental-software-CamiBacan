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
        Sucursal sucursal;

        public Arriendo(Cliente client, Accesorios acc, Vehiculos veh, Sucursal suc)
        {
            cliente = client;
            accesorio = acc;
            vehiculo = veh;
            sucursal = suc;
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

        public Sucursal GetSucursal()
        {
            return sucursal;
        }
    }
}
