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
    public class PriceController : Controller
    {
        private IPriceService _restfulPriceService = new RestfulPriceService();

        // GET: Price
        public ActionResult Index()
        {
            List<ItemPrice> prices = _restfulPriceService.GetAllPrices();
            return View(prices);
        }
    }
}