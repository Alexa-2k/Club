using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Club
{
    internal class Socio : Alumno

    {
        public ushort nroSocio;
        Disciplina disciplina;
        public bool inhibido;
        public DateTime venceCuota; 

        public ushort NroSocio { get => nroSocio; set => nroSocio = value; }
        public bool Inhibido { get => inhibido; set => inhibido = value; }
        public DateTime VenceCuota { get => venceCuota; set => venceCuota = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }
    }
}
