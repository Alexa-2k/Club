using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Domicilio
    {
        string calle, ciudad;
        ushort numero, cp;
        int telefono;

        public string Calle { get => calle; set => calle = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public ushort Numero { get => numero; set => numero = value; }
        public ushort Cp { get => cp; set => cp = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
