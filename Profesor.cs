using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Channels;

namespace Club
{
    public class Profesor : Persona
    {
        ushort legajo;
        Disciplina disciplina;
        Persona datos;
        private DateTime horario;  // por ahora asumimos que puede dar una sola clase (un solo horario) ya que esto no afecta a esta etapa del TP

        public ushort Legajo { get => legajo; set => legajo = value; }
        internal Disciplina Disciplina { get => disciplina; set => disciplina = value; }
        public Persona Datos { get => datos; set => datos = value; }
        public DateTime Horario { get => horario; set => horario = value; }


        public Profesor(ushort legajo, Persona datos, DateTime horario, Disciplina clase)
        {
            Legajo = legajo;
            Datos = datos;
            Horario = horario;
            Disciplina = clase;

        }
    }
}