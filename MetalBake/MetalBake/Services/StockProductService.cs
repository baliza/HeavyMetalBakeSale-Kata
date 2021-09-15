using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    class StockProductService : IStockProductServiceable
    {
        /// <summary>
        /// Max Stock Will Be 25.
        /// </summary>
        public static Dictionary<Product, int> _currentStock = Setup();

        private static Dictionary<Product, int> Setup()
        {
            List<Product> products = new List<Product>();
            foreach(var i in PickUpProductService._currentProducts.Values)
            {
                products.Add(i);
            }
            Dictionary<Product, int> currentStock = new Dictionary<Product, int>(4);
            currentStock.Add(products[0], 10);
            currentStock.Add(products[1], 10);
            currentStock.Add(products[2], 10);
            currentStock.Add(products[3], 10);

            return currentStock;
        }

        public int GetProductStock(Product product)
        {
            return _currentStock[product];
        }

        public bool IsInStock(Product product, int quantity)
        {
            if (_currentStock[product] > 0)
            {
                int aux = _currentStock[product] - quantity;
                if (aux >= 0)
                {
                    return true;
                }
            }
            return false;
        }

        public bool AddStock(Product product, int quantity)
        {
            try
            {
                if (_currentStock[product] < 25)
                {
                    if ((_currentStock[product] + quantity) <= 25)
                    {
                        _currentStock[product] = _currentStock[product] + quantity;
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveUnit(Product product)
        {
            try
            {
                if (_currentStock[product] > 0)
                {
                    _currentStock[product] = _currentStock[product] - 1;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool RemoveUnitMultiple(Product product, int quantity)
        {
            try
            {
                if (_currentStock[product] > 0 && (_currentStock[product]-quantity) > 0)
                {
                    _currentStock[product] = _currentStock[product] - quantity;
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
