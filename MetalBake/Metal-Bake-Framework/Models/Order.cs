using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_Bake_Framework.Models
{
    public class Order
    {
        public List<ItemOrder> itemsInCart;
        public Order()
        {
            itemsInCart = new List<ItemOrder>();
        }
        public decimal CalculateOrderPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in itemsInCart)
            {
                totalPrice += (item.Amount * item.Price);
            }
            return totalPrice;
        }
        public void AddItemOrder(ItemOrder order)
        {
            itemsInCart.Add(order);
        }
        public void RemoveItemOrder(ItemOrder order)
        {
            itemsInCart.Remove(order);
        }
    }
}
