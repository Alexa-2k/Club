using System;
using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics.X86;

namespace Club
{
    public class Test

    {
        public static void Main(string[] args)
        {
            /* Creamos una instancia de alumno nuevo. Primero generamos instancias de disciplina y profesor para tener los datos disponibles para el alumno 
             */

            // instancia de actividad
            Disciplina Spinning = new Disciplina
            {
                NomDisciplina = "Spinning",
                Profe = profeSpinning,
  
            
            
            } ;

            // intancia de profesor
            Persona JoseRodriguez = new Persona
            { 
                Nombre = "Jose",
                Apellido = "Rodriguez",
                Domicilio = new Domicilio()
                {
                    Calle = "Calle de fantasía",
                    Numero = 3456,
                    Ciudad = "Buenos Aires",
                    Cp = 1001,
                    Telefono = 1147777777

                }
           };


            Profesor profeSpinning = new Profesor
            {
                Legajo = 12345,
                Datos = JoseRodriguez
            };



        }
            // Instancia de Disciplina
/*            Disciplina disciplina = new Disciplina(
            nomDis: "Spinning",
            profe: new Profesor(legajo: 12345, datos: persona, horario: DateTime.Now, clase: new Disciplina()),
            valMes: 50000.0,
            valDia: 3000,
            vacantes: 30,
            cupo: true
        );
*/
            // Create a Persona instance



            Persona persona = new Persona
            {
                Nombre = "Juan",
                Apellido = "Perez",
                Documento = "12345678",
                Domicilio = new Domicilio()
                {
                    Calle = "Calle Falsa 123",
                    Numero = 123,
                    Ciudad = "Buenos Aires",
                    Cp = 12345,
                    Telefono = 1112345678
                }
            };



            // Create an Alumno instance using the Persona data
            Alumno alumno = new Alumno(
                nroSocio: 12345,
                identidad: persona,
                actividad: disciplina,
                inhibido: false,
                venceCuota: DateTime.Now.AddMonths(1),
                pago: new Pago()
                {
                    Monto = 50.0,
                    MetodoPago = "Tarjeta",
                    FechaPago = DateTime.Now
                }
            );
        }
    }
