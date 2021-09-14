using MetalBake.interfaces;
using MetalBake.models;
using MetalBake.services;
using System;
using System.Text;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            InventoryManagerService ims = new InventoryManagerService(new CakePop(), new Muffin(), new Water(), new Brownie());
            PurchaseService ps = PurchaseService.GetInstance();
            Console.WriteLine("Introduce los productos que quieras comprar");
            string shoppingCart = Console.ReadLine();
            StringBuilder receipt = new StringBuilder();
            char[] totalItems = shoppingCart.Replace(",", string.Empty).ToCharArray();
            decimal totalPrice = ims.SumItemPrices(totalItems);
            Console.WriteLine(@$"Precio total: {totalPrice}
¿Comprar?
y/n");
            string validation = Console.ReadLine();
            if (validation.Equals("y"))
            {
                receipt.Append($"Items a comprar > {shoppingCart}, Total > ${totalPrice}");
                Console.WriteLine("Introducir dinero");
                decimal payed = 0;
                Decimal.TryParse(Console.ReadLine(), out payed);
                receipt.Append($", Pagado > ${payed}");
                if(payed >= totalPrice)
                {
                    decimal exchange = ps.Purchase(totalPrice, payed);
                    if (exchange != 0)
                    {
                        receipt.Append($", Cambio > ${exchange}");
                    }
                    receipt.Append(", Operación completada");
                }
                else
                {
                    receipt.Append(", No es suficiente");
                }
            }
            Console.WriteLine(receipt.ToString());
        }
    }
}
