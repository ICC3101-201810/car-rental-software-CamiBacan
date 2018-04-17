using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public enum Accessories
    {
        radiosBluetooth, GPS, rRepuesto,
        cortinas, sillasBBs
    }

    public class Accesorios
    {
        private Accessories accessories;

        public Accesorios(Accessories acc)
        {
            accessories = acc;
        }
    }
}
