
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Order
    {
        public List<Item> BuyItemsList;
        public decimal TotalPrice;

        public Order(List<Item> itemsList)
        {
            BuyItemsList = itemsList;
          
        }
    }
}
