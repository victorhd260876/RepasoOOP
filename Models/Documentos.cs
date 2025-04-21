

namespace RepasoOOP;

    public class Documentos
    {
        public string tipo = "Factura";
        public string numero = "F01-123";


        public void Estado()
        {
            Console.WriteLine("Cancelado");

        }

        public virtual void TipoVenta()
        {
            Console.WriteLine("Contado");  
        }
        public virtual void Proveedor()
        {
            Console.WriteLine("GLORIA");
        }

}

