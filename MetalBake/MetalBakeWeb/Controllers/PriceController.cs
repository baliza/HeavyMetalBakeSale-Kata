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
    public class PriceController : Controller
    {
        private IPriceService _restfulPriceService = new RestfulPriceService();

        // GET: Price
        public ActionResult Index()
        {
            List<ItemPrice> prices = _restfulPriceService.GetAllPrices().Select(item => new ItemPrice { ItemId = item.ItemId, Price = item.Price }).ToList(); ;
            return View(prices);
        }

        [HttpPost]
        public ActionResult Edit(string itemId)
        {
            ItemPrice item = new ItemPrice { ItemId = itemId, Price = _restfulPriceService.GetItemPrice(itemId) };
            return View(item);
        }

        [HttpPost]
        public ActionResult SetNewPrice(ItemPrice item)
        {
            _restfulPriceService.UpdateItemPrice(item.ItemId, item.Price);
            return Redirect("Index");
        }
    }
}