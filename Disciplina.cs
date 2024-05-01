using System;
using System.Collections.Generic;
using System.Text;

namespace Club
{
    internal class Disciplina
    {
        private byte codDisciplina;
        private string nomDisciplina;
        private Profesor profe;
        //private Socio socio;
        private const byte cantAlumnos = 30;
        private List<Alumno> alumnos;
        private double valorMensual;
        private double valorDia;
        private byte vacante;
        private bool cupo;

        public byte CodDisciplina { get => codDisciplina; set => codDisciplina = value; }
        public string NomDisciplina { get => nomDisciplina; set => nomDisciplina = value; }

        public static byte CantAlumnos => cantAlumnos;

        internal List<Alumno> Alumnos { get => alumnos; set => alumnos = value; }
        internal Profesor Profe { get => profe; set => profe = value; }
        public double ValorMensua { get => valorMensual; set => valorMensual = value; }
        public double ValorDia { get => valorDia; set => valorDia = value; }
        public byte Vacante { get => vacante; set => vacante = value; }
        public bool Cupo { get => cupo; set => cupo = value; }

        public Disciplina(byte codDis, string nomDis, Profesor profe, double valMes, double valDia, byte vacantes, bool cupo)
        {
            this.codDisciplina = codDis;
            this.nomDisciplina = nomDis;
            this.profe = profe;
            this.valorMensual = valMes;
            this.valorDia = valDia;
            this.vacante = vacantes;
            this.cupo = cupo;

        }

       // List<Alumno> Alumnos = new List<Alumno>(cantAlumnos);


    }
      public void InscribirAlumno(Alumno) {
            
            if (vacantes <= cantAlumnos)
            {
                this.Alumnos = new List<Alumno>();
            } else {

                cupo = false;
            }


        }

        }
       

   
