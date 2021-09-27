using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBakeMVC.Controllers
{
    public class AddToCartController : Controller
    {
        private Dictionary<string, int> _itemList;

        // GET: AddToCart
        public ActionResult Add(string id)
        {
            if (Session["list"] == null)
            {
                _itemList = new Dictionary<string, int>();
                _itemList.Add(id, 1);
                Session["list"] = _itemList;
                Session["count"] = 1;
            }
            else
            {
                _itemList = (Dictionary<string, int>)Session["list"];
                if (!_itemList.ContainsKey(id))
                    _itemList.Add(id, 0);
                _itemList[id]++;
                var count = _itemList.Select(y => y.Value).Sum();
                Session["count"] = count;
            }
            return RedirectToAction("Index", "Product");
        }
    }
}