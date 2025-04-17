using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoOOP
{
    public class Documentos
    {
        public string tipo;
        public string numero;
        public DateOnly fechaemis;
        public DateOnly fechavenc;

        public Documentos(string tipo, string numero, DateOnly fechaemis, DateOnly fechavenc)
        {
            this.tipo = tipo;
            this.numero = numero;
            this.fechaemis = fechaemis;
            this.fechavenc = fechavenc;
        }
    }
}
