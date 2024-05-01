using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Profesor : Persona
    {
        ushort legajo;
        Disciplina disciplina;
        private List<DateTime> horarios;

        public ushort Legajo { get => legajo; set => legajo = value; }
        public List<DateTime> Horarios { get => horarios; set => horarios = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }
    }
}
