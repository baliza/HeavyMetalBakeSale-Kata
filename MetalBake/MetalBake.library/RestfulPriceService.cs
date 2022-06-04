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
        private readonly string _apiUrl = "https://localhost:44339/prices";

        public decimal GetItemPrice(string itemId)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jsonResponse = client.DownloadString($"{_apiUrl}/{itemId}");
                var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(jsonResponse);
                return itemPrice.Price;
            }
        }

        public List<ItemPrice> GetAllPrices()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string jsonResponse = client.DownloadString($"{_apiUrl}");
                var ListItemPrices = JsonConvert.DeserializeObject<List<ItemPrice>>(jsonResponse);
                return ListItemPrices;
            }
        }

        public bool UpdateItemPrice(string itemId, decimal newPrice)
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                var itemPrice = new ItemPrice();
                itemPrice.ItemId = itemId;
                itemPrice.Price = newPrice;
                var bodyJson = JsonConvert.SerializeObject(itemPrice);
                var ApiResponse = client.UploadString($"{_apiUrl}/updatePrice", bodyJson);
                return bool.Parse(ApiResponse);
            }
        }
    }
}