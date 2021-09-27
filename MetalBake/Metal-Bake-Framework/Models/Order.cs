using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_Bake_Framework.Models
{
    public class Order
    {
        public List<ItemOrder> itemsInChart;
        public Order()
        {
            itemsInChart = new List<ItemOrder>();
        }
        public decimal CalculateOrderPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in itemsInChart)
            {
                totalPrice += (item.Amount * item.Price);
            }
            return totalPrice;
        }
        public void AddItemOrder(ItemOrder order)
        {
            itemsInChart.Add(order);
        }
        public void RemoveItemOrder(ItemOrder order)
        {
            itemsInChart.Remove(order);
        }
    }
}
