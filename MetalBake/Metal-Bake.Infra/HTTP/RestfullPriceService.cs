using MetalBake.Interfaces;
using MetalBake.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Metal_Bake.Infra.HTTP
{
    public class RestfullPriceService : IPriceService
    {
        public class ItemPrice
        {
            public string ItemId { get; set; }
            public decimal Price { get; set; }
            public string Name { get; set; }
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
                return itemPrice.Price;
            }
        }
        public List<ItemPrice> GetAllPrices()
        {
            string apiUrl = "https://localhost:44330/prices";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{apiUrl}/");
                List<ItemPrice> itemPrice = new List<ItemPrice>();
                itemPrice.Add(JsonConvert.DeserializeObject<ItemPrice>(json));
                return itemPrice;
            }
        }
        public decimal CalculateOrderPrice(List<Tuple<string, int>> orderList)
        {
            throw new NotImplementedException();
        }

        List<PriceService.ItemPrice> IPriceService.GetAllPrices()
        {
            throw new NotImplementedException();
        }
    }
}
