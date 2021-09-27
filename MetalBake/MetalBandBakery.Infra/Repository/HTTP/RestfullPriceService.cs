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
            string apiUrl = "https://localhost:44351/prices";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/{itemId}");
                var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(json);
                return itemPrice.price;
            }
        }

        public List<ItemPrice> GetAllItems()
        {
            string apiUrl = "https://localhost:44351/prices";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString(apiUrl);
                var itemList = JsonConvert.DeserializeObject<List<ItemPrice>>(json);
                return itemList;
            }
        }

        public bool UpdatePrice(string id, decimal newPrice)
        {
            string apiUrl = "https://localhost:44351/prices/setPrice";
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                ItemPrice itemToUpdate = new ItemPrice() { itemId = id, price = newPrice };
                string data = JsonConvert.SerializeObject(itemToUpdate);
                client.UploadString(apiUrl, data);
                return true;
            }
        }
    }
}