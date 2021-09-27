using MetalBakeMVC.Models;
using MetalBakeMVC.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MetalBakeMVC.Controllers
{
    public class ProductController : Controller
    {
        //No me funcionan las rutas relativas por algún motivo

        private static string _url = @"https://localhost:44330/";
        private static string _pricePath = @"C:\Users\nettrim\Source\Repos\HeavyMetalBakeSale-Kata2\src\MetalBakeMVC\App_Data\price.json";
        private static string _stockPath = @"C:\Users\nettrim\Source\Repos\HeavyMetalBakeSale-Kata2\src\MetalBakeMVC\App_Data\stock.json";
        private static Dictionary<string, int> _stock = SetUpStock();
        private static Dictionary<string, decimal> _prices = SetUpPrice().Result;

        private static Dictionary<string, int> SetUpStock()
        {
            using (StreamReader sr = new StreamReader(_stockPath))
            {
                var stockJson = sr.ReadToEnd();
                Dictionary<string, int> stock = JsonConvert.DeserializeObject<Dictionary<string, int>>(stockJson);
                return stock;
            }
        }

        private async static Task<Dictionary<string, decimal>> SetUpPrice()
        {
            using (StreamReader sr = new StreamReader(_pricePath))
            {
                var priceJson = sr.ReadToEnd();
                Dictionary<string, decimal> price = JsonConvert.DeserializeObject<Dictionary<string, decimal>>(priceJson);
                return price;
            }
        }

        // GET: Product
        public ActionResult Index()
        {
            var prodList = new ProductList() { stock = _stock, prices = _prices };
            return View(prodList);
        }

        public ActionResult Edit(string id)
        {
            var prod = new Product() { id = id, price = _prices[id], stock = _stock[id] };
            return View(prod);
        }

        public ActionResult EditPrice(string newPrice, string id)
        {
            decimal newValue = 0;
            Decimal.TryParse(newPrice, out newValue);
            if (newValue != 0)
            {
                _prices[id] = newValue;
                string updatedPrice = JsonConvert.SerializeObject(_prices);
                System.IO.File.WriteAllText(_pricePath, updatedPrice);
            }
            return Redirect("Index");
        }
    }
}