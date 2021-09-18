using MetalBake.interfaces;
using MetalBake.models;
using MetalBake.services;
using System;
using System.Text;

namespace MetalBake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            InventoryManagerService ims = new InventoryManagerService();
            PurchaseService ps = PurchaseService.GetInstance();
            Console.WriteLine("Introduce los productos que quieras comprar");
            string selectedItems = Console.ReadLine();
            StringBuilder receipt = new StringBuilder();
            string orderItems = ims.InventoryFilter(selectedItems);
            decimal totalPrice = ps.OrderPrice(orderItems);
            Console.WriteLine($"Precio total: ${totalPrice}");
            receipt.Append($"Items a comprar > {orderItems}, Total > ${totalPrice}");
            Console.WriteLine("Introducir dinero");
            decimal payed = 0;
            Decimal.TryParse(Console.ReadLine(), out payed);
            receipt.Append($", Pagado > ${payed}");
            if (payed >= totalPrice)
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
            Console.WriteLine(receipt.ToString());
        }
    }
}