using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Test
    {
        public static void Main(string[] args)
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
            valSocio: 50000.0,
            valNoSoc: 5000,
            vacantes: 30,
            cupo: true);

            //========================================
            // REGISTRO 

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
            });

            // Registro : Instancia de Alumno socio con los datos de Persona JuanPerez
            Alumno Soc12345 = new Alumno(
            nroSocio: 12345,
            identidad: JuanPerez,
            actividad: spinning,
            aptoFisico: true,
            carnet: true,
            inhibido: false,
            venceCuota: DateTime.Now.AddMonths(1),   //se registra hoy Y PAGA HOY, la cuota vence dentro de un mes
            pago: new Pago(spinning.ValorCuotaSocio, "Tarjeta", null, "0")  // todavía no pagó
                    );
            //Llamado al método que registra al alumno

            Soc12345.RegistrarSocios(Soc12345);

            Persona JuanMartin = new Persona("Juan", "Martin", "Pasaporte", "AAB281830",
            new Domicilio()

            {
                Calle = "Fantasía",
                Numero = 257,
                Ciudad = "Buenos Aires",
                Cp = "C1439",
                Telefono = 1123456789
            });

            //Siguiente instancia

            // Registro : Instancia de Alumno socio con los datos de Persona JuanMartin
            Alumno Soc23456 = new Alumno(
            nroSocio: 23456,
            identidad: JuanMartin,
            actividad: spinning,
            aptoFisico: true,
            carnet: true,
            inhibido: false,
            venceCuota: DateTime.Now,   
            pago: new Pago(spinning.ValorCuotaSocio, "Tarjeta", null, "0")  // todavía no pagó

        );

            Soc23456.RegistrarSocios(Soc23456);


            //Siguiente instancia

            Persona SolSchmidt = new Persona("Sol", "Schmidt", "DNI", "87654321",
                        new Domicilio()

                        {
                            Calle = "Callecita",
                            Numero = 4321,
                            Ciudad = "Buenos Aires",
                            Cp = "C1324",
                            Telefono = 1176542314
                        });

            // Registro : Instancia de Alumno socio con los datos de Persona SolSchmidt
            Alumno Soc65432 = new Alumno(
            nroSocio: 65432,
            identidad: SolSchmidt,
            actividad: spinning,
            aptoFisico: true,
            carnet: true,
            inhibido: false,
            venceCuota: DateTime.Now.AddDays(10),
            pago: new Pago(spinning.ValorCuotaSocio, "Tarjeta", null, "0")  
        );
               
            Soc65432.RegistrarSocios(Soc65432);


            //Siguiente instancia

            Persona GonzaloLopez = new Persona("Gonzalo", "Lopez", "DNI Extranjero", "99999999",
                        new Domicilio()

                        {
                            Calle = "Avenida",
                            Numero = 3333,
                            Ciudad = "Buenos Aires",
                            Cp = "C1222",
                            Telefono = 1199999999
                        });

            // Registro : Instancia de Alumno socio
            Alumno Soc11111 = new Alumno(
            nroSocio: 11111,
            identidad: GonzaloLopez,
            actividad: spinning,
            aptoFisico: true,
            carnet: true,
            inhibido: false,
            venceCuota: DateTime.Now,  
            pago: new Pago(spinning.ValorCuotaSocio, "Tarjeta", null, "0")  // todavía no pagó

        );

            Soc11111.RegistrarSocios(Soc11111);
            
            
            //Nuevo alumno, NO socio

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

            // Registro: Instancia de Alumno NO socio con los datos de Persona Andrea Gonzalez

            Alumno NSE98765432 = new Alumno(
            nroSocio: 0,
            identidad: DNIE98765432,
            actividad: spinning,
            aptoFisico: true,
            carnet: false,       // a los no socios no se les entrega carnet.
            inhibido: true,   //todavía no pagó, está inhibida

            venceCuota: DateTime.Now,  // como no es socia, paga las clases día a día. Paga hoy y el vencimiento es hoy
            pago: new Pago(spinning.ValorCuotaNoSocio, null, null, "0")  //pago en blanco, todavia no pagó

            ) ;

            NSE98765432.RegistrarSocios(NSE98765432);

            //======================================================

            // Test de presentación de datos: 

            Console.WriteLine("Verificación del registro:\n");
            Console.WriteLine(NSE98765432);
            Console.WriteLine("\n======================================");

            Console.WriteLine(Soc12345);
            Console.WriteLine("\n======================================");
            Console.WriteLine("\nProfesor");
            Console.WriteLine(profeSpinning);


            //======================================================

            //Registro del pago de Andrea Gonzalez

            Pago pagoNSE98765432 = new Pago(null, null, null, "0");
            pagoNSE98765432.RegistrarPago(NSE98765432, spinning);


            Console.WriteLine("\n======================================");
            Console.WriteLine("\n");



            //Registro del pago de Juan Perez

            Pago pagoSoc12345 = new Pago(null, null, null, "0");
            pagoSoc12345.RegistrarPago(Soc12345, spinning);


            Console.WriteLine("\n======================================");
            Console.WriteLine("\n");


            //======================================================


            //Mostrar listado de socios

            Alumno.MostrarNOSocios();
            Console.WriteLine("\n");
            
            
            //Mostrar listado de No socios
            Alumno.MostrarSocios();
            Console.WriteLine("\n");


            //======================================================


            //Listado de alumnos cuya cuota vence hoy. 

            Alumno.VerificarVencimiento();





        }




    }


}
   