
using MetalBake.core.Interfaces;
using MetalBake.Services;
using MetalBakeMVCFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBakeMVCFront.Controllers
{
    public class PriceController : Controller
    {
        private IPriceService _wcfPriceService = new PriceService();
        public ActionResult PriceList()
        {
            List<ItemPrice> priceList = new List<ItemPrice>(_wcfPriceService.GetAllPrices()
                .Select(item => new ItemPrice() { ItemId = item.ItemId, Name = item.Name, Price = item.Price }));
            return View(priceList);


            /*private IPriceService _restPriceService = new RestfullPriceService();
            public ActionResult PriceList()
            {
                List<ItemPrice> pricesList = new List<ItemPrice>(_restPriceService.GetAllPrices()
                    .Select(item => new ItemPrice() { ItemId = item.ItemId, Name = item.Name, Price = item.Price }));
                return View(pricesList);*/

            /*List<ItemPrice> price = new List<ItemPrice>();
            price.Add(new ItemPrice() { ItemId = "B", Price = 0.65m, Name = "Brownie" });
            price.Add(new ItemPrice() { ItemId = "W", Price = 0.65m, Name = "Water" });
            price.Add(new ItemPrice() { ItemId = "C", Price = 0.65m, Name = "Cake Pop" });
            price.Add(new ItemPrice() { ItemId = "M", Price = 0.65m, Name = "Muffin" });
            return View(price);*/
        }
    }
}