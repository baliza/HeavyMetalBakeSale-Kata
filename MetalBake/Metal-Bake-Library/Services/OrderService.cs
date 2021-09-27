using Metal_Bake_Framework.Interfaces;
using Metal_Bake_Framework.Models;
using MetalBake.core.Interfaces;
using MetalBake.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_Bake_Library.Services
{
    public class OrderService : IOrderService
    {
        private IPriceService _priceService = new PriceService();
        private IStockService _stockService = new StockService();

        public Order MakeOrder(List<Tuple<string, int>> quantityToBuy)
        {
            Order order = new Order();

            foreach (var item in quantityToBuy)
            {
                if (!_stockService.CheckStock(item.Item1,item.Item2))
                {
                    return null;
                }
                if (order.itemsInCart.Exists(i => i.Id == item.Item1))
                {
                    ItemOrder product = order.itemsInCart.FirstOrDefault(i => i.Id == item.Item1);
                    product.Amount += item.Item2;
                }
                else
                {
                    ItemOrder product = new ItemOrder { Id = item.Item1, Amount = item.Item2, Price = _priceService.GetPrice(item.Item1) };
                    order.AddItemOrder(product);
                }
            }
            return order;
        }
        public List<string> CompletePurchaseChart(Order order)
        {
            ReduceOrderStock(order.itemsInCart);
            return null;
        }
        private void ReduceOrderStock(List<ItemOrder> cart)
        {
            foreach (var orderLine in cart)
            {
                _stockService.ReduceStock(orderLine.Id, orderLine.Amount);
            }
        }
    }
}
