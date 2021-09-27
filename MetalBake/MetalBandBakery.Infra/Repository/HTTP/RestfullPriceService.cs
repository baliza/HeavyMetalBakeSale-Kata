using MetalBandBakery.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetalBandBakery.Infra.Repository.HTTP
{
    public class RestfullPriceService : IPriceService
    {
        public class ItemPrice
        {
            public string itemId { get; set; }
            public decimal price { get; set; }
        }

        public decimal GetPrice(string itemId)
        {
            string apiUrl = "https://localhost:44330/prices";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{itemId}");
                var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(json);
                return itemPrice.price;
            }
        }
    }
}