using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBakeMVC.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Index()
        {
            var list = Session["list"];
            if (list != null)
                return View(list);
            return RedirectToAction("Index", "Product");
        }
    }
}