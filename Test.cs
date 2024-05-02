using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Test
    {            public static void Main(string[] args)
            {
                // Creamos una instancia de alumno nuevo. Primero generamos instancias de disciplina y profesor para tener los datos disponibles para el alumno 
                 
                //Para crear al profesor creamos domicilio y persona:
                Domicilio domJoseRodriguez = new Domicilio
                {
                    Calle = "Calle Falsa 123",
                    Ciudad = "Ciudad Ejemplo",
                    Cp = "C1001",
                    Numero = 123,
                    Telefono = 987654321
                };

                // Instancia de persona

                Persona JoseRodriguez = new Persona("José", "Rodriguez", "DNI", "20000000", domJoseRodriguez);

                // instancia profesor
                ushort legajo = 12345;
                Profesor profeSpinning = new Profesor(legajo, JoseRodriguez);


                // Instancia de Disciplina
                Disciplina spinning = new Disciplina(
                nomDis: "Spinning",
                profe: profeSpinning,
                valMes: 50000.0,
                valDia: 3000,
                vacantes: 30,
                cupo: true
            );
            
            
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
                    venceCuota: DateTime.Now.AddMonths(1),
                    pago: new Pago()
                    {
                        Monto = 50000.0,
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

            // Instancia de Alumno socio con los datos de Persona JuanPerez
            Alumno NSE98765432 = new Alumno(
            nroSocio: 0,
            identidad: DNIE98765432,
            actividad: spinning,
            inhibido: false,
            venceCuota: DateTime.Now.AddMonths(1),
            pago: new Pago()
            {
                Monto = 5000.0,
                MetodoPago = "Efectivo",
                FechaPago = DateTime.Now
            }
        );








            }
        }
    }

