using Metal_Bake.Infra.HTTP;
using MetalBake.Interfaces;
using MetalBakeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBake.MVCControllers
{
    public class PriceController : Controller
    {
        private IPriceService _restPriceService = new RestfullPriceService();
        public ActionResult PriceList()
        {
            List<ItemPrice> pricesList = _restPriceService.GetAllPrices();
            return View(pricesList);
            //List<ItemPrice> price = new List<ItemPrice>();
            //price.Add(new ItemPrice() { ItemId = "B", Price = 0.65m, Name = "Brownie" });
            //price.Add(new ItemPrice() { ItemId = "W", Price = 0.65m, Name = "Water" });
            //price.Add(new ItemPrice() { ItemId = "C", Price = 0.65m, Name = "Cake Pop" });
            //price.Add(new ItemPrice() { ItemId = "M", Price = 0.65m, Name = "Muffin" });
            //return View(price);
        }
    }
}