using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
   public class Disciplina
    {
        private string nomDisciplina;
        private Profesor profe;
        //private Alumno alumno;
        private const byte cantAlumnos = 30;
        private List<Alumno> alumnos;
        private double valorMensual;
        private double valorDia;
        private byte vacante = cantAlumnos;
        private bool cupo;
       
        public string NomDisciplina { get => nomDisciplina; set => nomDisciplina = value; }
        public static byte CantAlumnos => cantAlumnos;

        internal List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        internal Profesor Profe { get => profe; set => profe = value; }
        public double ValorMensual { get => valorMensual; set => valorMensual = value; }

        public double ValorDia { get => valorDia; set => valorDia = value; }
        public byte Vacante { get => vacante; set => vacante = value; }
        public bool Cupo { get => cupo; set => cupo = value; }
        
        //public Alumno Alumno { get => alumno; set => alumno = value; }

        public Disciplina( string nomDis, Profesor profe, double valMes, double valDia, byte vacantes, bool cupo)
        {
            this.nomDisciplina = nomDis;
            this.profe = profe;
            this.ValorMensual = valMes;
            this.valorDia = valDia;
            this.vacante = vacantes;
            this.cupo = cupo;
            this.alumnos = new List<Alumno>();

        }


        public override string ToString()
        {
            return "Actvidad: " + NomDisciplina + "Profesor a cargo: " + Profe + "Valor mensual: " + ValorMensual + "Valor clase única: " + ValorDia + "Vacantes disponibles: " + Vacante
             ;

        }

        public void InscribirAlumno(Alumno alumno)
        {
            // Si no está inhibido
            if (!alumno.Inhibido)
            {
                // y hay vacantes
                if (vacante > 0)
                {
                    // incorporamos al alumno a la lista
                    alumnos.Add(alumno);
                    vacante--; // y restamos una vacante

                    // si las vacantes llegan a 0 con este alumno, cambiamos cupo a falso
                    if (vacante == 0)
                    {
                        cupo = false;
                    }
                }
                else
                {
                    // Si ya no hay vacantes
                    Console.WriteLine("No hay vacantes para esta actividad.");
                }
            }
            else
            {
                // Si está inhibido
                Console.WriteLine("Alumno inhibido. Por favor, regularice su situación para poder inscribirse");
            }
        }
        
        
    }
     

}
       

   
