using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    public class Order
    {
        private List<Products> productList;
        private decimal total;

        public Order()
        {
            productList = new List<Products>();
        }
    }
}
