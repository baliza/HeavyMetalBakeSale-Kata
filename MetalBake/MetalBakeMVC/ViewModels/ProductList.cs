using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using static MetalBandBakery.Infra.Repository.HTTP.RestfullPriceService;

namespace MetalBakeMVC.ViewModels
{
    public class ProductList
    {
        public Dictionary<string, int> stock;
        public List<ItemPrice> prices;
    }
}