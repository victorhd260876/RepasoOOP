using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoOOP;
    public class Ticket:Documentos
{
    public string NotaCredito;

    public override void TipoVenta()
    {
        Console.WriteLine("Ticket en Consignacion ");
    }

    public override void Proveedor()
    {
        Console.WriteLine("PROVEEDOR DE TICKET");
    } 
    
}
