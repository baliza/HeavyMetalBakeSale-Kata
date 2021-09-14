using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.models
{
    class ShoppingCart
    {
        public string itemList;
        public decimal totalPrice;

        public ShoppingCart(string itemList, decimal totalPrice)
        {
            this.itemList = itemList;
            this.totalPrice = totalPrice;
        }
    }
}
