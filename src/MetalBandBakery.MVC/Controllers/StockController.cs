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
        private static IPriceService _priceService = new RestfullPriceService();

        // GET: Stock
        public ActionResult Index()
        {
            List<Item> itemList = new List<Item>();
            List<OrderLine> orderList = _stockService.GetAllStock();
            foreach (var order in orderList)
            {
                var repice = _priceService.GetRepice(order.ItemId);
                itemList.Add(new Item(order.ItemId, order.Amount, _priceService.GetPrice(order.ItemId)));
            }
            return View(itemList);
        }

        public ActionResult Edit(string id)
        {
            var repice = _priceService.GetRepice(id);
            var stock = (from s in _stockService.GetAllStock()
                         where s.ItemId == id
                         select s).FirstOrDefault();
            Item item = new Item(stock.ItemId, stock.Amount, _priceService.GetPrice(stock.ItemId));

            return View(item);
        }

        public ActionResult SetStockBake(Item item)
        {
            _stockService.SetStock(item.ItemId, item.Quantity);
            return Redirect("Index");
        }
    }
}