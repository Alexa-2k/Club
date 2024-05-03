using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Text;

namespace Club
{
public class Alumno : Persona


    {
        private ushort nroSocio = 0;   //  si no es socio, nro de socio queda en 0
        private Persona identidad;      // toma los datos personales de clase Persona (nombre, apellido, DNI, domicilio)
        private Disciplina actividad;  // por ahora asumimos que puede inscribirse en una sola actividad ya que esto no afecta a esta etapa del TP
        private bool inhibido;          // indica si está inhibido por falta de pago
        private DateTime? venceCuota;
        private Pago pago;
        private bool aptoFisico;
        private bool carnet = false;


        public ushort NroSocio { get => nroSocio; set => nroSocio = value; }
        public bool Inhibido { get => inhibido; set => inhibido = value; }
        public DateTime? VenceCuota { get => venceCuota; set => venceCuota = value; }
        
        public Pago Pago { get => pago; set => pago = value; }
        public Persona Identidad { get => identidad; set => identidad = value; }
        public Disciplina Actividad { get => actividad; set => actividad = value; }
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
        public bool Carnet { get => carnet; set => carnet = value; }

     

        public Alumno(ushort nroSocio, Persona identidad, Disciplina actividad, bool aptoFisico, bool carnet , bool inhibido, DateTime? venceCuota, Pago pago ) : base(identidad.Nombre, identidad.Apellido, identidad.TipoID, identidad.NroID, identidad.Domicilio)
        {
            NroSocio = nroSocio;
            Identidad = identidad;
            Actividad = actividad;
            Inhibido = inhibido;
            VenceCuota = venceCuota;
            Pago = pago ;
            AptoFisico = aptoFisico;
            Carnet = carnet;

          
      }

        public static List<Alumno> ListaNOSocios = new List<Alumno>();
        public static List<Alumno> ListadoSocios = new List<Alumno>();
        public static List<Alumno> AlumnosConVencimientoHoy = new List<Alumno>();

        public void RegistrarSocios(Alumno nuevoAlumno)
        {
           if (nuevoAlumno.NroSocio != 0)
            {
                carnet = true;                      //se entrega carnet al momento de registrarse
                ListadoSocios.Add(nuevoAlumno);
                
            } else
            {
                ListaNOSocios.Add(nuevoAlumno);  //los No socios no reciben carnet
            }


        }

        public static void MostrarSocios()
        {
            Console.WriteLine("\n LISTADO DE SOCIOS \n");
            Console.WriteLine("------------------------------ \n");

            foreach (var alumno in ListadoSocios)
            {
                Console.WriteLine(alumno);
                Console.WriteLine("-----------------------------\n");
               
            }

            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static void MostrarNOSocios()
        {
            Console.WriteLine("\n LISTADO DE NO SOCIOS \n");
            Console.WriteLine("------------------------------ \n");

            foreach (var alumno in ListaNOSocios)
            {
                Console.WriteLine(alumno);
                Console.WriteLine("-----------------------------\n");
            }
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }

        public static void VerificarVencimiento()
        {
            Console.WriteLine("\n LISTADO DE SOCIOS CUYA CUOTA VENCE HOY \n");
            Console.WriteLine("--------------------------------------------- \n");

            foreach (var alumno in ListadoSocios)
            {
                if (alumno.VenceCuota?.Date == DateTime.Today)
                {
                    AlumnosConVencimientoHoy.Add(alumno);
                    Console.WriteLine(alumno);
                    Console.WriteLine("-----------------------------\n");
                }
            }
            Console.WriteLine("\nPresione una tecla para continuar");
            Console.ReadKey();
            Console.Clear();
        }
        
        public override string ToString()
        {
            return "Nro.Socio: " +  NroSocio + "\n\nDATOS PERSONALES: " + "\n" + Identidad + "\nActividad: " + Actividad.NomDisciplina + "\nApto Físico: " + AptoFisico + "\nInhibido: " + Inhibido + "\nCarnet entregado: " + carnet + "\nVencimiento cuota: " + VenceCuota;

         } 

    }
}
