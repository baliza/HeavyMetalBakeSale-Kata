using MetalBake.core.Interfaces;
using MetalBake.core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.core.Services
{
    public class ItemService : IItemService
    {
        private readonly IStockService _stockService;
        private readonly IPriceService _priceService;

        //public ItemService(IStockService stockService, IPriceService priceService)
        //{
        //    _stockService = stockService;
        //    _priceService = priceService;
        //}
        public void PrintItemList()
        {
            //StockService stockService = new StockService();
            //PriceService priceService = new PriceService();
            foreach (var item in GetItemList())
            {
                Console.WriteLine($"Product: {item.GetShort()} - {item.GetName()} - Stock: {_stockService.GetStock(item.GetShort())} - Price: {_priceService.GetPrice(item.GetShort())} eur");
            }
        }
        public List<Item> GetItemList()
        {
            List<Item> itemList = new List<Item>();
            itemList.Add(new Item("B", "Brownie"));
            itemList.Add(new Item("C", "Cake Pop"));
            itemList.Add(new Item("W", "Water"));
            itemList.Add(new Item("M", "Muffin"));
            return itemList;
        }
        public string GetItem(string id)
        {
            Item item = GetItemList().FirstOrDefault(x => x.GetShort() == id);
            return item.GetName();
        }
    }
}
