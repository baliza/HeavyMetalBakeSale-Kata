using System;
using System.Collections.Generic;
using System.Text;
namespace MetalBake
{
    class Program
    {
        public static Dictionary<string, decimal> productsPrice = new Dictionary<string, decimal>()
        {
            {"B",0.65m },
            {"M",1.00m },
            {"C",1.35m },
            {"W",1.50m }

        };

        static void Main(string[] args)
        {
            string[] keys = ItemsToPurchase();
            StockService stockService = new StockService();
            stockService.CheckStock(keys);
            TotalToPay(keys);
            decimal amountToPay = AmountToPaid();
            decimal totalToPay = TotalToPay(keys);
            CalculateChange(amountToPay,totalToPay);
        }

        private static decimal CalculateChange(decimal amount,decimal total)
        {
            if(amount < 0)
            {
                Console.WriteLine("You haven't enough money");
            }
            if (amount == 0)
            {
                Console.WriteLine("Not return money.");
            }
            decimal totalChange = Math.Abs(total - amount);
            Console.WriteLine($"Your change is : {totalChange}");
            return totalChange;
        }

        private static decimal AmountToPaid()
        {
            Console.WriteLine("Put amount to pay:");
            decimal amountToPay = Convert.ToDecimal(Console.ReadLine());
            return amountToPay;
        }

        public static decimal TotalToPay(string[] itemId)
        {
            decimal total = 0;
            foreach (var item in itemId)
            {
                total = total + productsPrice[item];
            }
            Console.WriteLine($"Amount to paid:{total}$");
            return total;
        }

        public static string[] ItemsToPurchase()
        {
            Console.WriteLine($@"Choose a product:
                            B  |  Brownie  |  0.65$
                            M  |  Mufflin  |  1.00$
                            C  | Cacke Pop |  1.35$
                            W  |   Water   |  1.50$");
            string[] keysPickUp = Console.ReadLine().ToUpper().Split(",");
            return keysPickUp;
        }
    }
}
