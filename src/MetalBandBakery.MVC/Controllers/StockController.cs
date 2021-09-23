using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using MetalBandBakery.MVC.Models;
using MetalBandBakey.Infra.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBandBakery.MVC.Controllers
{
    public class StockController : Controller
    {
        private static IStockService _stockService = new InMemoryStockService();
        private static IPriceService _priceService = new InMemoryPriceService();

        // GET: Stock
        public ActionResult Index()
        {
            List<Item> itemList = new List<Item>();
            List<OrderLine> orderList = _stockService.GetAllStock();
            foreach (var order in orderList)
            {
                itemList.Add(new Item(order.ItemId, order.Amount, _priceService.GetPrice(order.ItemId)));
            }
            return View(itemList);
        }

        public ActionResult Edit(string id)
        {
            var price = _priceService.GetPrice(id);
            var stock = (from s in _stockService.GetAllStock()
                         where s.ItemId == id
                         select s).FirstOrDefault();
            Item item = new Item() { ItemId = id, Price = price, Quantity = stock.Amount };
            return View(item);
        }

        public ActionResult SetBake(Item item)
        {
            _stockService.SetStock(item.ItemId, item.Quantity);
            return Redirect("Index");
        }
    }
}