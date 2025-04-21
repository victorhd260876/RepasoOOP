using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoOOP.Models
{
    public class Viviendas
    {
        public string tipo = "condominio";
        public string nombre = "El Paraiso";
        public string direcc = "Av Brasil 999";
        public string distrito = "Jesus María";
        public string provincia = "Lima" ;
        public string region = "Lima";
        public string pais = "Perú" ;
        public double area = 1570.10;

        public Viviendas(string tipo, string nombre, string direcc, string distrito, string provincia, string region, string pais, double area) 
        {
            this.tipo = tipo;
            this.nombre = nombre;
            this.direcc = direcc;
            this.distrito = distrito;
            this.provincia = provincia;
            this.region = region;
            this.pais = pais;
            this.area = area;
        }

        public void Etapa()
        {
            Console.WriteLine("Construido");
        }

        
    }
}
