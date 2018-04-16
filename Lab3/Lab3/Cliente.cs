using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{

    public class Cliente
    {
        public enum TipoCliente { persona, empresa, organizacion, institucion };

        string nombre;
        string rut;
        TipoCliente tipo;

        public Cliente(string n, string r, TipoCliente t)
        {
            nombre=n;
            rut=r;
            tipo=t;
        }      

        public string GetNombre()
        {
            return nombre;
        }

        public string GetRut()
        {
            return rut;
        }


    }

}
        
