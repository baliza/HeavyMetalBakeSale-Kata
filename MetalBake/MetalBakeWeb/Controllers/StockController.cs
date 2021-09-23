using MetalBake.core.Services;
using MetalBake.infra;
using MetalBakeWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBakeWeb.Controllers
{
    public class StockController : Controller
    {
        private IStockService _wcfStockService = new StockService();

        // GET: Stock
        public ActionResult Index()
        {
            List<ItemStock> stock = _wcfStockService.GetAllStock().Select(item => new ItemStock { ItemId = item.ItemId, Stock = item.Stock }).ToList();
            return View(stock);
        }

        [HttpPost]
        public ActionResult Edit(string itemId)
        {
            ItemStock item = new ItemStock { ItemId = itemId, Stock = _wcfStockService.GetItemStock(itemId) };
            return View(item);
        }

        [HttpPost]
        public ActionResult SetNewStock(ItemStock item)
        {
            _wcfStockService.SetItemStock(item.ItemId, item.Stock);
            return Redirect("Index");
        }
    }
}