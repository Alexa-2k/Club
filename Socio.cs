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
        bool inhibido;
        DateTime venceCuota; 

        public ushort NroSocio { get => nroSocio; set => nroSocio = value; }
        public bool Inhibido { get => inhibido; set => inhibido = value; }
        public DateTime VenceCuota { get => venceCuota; set => venceCuota = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }
    }
}
