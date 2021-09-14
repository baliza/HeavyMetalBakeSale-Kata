using System;
using System.Collections.Generic;
using System.Text;
using MetalBake.Models;
using MetalBake.Services
namespace MetalBake.Services
{
    public class StockService : IStockService
    {
        public static Dictionary<Products, int> _ProductStock = Setup();
        private static Dictionary<Products, int> Setup()
        {
            var ProductStock = new Dictionary<Products, int>();
            ProductStock.Add(new Products("Brownie", "B", 0.65m), 40);
            ProductStock.Add(new Products("Mofflin", "M", 1.0m), 36);
            ProductStock.Add(new Products("Cacke", "C", 1.35m), 24);
            ProductStock.Add(new Products("Water", "W", 1.50m), 30);
            return ProductStock;
        }

        public bool IsInStock(Products product)
        {
            /*Console.WriteLine("Call get on database");*/
            return _ProductStock[product] > 0;
        }
        public Products GetProductFromKey(string key)
        {
            foreach (Products product in _ProductStock.Keys)
            {
                if (key.Equals(product._Key.ToString()))
                {
                    return product;
                }
            }
            return null;
        }
        public void ReduceStock(Products product)
        {
            /*Console.WriteLine("Call get on database");*/
            _ProductStock[product]--;
            if (_ProductStock[product] <= 2)
            {
                Console.WriteLine("Call to shipping api");
            }
        }
        public void AddStock(Products product)
        {
            /* Console.WriteLine("Call get on database");*/
            _ProductStock[product]++;
        }

    }
}
