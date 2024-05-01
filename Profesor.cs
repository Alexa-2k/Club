using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Profesor : Persona
    {
        ushort legajo;
        Disciplina disciplina;

        public ushort Legajo { get => legajo; set => legajo = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }
    }
}
