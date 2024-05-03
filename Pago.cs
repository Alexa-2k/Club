using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    public class Pago
    {
        private double? monto;
        private string? metodoPago;
        private DateTime? fechaPago;
        private string cuotas;
        
        public double? Monto { get => monto; set => monto = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public DateTime? FechaPago { get => fechaPago; set => fechaPago = value; }
        public string Cuotas { get => cuotas; set => cuotas = value; }

        public Pago(double? monto, string? metodoPago, DateTime? fechaPago)
        {
            Monto = monto;
            MetodoPago = metodoPago;
            FechaPago = fechaPago;
            Cuotas = cuotas;
          }



        public void RegistrarPago(Alumno alumno, Disciplina disciplina)
        {
            Console.WriteLine("\n REGISTRO DE PAGOS \n");
            Console.WriteLine("------------------------------ \n");

            // Determinar el valor de la cuota basado en si el alumno es socio o no

            double valorCuota = alumno.NroSocio == 0 ? disciplina.ValorCuotaNoSocio : disciplina.ValorCuotaSocio;

            // Solicitar al usuario el método de pago

            Console.WriteLine($"\n {alumno.Apellido}, {alumno.Nombre}:  Por favor indique el método de pago (Tarjeta, Efectivo)\n");
            MetodoPago = Console.ReadLine();
            MetodoPago = MetodoPago.ToUpper(); 
            if (MetodoPago == "TARJETA") {
                Console.WriteLine("\nPromoción en cuotas? \nIngrese:\n3 para tres cuotas (con 25% de recargo) \n6 para seis cuotas (con 50% de recargo) \n0 para ninguna");
                cuotas = Console.ReadLine();
            }

            if(cuotas == "3")
            {
                valorCuota = valorCuota*1.25 / 3;
            
            } else if (cuotas == "6")
            {
                valorCuota = valorCuota*1.5 / 6;
            } 

            FechaPago = DateTime.Now;

            // Actualizar el estado del alumno
            alumno.Inhibido = false;
            string estado = alumno.Inhibido == false ? estado = "No inhibido" : estado = "inhibido";
            // Registrar el pago con el valor de la cuota determinado


            Console.WriteLine($"\n{alumno.Apellido}, {alumno.Nombre}: Su pago ha sido registrado. \nMétodo de pago: {MetodoPago} \nCantidad de cuotas: {cuotas} \nMonto: ${valorCuota}  \nFecha de Pago: {FechaPago}\nVencimiento cuota: {alumno.VenceCuota} \nEstado: {estado}");
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

            
            }

                                     



        public override string ToString()
        {
            return "Monto: " + Monto + " || Metodo de pago: " + MetodoPago + " || Fecha de Pago: " + FechaPago + "\n";
        }


    }
}
