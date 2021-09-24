using Metal_Bake_Framework;
using MetalBake.Interfaces;
using MetalBake.Services;
using MetalBakeMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBakeMVC.Controllers
{
    public class StockController : Controller
    {
        private IStockService _wcfStockService = new StockService();
        public ActionResult StockList()
        {
            List<ItemStock> stockList = new List<ItemStock>(_wcfStockService.GetAllStock()
                .Select(item => new ItemStock() { ItemId = item.ItemId, Name = item.Name, Amount = item.Amount }));
            return View(stockList);


            /*List<ItemStock> stock = new List<ItemStock>();
            stock.Add(new ItemStock() { ItemId = "B", Amount = 40, Name = "Brownie" });
            stock.Add(new ItemStock() { ItemId = "W", Amount = 36, Name = "Water" });
            stock.Add(new ItemStock() { ItemId = "C", Amount = 24, Name = "Cake Pop" });
            stock.Add(new ItemStock() { ItemId = "M", Amount = 32, Name = "Muffin" });
            return View(stock);*/
        }
    }
}