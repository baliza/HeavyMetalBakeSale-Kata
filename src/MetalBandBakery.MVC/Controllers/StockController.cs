using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using MetalBandBakery.ManagerLibrary;
using MetalBandBakery.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MetalBandBakery.ManagerLibrary.RestFull;
using MetalBandBakery.ManagerLibrary.Local;

namespace MetalBandBakery.MVC.Controllers
{
    public class StockController : Controller
    {
        private static ManagerBandBakery _managerBandBakery = new ManagerBandBakery();

        // GET: Stock
        public ActionResult Index()
        {
            List<Item> itemList = new List<Item>();
            List<OrderLine> orderList = _managerBandBakery.MemoryGetAllStock();
            foreach (var order in orderList)
            {
                itemList.Add(new Item(order.ItemId, order.Amount, _managerBandBakery.GetPrice(order.ItemId)));
            }
            return View(itemList);
        }

        public ActionResult Edit(string id)
        {
            var repice = _managerBandBakery.GetRepice(id);
            var stock = (from s in _managerBandBakery.MemoryGetAllStock()
                         where s.ItemId == id
                         select s).FirstOrDefault();
            Item item = new Item(stock.ItemId, stock.Amount, _managerBandBakery.GetPrice(stock.ItemId));

            return View(item);
        }

        public ActionResult SetStockBake(Item item)
        {
            _managerBandBakery.MemorySetStock(item.ItemId, item.Quantity);
            return Redirect("Index");
        }
    }
}