using MetalBake.core.Models;
using MetalBake.core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.infra
{
    public class RestfulPriceService : IPriceService
    {
        public decimal GetItemPrice(string itemId)
        {
            string apiUrl = "https://localhost:44339/prices";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jsonResponse = client.DownloadString($"{apiUrl}/{itemId}");
                var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(jsonResponse);
                return itemPrice.Price;
            }
        }

        public List<ItemPrice> GetAllPrices()
        {
            string apiUrl = "https://localhost:44339/prices";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jsonResponse = client.DownloadString($"{apiUrl}");
                var ListitemPrices = JsonConvert.DeserializeObject<List<ItemPrice>>(jsonResponse);
                return ListitemPrices;
            }
        }

        public bool UpdateItemPrice(string itemId, int stock)
        {
            throw new NotImplementedException();
        }
    }
}