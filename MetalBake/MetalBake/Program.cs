using System;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Bienvenido a la tienda de pasteles: Seleccione la opción que desea realizar:
    1-Comprar
    2-Ver stock
    3-Ver precios");
            var option = Console.ReadLine();

            Console.WriteLine("Items to Purchase?");
            var order = Console.ReadLine();

            //Check si hay stock
            //Respuesta de precio total de la compra

            Console.WriteLine("Con cuánto dinero pagarás?");
            var importe = Console.ReadLine();

            //CalculateChange
            
        }
    }
}
