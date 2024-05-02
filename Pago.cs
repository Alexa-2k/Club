using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
   public class Pago
    {
     
            public double Monto { get; set; }
            public string MetodoPago { get; set; }
            public DateTime FechaPago { get; set; }



        public override string ToString()
        {
            return "Monto: " + Monto + " || Metodo de pago: " + MetodoPago + " || Fecha de Pago: " + FechaPago + "\n";
        }


    }
}
