using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Club
{
    internal class Socio : Persona

    {
        ushort nroSocio;
        Disciplina disciplina;

        public ushort NroSocio { get => nroSocio; set => nroSocio = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }
    }
}
