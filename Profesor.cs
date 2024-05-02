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
        Persona datos;
        
        //private DateTime horario;  // por ahora no usamos datos de horario ya que esto no afecta a esta etapa del TP

        public ushort Legajo { get => legajo; set => legajo = value; }
        public Persona Datos { get => datos; set => datos = value; }
        //public DateTime Horario { get => horario; set => horario = value; }


        public Profesor(ushort legajo, Persona datos) : base(datos.Nombre, datos.Apellido, datos.TipoID, datos.NroID, datos.Domicilio)
        {
            Legajo = legajo;
            Datos = datos;
            //Horario = horario;
          

        }
    }
}