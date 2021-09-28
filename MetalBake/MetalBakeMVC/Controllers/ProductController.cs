using MetalBakeMVC.Models;
using MetalBakeMVC.ViewModels;
using MetalBandBakery.Infra.Repository.HTTP;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using static MetalBandBakery.Infra.Repository.HTTP.RestfullPriceService;

namespace MetalBakeMVC.Controllers
{
    public class ProductController : Controller
    {
        //No me funcionan las rutas relativas por algún motivo

        private static string _stockPath = @"C:\Users\nettrim\Source\Repos\HeavyMetalBakeSale-Kata2\src\MetalBakeMVC\App_Data\stock.json";
        private static Dictionary<string, int> _stock;
        private static List<ItemPrice> _prices;

        private static Dictionary<string, int> SetUpStock()
        {
            using (StreamReader sr = new StreamReader(_stockPath))
            {
                var stockJson = sr.ReadToEnd();
                Dictionary<string, int> stock = JsonConvert.DeserializeObject<Dictionary<string, int>>(stockJson);
                return stock;
            }
        }

        private static List<ItemPrice> SetUpPrice()
        {
            RestfullPriceService ps = new RestfullPriceService();
            return ps.GetAllItems();
        }

        // GET: Product
        public ActionResult Index()
        {
            _prices = SetUpPrice();
            _stock = SetUpStock();
            var prodList = new ProductList() { stock = _stock, prices = _prices };
            return View(prodList);
        }

        public ActionResult Edit(string id)
        {
            RestfullPriceService ps = new RestfullPriceService();
            var prod = new Product() { id = id, price = ps.GetPrice(id), stock = _stock[id] };
            return View(prod);
        }

        public ActionResult EditPrice(string newPrice, string id)
        {
            RestfullPriceService ps = new RestfullPriceService();
            decimal newValue = 0;
            Decimal.TryParse(newPrice, out newValue);
            if (newValue != 0)
                ps.UpdatePrice(id, newValue);

            return Redirect("Index");
        }
    }
}