using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class BinddingProductService : IBinddingProductServiceable
    {
        public static Dictionary<Product, char> _currentBindings = Setup();

        private static Dictionary<Product, char> Setup()
        {
            List<Product> list = new List<Product>();
            foreach (var i in PickUpProductService._currentProducts.Values)
            {
                list.Add(i);
            }
            Dictionary<Product, char> currentBindings = new Dictionary<Product, char>(list.Count);
            currentBindings.Add(list[0], 'B');
            currentBindings.Add(list[1], 'M');
            currentBindings.Add(list[2], 'C');
            currentBindings.Add(list[3], 'W');

            return currentBindings;
        }

        public char GetProductShort(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException();
            }
            return _currentBindings[product];
        }
    }
}
