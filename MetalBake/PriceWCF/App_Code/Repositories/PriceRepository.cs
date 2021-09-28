using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;

public class PriceRepository : IPriceRepository
{
    private static Dictionary<string, decimal> _listPrices;
    static PriceRepository()
    {
        _listPrices = new Dictionary<string, decimal>
            {
            { "B", 0.65m },
            { "M", 1.00m},
            { "C", 1.35m },
            { "W", 1.50m }
            };
    }
    public decimal CalculateOrderPrice(Dictionary<string, int> orderList)
    {
        decimal totalPrice = 0;
        foreach (var item in orderList)
        {
            totalPrice += item.Value * _listPrices[item.Key];
        }
        return totalPrice;
    }
    public decimal GetPrice(string key)
    {
        foreach (var item in _listPrices)
        {
            if (key.Equals(item.Key))
            {
                return item.Value;
            }
        }
        return 0;
    }
    public List<ItemPrice> GetAllPrices()
    {
        return _listPrices.Select(x => new ItemPrice
        {
            ItemId = x.Key,
            Price = x.Value
        }).ToList();
    }
    public decimal SetPrice(ItemPrice item)
    {
        _listPrices[item.ItemId] = item.Price;
        return item.Price;
    }
    public void TxtListPrice()
    {
        string json = new JavaScriptSerializer().Serialize(GetAllPrices());
        string url = @"C:\Users\nettrim\Documents\Writer\Local\PricesList.txt";
        File.WriteAllText(url, json);
    }
}