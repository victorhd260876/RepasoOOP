using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoOOP
{
    public class Viviendas
    {
        public string tipo;
        public string nombre;
        public string direcc;
        public string distrito;
        public string provincia;
        public string region;
        public string pais;
        public string area;

        public Viviendas(string tipo, string nombre, string direcc, string distrito, string provincia, string region, string pais, string area) 
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
    }
}
