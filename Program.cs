namespace RepasoOOP;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");
        //var Viviendas = new Viviendas(); // Instanciando clase con var
        var Recibos = new Recibos();

        Console.WriteLine(Recibos.tipo);
        Recibos.TipoVenta();

        var Ticket = new Ticket();
        Ticket.TipoVenta();

        

    }
}
