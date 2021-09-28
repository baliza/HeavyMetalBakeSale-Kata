using Metal_Bake_Framework.Interfaces;
using Metal_Bake_Library.Services;
using MetalBake.core.Interfaces;
using MetalBake.core.Services;
using MetalBake.Services;
using MetalBakeMVCFront.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MetalBakeMVCFront.Controllers
{
    public class OrderController : Controller
    {
        private IItemService _itemService = new ItemService();
        private IStockService _stockService = new StockService();
        private IPriceService _priceService = new PriceService();
        private IOrderService _orderService = new OrderService();
        public List<Tuple<string, int>> order = new List<Tuple<string, int>>();
        public ActionResult Index()
        {
            
            List<ItemIndex> ListOfItems = new List<ItemIndex>();
            var names = _itemService.GetItemList();
            var price = _priceService.GetAllPrices();
            var stock = _stockService.GetAllStock();
            foreach (var item in names)
            {
                var prices = price.FirstOrDefault(i => i.ItemId == item.GetShort());
                var stocks = stock.FirstOrDefault(i => i.ItemId == item.GetShort());
                var newItem = new ItemIndex { ItemId = item.GetShort(), Name = item.GetName(), Price = prices.Price, Amount = stocks.Amount };
                ListOfItems.Add(newItem);
            }
            return View(ListOfItems);
        }
        public ActionResult AddToCart(ItemOrder cart)
        {
            order.Add(new Tuple<string, int>(cart.ItemId, cart.Quantity));
            ViewBag.Order = order;
            return View();
        }
        public ActionResult MakeOrder(List<Tuple<string, int>> order)
        {
            Cart cart = new Cart();
            //cart.Order = order.Add(i => new ItemOrder() { ItemId = , Quantity = });
            var buy = _orderService.MakeOrder(order);
            cart.CartPrice = buy.CalculateOrderPrice();
            ViewBag.Price = cart.CartPrice;
            return View(cart.CartPrice);
        }
    }
}