using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Persona
    {
        string nombre, apellido, documento;
        Domicilio domicilio;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Documento { get => documento; set => documento = value; }
        internal Domicilio Domicilio { get => domicilio; set => domicilio = value; }
    }
}
