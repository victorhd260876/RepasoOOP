namespace RepasoOOP;
public class Recibos : Documentos
{
     
    
        public string tipo = "Recibo";

        public override void TipoVenta()
        {
            Console.WriteLine("Credito"); 
        }
        public override void Proveedor()
        {
            Console.WriteLine("COCA COLA");
        }

}
