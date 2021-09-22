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
        
        public ActionResult PriceList()
        {
            List<ItemPrice> price = new List<ItemPrice>();
            price.Add(new ItemPrice() { ItemId = "B", Price = 0.65m, Name = "Brownie" });
            price.Add(new ItemPrice() { ItemId = "W", Price = 0.65m, Name = "Water" });
            price.Add(new ItemPrice() { ItemId = "C", Price = 0.65m, Name = "Cake Pop" });
            price.Add(new ItemPrice() { ItemId = "M", Price = 0.65m, Name = "Muffin" });
            return View();
        }
    }
}