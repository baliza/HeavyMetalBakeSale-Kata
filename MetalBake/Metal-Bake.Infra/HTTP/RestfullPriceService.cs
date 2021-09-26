using MetalBake.core.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


namespace Metal_Bake.Infra.HTTP
{
    public class RestfullPriceService //: IPriceService
    {
        /*private readonly string _apiUrl = "https://localhost:44330/prices";

        public class ItemPrice
        {
            public string ItemId { get; set; }
            public decimal Price { get; set; }
            public string Name { get; set; }
        }

        public decimal GetPrice(string itemId)
        {

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{_apiUrl}/{itemId}");
                var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(json);
                return itemPrice.Price;
            }
        }
        public List<ItemPrice> GetAllPrices()
        {
            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                string json = client.DownloadString($"{_apiUrl}/");
                List<ItemPrice> itemPrice = new List<ItemPrice>();
                itemPrice.Add(JsonConvert.DeserializeObject<ItemPrice>(json));
                return itemPrice;
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
        public decimal CalculateOrderPrice(List<Tuple<string, int>> orderList)
        {
            throw new NotImplementedException();
        }
        List<MetalBake.core.Models.ItemPrice> IPriceService.GetAllPrices()
        {
            throw new NotImplementedException();
        }
        */
    }
}
