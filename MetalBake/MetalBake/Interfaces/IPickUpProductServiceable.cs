using MetalBake.Models;
using System.Collections.Generic;

namespace MetalBake.Services
{
    interface IPickUpProductServiceable
    {
        void PickProduct(Product product, decimal totalCoins);
        void PickProducts(Dictionary<Product, int> products, decimal totalCoins);
        List<Product> GetCurrentProducts();
    }
}