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
            List<Product> currentProducts = pickUpService.GetCurrentProducts();
            //
            string purchaseOp = "";
            decimal insertedCoins = 0;
            decimal totalBuy = 0;
            decimal aux = 0;
            Product selProduct = null;
            Dictionary<Product, int> selProducts = null;
            //
            while (true)
            {
                //Initialice variables
                purchaseOp = "";
                insertedCoins = 0;
                totalBuy = 0;
                Console.WriteLine(ShowProducts(sb, currentProducts, binddingService, stockService));

                //Get Option and Validate it
                purchaseOp = Console.ReadLine().ToUpper();
                if (purchaseOp == null || purchaseOp == "")
                {
                    Console.WriteLine("Incorrect Optión... Try Again.");
                    continue;
                }

                //1 Item Buy Option
                if (purchaseOp.Length == 1 && 
                    (purchaseOp == "B" || purchaseOp == "C" || purchaseOp == "W" || purchaseOp == "M"))
                {
                    selProduct = PickUpProductService._currentProducts[purchaseOp[0]];
                    insertedCoins = InsertCoins(insertedCoins, selProduct._price);
                    pickUpService.PickProduct(selProduct, insertedCoins);
                    continue;
                }

                //1+ Items Buy Option
                if (purchaseOp.Length > 1)
                {
                    string[] splitProducts = purchaseOp.Split(",");
                    if (splitProducts.Length == 0 || splitProducts == null) {
                        Console.WriteLine("Opción Incorrecta... Empiece de nuevo");
                        continue;
                    }

                    selProducts = FillProductsQuantity(splitProducts);
                    totalBuy = GetTotalBuy(selProducts);
                    insertedCoins = InsertCoins(insertedCoins, totalBuy);
                    pickUpService.PickProducts(selProducts, insertedCoins);
                    continue;
                }
            }
        }
        public static string ShowProducts(StringBuilder sb, List<Product> currentProducts,
                            IBinddingProductServiceable binddingService, IStockProductServiceable stockService)
        {
            sb = new StringBuilder();
            sb.Append("Items to purchase...(B,B,W,C)\n");
            foreach (var i in currentProducts)
            {
                sb.Append($"{binddingService.GetProductShort(i)} | ");
                sb.Append($"{i.ToString()}$ ");
                sb.Append($"Stock: {stockService.GetProductStock(i).ToString()}\n");
            }
            return sb.ToString();
        }
        public static decimal InsertCoins(decimal insertedCoins, decimal totalBuy)
        {
            decimal aux = 0;
            while (insertedCoins < totalBuy)
            {
                aux = 0;
                Console.WriteLine($"Insert coins {insertedCoins.ToString()}/{totalBuy.ToString()}$");
                aux = Decimal.Parse(Console.ReadLine(), NumberStyles.Any, CultureInfo.InvariantCulture);
                insertedCoins += aux;
            }

            return insertedCoins;
        }      
        public static decimal GetTotalBuy(Dictionary<Product, int> selProducts)
        {
            decimal totalBuy = 0;
            foreach (var j in selProducts)
            {
                decimal aux1 = j.Value * j.Key._price;
                totalBuy = totalBuy + aux1;
            }
            return totalBuy;
        }
        public static Dictionary<Product, int> FillProductsQuantity(string[] splitProducts)
        {
            Dictionary<Product, int> selProducts = new Dictionary<Product, int>();
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
                }
                else
                {
                    selProducts.Add(p, 1);
                }
            }
            return selProducts;
        }
    }
}
