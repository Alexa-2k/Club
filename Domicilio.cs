using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Club
{
    public class Domicilio
    {
        string calle, ciudad, cp;
        ushort numero;
        int telefono;

        public string Calle { get => calle; set => calle = value; }
        public string Ciudad { get => ciudad; set => ciudad = value; }
        public ushort Numero { get => numero; set => numero = value; }
        public string Cp { get => cp; set => cp = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public override string ToString()
        {
            return "Calle : " + Calle + " " + Numero + "\nCP: " + Cp +  "\nCiudad: " + Ciudad + "\nTelefono de contacto: " + Telefono + "\n";
                
        }

    }

}
