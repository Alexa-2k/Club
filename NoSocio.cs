using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class NoSocio : Alumno
    {
        
        internal Disciplina Disciplina { get; set; }
        private bool pago;
        public bool Pago { get => pago; set => pago = value; }

        

    }
}
