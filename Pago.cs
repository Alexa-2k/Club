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

        public double? Monto { get => monto; set => monto = value; }
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public DateTime? FechaPago { get => fechaPago; set => fechaPago = value; }


        public Pago(double? monto, string? metodoPago, DateTime? fechaPago)
        {
            Monto = monto;
            MetodoPago = metodoPago;
            FechaPago = fechaPago;

        }



        public void RegistrarPago(Alumno alumno, Disciplina disciplina)
        {

            // Determinar el valor de la cuota basado en si el alumno es socio o no

            double valorCuota = alumno.NroSocio == 0 ? disciplina.ValorCuotaNoSocio : disciplina.ValorCuotaSocio;

            // Solicitar al usuario el método de pago y la actividad

            Console.WriteLine($"\n {alumno.Apellido}, {alumno.Nombre}:  Por favor indique el método de pago (Tarjeta, Efectivo)\n");
            MetodoPago = Console.ReadLine();
            FechaPago = DateTime.Now;

            // Actualizar el estado del alumno
            alumno.Inhibido = false;
            string estado = alumno.Inhibido == false ? estado = "No inhibido" : estado = "inhibido";
            // Registrar el pago con el valor de la cuota determinado

            Console.WriteLine($"\n{alumno.Apellido}, {alumno.Nombre}: Su pago ha sido registrado. \nMonto: ${valorCuota} \nMétodo de pago: {MetodoPago} \nFecha de Pago: {FechaPago}\nVencimiento cuota: {alumno.VenceCuota} \nEstado: {estado}");

            
            }

                                     



        public override string ToString()
        {
            return "Monto: " + Monto + " || Metodo de pago: " + MetodoPago + " || Fecha de Pago: " + FechaPago + "\n";
        }


    }
}
