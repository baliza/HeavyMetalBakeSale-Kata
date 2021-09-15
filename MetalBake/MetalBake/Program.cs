using MetalBake.Builders;
using MetalBake.Models;
using MetalBake.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MetalBake
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = ContainerBuilder.Build();
            IPickUpProductServiceable pickUpService = container.GetService<IPickUpProductServiceable>();
            IBinddingProductServiceable binddingService = container.GetService<IBinddingProductServiceable>();
            IStockProductServiceable stockService = container.GetService<IStockProductServiceable>();

            StringBuilder sb = null;
            //
            List<Product> currentProducts = pickUpService.GetCurrentProducts();     
            string purchaseOp = "";
            decimal insertedCoins = 0;
            decimal totalBuy = 0;
            //
            Product selProduct = null;
            Dictionary<Product, int> selProducts = null;
            //
            while (true)
            {
                purchaseOp = "";
                insertedCoins = 0;
                totalBuy = 0;

                sb = new StringBuilder();
                foreach (var i in currentProducts)
                {
                    sb.Append($"{binddingService.GetProductShort(i)} | ");
                    sb.Append($"{i.ToString()}$ ");
                    sb.Append($"Stock: {stockService.GetProductStock(i).ToString()}\n");
                }
                //
                
                Console.WriteLine("Items to purchase...(B,B,W,C)");
                Console.WriteLine(sb.ToString());
                purchaseOp = Console.ReadLine();

                if (purchaseOp == null || purchaseOp == "")
                {
                    Console.WriteLine("Opción Incorrecta... Empiece de nuevo");
                    continue;
                }

                if (purchaseOp.Length == 1 && (purchaseOp == "B" || purchaseOp == "C" || purchaseOp == "W" || purchaseOp == "M"))
                {
                    selProduct = PickUpProductService._currentProducts[purchaseOp[0]];
                    insertedCoins = 0;
                    decimal aux = 0.00m;
                    while (insertedCoins < selProduct._price)
                    {
                        aux = 0.00m;
                        Console.WriteLine($"Insert coins {insertedCoins.ToString()}/{selProduct._price.ToString()}$");
                        aux = Decimal.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
                        insertedCoins += aux;
                    }

                    pickUpService.PickProduct(selProduct, insertedCoins);
                    continue;
                }

                if (purchaseOp.Length > 1)
                {
                    var splitProducts = purchaseOp.Split(",");
                    if (splitProducts.Length == 0 || splitProducts == null) {
                        Console.WriteLine("Opción Incorrecta... Empiece de nuevo");
                        continue;
                    }

                    selProducts = new Dictionary<Product, int>();
                    foreach (var i in splitProducts)
                    {
                        if (i != "B" && i != "M" && i != "C" && i != "W")
                        {
                            Console.WriteLine("Opción Incorrecta... Empiece de nuevo");
                            break;
                        }
                        Product p = PickUpProductService._currentProducts[i[0]];

                        if (selProducts.ContainsKey(p))
                        {
                            int aux2 = selProducts[p];
                            selProducts[p] = aux2 + 1;
                        } else
                        {
                            selProducts.Add(p, 1);
                        }
                    }
                    foreach (var j in selProducts)
                    {
                        decimal aux1 = j.Value * j.Key._price;
                        totalBuy = totalBuy + aux1;
                    }

                    insertedCoins = 0;
                    decimal aux = 0.00m;
                    while (insertedCoins < totalBuy)
                    {
                        aux = 0.00m;
                        Console.WriteLine($"Insert coins {insertedCoins.ToString()}/{totalBuy.ToString()}$");
                        aux = Decimal.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
                        insertedCoins += aux;
                    }

                    pickUpService.PickProducts(selProducts, insertedCoins);
                }
            }
        }
    }
}
