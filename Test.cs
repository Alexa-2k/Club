using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Test
    {            public static void Main(string[] args)
            {
                // Creamos una instancia de alumno nuevo.
                // Primero generamos instancias de disciplina y profesor para tener los datos disponibles para el alumno 
                 
                //Para crear al profesor creamos domicilio y persona:

                Domicilio domJoseRodriguez = new Domicilio
                {
                    Calle = "Calle Falsa",
                    Ciudad = "San Isidro",
                    Cp = "B1642",
                    Numero = 123,
                    Telefono = 1147777777
                };

                // Instancia de persona profesoe

                Persona JoseRodriguez = new Persona("José", "Rodriguez", "DNI", "20000000", domJoseRodriguez);

                // instancia de profesor
                ushort legajo = 12345;
                Profesor profeSpinning = new Profesor(legajo, JoseRodriguez);



                //=====================================
                // Instancia de Disciplina
                Disciplina spinning = new Disciplina(
                nomDis: "Spinning",
                profe: profeSpinning,
                valMes: 50000.0,
                valDia: 3000,
                vacantes: 30,
                cupo: true
            );
            
            //Instanciamos alumnos: 

            // Instancia de persona
                 Persona JuanPerez = new Persona("Juan", "Perez", "DNI", "12345678",
                 new Domicilio()

                 {
                     Calle = "Calle Falsa",
                     Numero = 1234,
                     Ciudad = "Buenos Aires",
                     Cp = "C1001",
                     Telefono = 1112345678
                 }
    );

                // Instancia de Alumno socio con los datos de Persona JuanPerez
                Alumno Soc12345 = new Alumno(
                    nroSocio: 12345,
                    identidad: JuanPerez,
                    actividad: spinning,
                    inhibido: false,
                    venceCuota: DateTime.Now.AddMonths(1),   //se registra hoy, la cuota vence dentro de un mes
                    pago: new Pago()
                    {
                        Monto = spinning.ValorMensual,   //es socio, paga el valor mensual de la actividad
                        MetodoPago = "Tarjeta",
                        FechaPago = DateTime.Now
                    }
                );


            //Creamos otro alumno, no socio

            Persona DNIE98765432 = new Persona("Andrea", "Gonzalez", "DNI Extranjero", "98765432",
                 new Domicilio()

                 {
                     Calle = "Calle 4",
                     Numero = 456,
                     Ciudad = "Buenos Aires",
                     Cp = "C1020",
                     Telefono = 1198765432
                 }
    );

            // Instancia de Alumno NO socio con los datos de Persona Andra Gonzalez
            Alumno NSE98765432 = new Alumno(
            nroSocio: 0,
            identidad: DNIE98765432,
            actividad: spinning,
            inhibido: false,
            venceCuota: DateTime.Now, // como no es socia, paga las clases día a día. Paga hoy y el vencimiento es hoy
            pago: new Pago()
            {
                Monto = spinning.ValorDia,  //no es socia, paga el calor de la clase diaria
                MetodoPago = "Efectivo",
                FechaPago = DateTime.Now
            }
        );



            // Testeamos la presentación de datos: 

            Console.WriteLine("Testeamos la presentación de datos:\n");
            Console.WriteLine(NSE98765432);
            Console.WriteLine("\n======================================");

            Console.WriteLine(Soc12345);
            Console.WriteLine("\n======================================");
            Console.WriteLine("\nProfesor");
            Console.WriteLine(profeSpinning);




        }
    }
    }

