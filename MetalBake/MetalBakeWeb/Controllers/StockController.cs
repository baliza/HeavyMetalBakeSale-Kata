using MetalBake.core.Models;
using MetalBake.core.Services;
using MetalBake.infra;
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
            List<ItemStock> stock = _wcfStockService.GetAllStock();
            return View(stock);
        }
    }
}