using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Club
{
    public class Pago
    {
        private double? montoTotal;
        private string? metodoPago;
        private DateTime? fechaPago;
        private string cuotas;
        private double? valorCuotas;
        
        public string MetodoPago { get => metodoPago; set => metodoPago = value; }
        public DateTime? FechaPago { get => fechaPago; set => fechaPago = value; }
        public string Cuotas { get => cuotas; set => cuotas = value; }
        public double? MontoTotal { get => montoTotal; set => montoTotal = value; }
        public double? ValorCuotas { get => valorCuotas; set => valorCuotas = value; }

        public Pago(double? montoTotal, string? metodoPago, DateTime? fechaPago, string cuotas, double? valorCuotas)
        {
            MontoTotal = montoTotal;
            MetodoPago = metodoPago;
            FechaPago = fechaPago;
            Cuotas = cuotas;
            ValorCuotas = valorCuotas;
       
          }


        //------------------------------------------------

         public void RegistrarPago(Alumno alumno, List<Disciplina> actividades)
         {
             Console.WriteLine("\n REGISTRO DE PAGOS \n");
             Console.WriteLine("------------------------------ \n");

             // Determinar el valor de la cuota basado en actividades elegidas, y si el alumno es socio o no
             if (alumno.NroSocio == 0)
             {
                 montoTotal = alumno.Actividades.Sum(a => a.ValorCuotaNoSocio);
             }
             else
             {
                 montoTotal = alumno.Actividades.Sum(a => a.ValorCuotaSocio);
             }

             // Solicitar al usuario el método de pago

             Console.WriteLine($"\n {alumno.Apellido}, {alumno.Nombre}: el monto de su cuota es $ {montoTotal}  \nPor favor indique el método de pago (T para pago con Tarjeta, o cualquier otra tecla para pago en Efectivo)\n");

             MetodoPago = Console.ReadLine();
             MetodoPago = MetodoPago.ToUpper(); 

             if (MetodoPago == "T") {
                 Console.WriteLine("\nPromoción en cuotas? \nIngrese:\n3 para tres cuotas (con 25% de recargo) \n6 para seis cuotas (con 50% de recargo) \n0 para ninguna");

                 cuotas = Console.ReadLine();

                 MetodoPago = "Tarjeta de crédito";
             } 
             else
             {
                 MetodoPago = "Efectivo";
             }

             if(cuotas == "3")
             {
                 valorCuotas = montoTotal*1.25 / 3;

             } else if (cuotas == "6")
             {
                 valorCuotas = montoTotal*1.5 / 6;
             } else
             {
                 valorCuotas = montoTotal;    
             }

             FechaPago = DateTime.Now;

             // Actualizar el estado del alumno
             alumno.Inhibido = false;
             string estado = alumno.Inhibido == false ? estado = "No inhibido" : estado = "inhibido";
             // Registrar el pago con el valor de la cuota determinado


             Console.WriteLine($"\n{alumno.Apellido}, {alumno.Nombre}: Su pago ha sido registrado. \nMétodo de pago: {MetodoPago} \nCantidad de cuotas: {cuotas} \nMonto: ${valorCuotas}  \nFecha de Pago: {FechaPago}\nVencimiento cuota: {alumno.VenceCuota} \nEstado: {estado}");

            Console.WriteLine("\nInscripción confirmada a las siguientes actividades:");
            foreach (var actividad in actividades)
            {
                Console.WriteLine($"- Actividad: {actividad.NomDisciplina}, Profesor: {actividad.Profe.Apellido}, {actividad.Profe.Nombre} ");
            }
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();

             }
 
        public override string ToString()
        {
            return ($"Monto: {valorCuotas} \nMetodo de pago: {MetodoPago} \nFecha de Pago: {FechaPago}\n");
        }


    }
}
