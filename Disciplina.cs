using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Disciplina
    {
        private byte codDisciplina;
        private string nomDisciplina;
        private Profesor profe;
        //private Socio socio;
        private const byte cantAlumnos = 30;
        private List<Socio> alumnos;

        public byte CodDisciplina { get => codDisciplina; set => codDisciplina = value; }
        public string NomDisciplina { get => nomDisciplina; set => nomDisciplina = value; }

        public static byte CantAlumnos => cantAlumnos;

        internal List<Socio> Alumnos { get => alumnos; set => alumnos = value; }
        internal Profesor Profe { get => profe; set => profe = value; }

        public Disciplina()
        {
          this.Alumnos = new List<Socio>();

        }

    }
}
