using MetalBandBakery.Core.Services;
using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace MetalBandBakey.Infra.Repository
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
                if (itemPrice == null)
                    return -1;
                return itemPrice.price;
            }
        }

        public void UpdatePrice(string itemId, decimal newPrice)
        {
            string apiUrl = "https://localhost:44330/prices/UpdatePrice";

            using (WebClient client = new WebClient())
            {
                client.Headers["Content-type"] = "application/json";
                client.Encoding = Encoding.UTF8;
                ItemPrice iPrice = new ItemPrice() { itemId = itemId, price = newPrice };
                string json = client.UploadString($"{apiUrl}", JsonConvert.SerializeObject(iPrice));
            }
        }

        /*public void UpdatePrice(string itemId, decimal quantity)
		{
			string apiUrl = "https://localhost:44330/prices/UpdatePrice";

			using (WebClient client = new WebClient())
			{
				client.Headers["Content-type"] = "application/json";
				client.Encoding = Encoding.UTF8;
				string json = client.DownloadString($"{apiUrl}/UpdatePrice");
				var itemPrice = JsonConvert.DeserializeObject<ItemPrice>(json);
			}
		}*/
    }
}