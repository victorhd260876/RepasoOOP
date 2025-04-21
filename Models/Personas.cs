using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoOOP.Models
{
    public class Personas
    {
        public string dni;
        public string nombres;
        public string apellidos;
        public DateOnly fechanac;
        public int edad;
        public char estcivil;
        public char estatus;


        public Personas(string dni, string nombres, string apellidos, DateOnly fechanac, int edad, char estcivil, char estatus)
        {
            this.dni = dni;
            this.nombres = nombres;
            this.apellidos = apellidos;
            this.fechanac = fechanac;
            this.edad = edad;
            this.estcivil = estcivil;
            this.estatus = estatus;
        }
    }
}
