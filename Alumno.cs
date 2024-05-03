using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;

namespace Club
{
public class Alumno : Persona

    {
        private ushort nroSocio = 0;   //  si no es socio, nro de socio queda en 0
        private Persona identidad;      // toma los datos personales de clase Persona (nombre, apellido, DNI, domicilio)
        //Fase 2: modificamos la definicion de disciplinas para permitir que el alumno elija hasta 3
        public List<Disciplina> Actividades { get; set; } = new List<Disciplina>();
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
        public bool AptoFisico { get => aptoFisico; set => aptoFisico = value; }
        public bool Carnet { get => carnet; set => carnet = value; }
//        public List<Disciplina> Actividades1 { get => Actividades; set => Actividades = value; }

        public Alumno(ushort nroSocio, Persona identidad, List<Disciplina> actividades, bool aptoFisico, bool carnet , bool inhibido, DateTime? venceCuota, Pago pago ) : base(identidad.Nombre, identidad.Apellido, identidad.TipoID, identidad.NroID, identidad.Domicilio)
        {
            NroSocio = nroSocio;
            Identidad = identidad;
            Actividades = actividades ?? new List<Disciplina>();
            Inhibido = inhibido;
            VenceCuota = venceCuota;
            Pago = pago ;
            AptoFisico = aptoFisico;
            Carnet = carnet;
       
      }

        public static List<Alumno> ListaNOSocios = new List<Alumno>();
        public static List<Alumno> ListadoSocios = new List<Alumno>();
        public static List<Alumno> AlumnosConVencimientoHoy = new List<Alumno>();
//----------------------------------------------------
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
//--------------------------------------------------------------
        public void ElegirActividades(List<Disciplina> actividadesDisponibles)
        {
            Console.WriteLine($"\n {Apellido}, {Nombre}: Seleccione hasta 3 actividades, ingrese 0 para finalizar su elección:");

            //Ciclo FOR desde 0 hasta la última actividad disponible, que muestra el listado de actividades con
            //un número de orden para que el usuario elija el nro de actividad

            for (int i = 0; i < actividadesDisponibles.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {actividadesDisponibles[i].NomDisciplina}");
            }
            Console.WriteLine("0. Finalizar elección" + "\n"); 
            //---------------------------------------
            //nueva lista en la que se adicionan los cursos seleccionados

            List<int> seleccionados = new List<int>();
            int opcion;

            //Condicion while: mientras la cantidad de elegidos sea menor que 3, el nro de actividad ingresado sea >0 (si es cero, se toma como elección nula) y el nro de actividad ingresado sea <= a la cantidad de actividades disponibles, se agrega la actividad seleccionada a esta lista
            
            while (seleccionados.Count < 3 && (opcion = Int32.Parse(Console.ReadLine())) > 0 && opcion <= actividadesDisponibles.Count) 
            {
                seleccionados.Add(opcion);
            }

            Actividades = seleccionados.Select(index => actividadesDisponibles[index - 1]).ToList();
            Console.Write("\n");
        }

        //-------------------------------------------------
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
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Nro.Socio: " + NroSocio);
            sb.AppendLine("\nDATOS PERSONALES:");

            // Accediendo a los atributos de Identidad
            sb.AppendLine($"Nombre: {Identidad.Nombre}");
            sb.AppendLine($"Apellido: {Identidad.Apellido}");
            sb.AppendLine($"Tipo ID: {Identidad.TipoID}");
            sb.AppendLine($"Número ID: {Identidad.NroID}");
            sb.AppendLine($"Dirección: {Identidad.Domicilio.Calle}, {Identidad.Domicilio.Ciudad}, {Identidad.Domicilio.Cp}");

            sb.AppendLine("\nACTIVIDADES ELEGIDAS:");

            foreach (var actividad in Actividades)
            {
                sb.AppendLine($"- {actividad.NomDisciplina}");
            }


            sb.AppendLine($"Apto Físico: {AptoFisico}");
            sb.AppendLine($"Inhibido: {Inhibido}");
            sb.AppendLine($"Carnet entregado: {Carnet}");
            sb.AppendLine($"Vencimiento cuota: {VenceCuota}");

            return sb.ToString();
        }
       
    }
}
