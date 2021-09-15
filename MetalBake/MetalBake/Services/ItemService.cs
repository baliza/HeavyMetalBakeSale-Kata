using MetalBake.Interfaces;
using MetalBake.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    class ItemService : IItemServable
    {
        private readonly IStockable _stockService;
        private readonly IPriceable _priceService;

        public ItemService(IStockable stockService, IPriceable priceService)
        {
            _stockService = stockService;
            _priceService = priceService;
        }
        public void PrintItemList()
        {
            //StockService stockService = new StockService();
            //PriceService priceService = new PriceService();

            foreach (var item in GetItemList())
            {
                Console.WriteLine($"Product: {item.GetShort()} - {item.GetName()} - Stock: {_stockService.GetStock(item.GetShort()[0])} - Price: {_priceService.GetPrice(item.GetShort()[0])} eur");
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
    }
}
