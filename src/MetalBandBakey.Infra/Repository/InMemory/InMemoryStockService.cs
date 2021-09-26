using MetalBandBakery.Core.Domain;
using MetalBandBakery.Core.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace MetalBandBakey.Infra.Repository
{
    public class InMemoryStockService : IStockService
    {
        private Dictionary<string, int> _stock;

        public InMemoryStockService()
        {
            ReadStock();
        }

        private void ReadStock()
        {
            StreamReader sReader = new StreamReader(@"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBakery.InventoryWCF\App_Code\Archives\Stock.json");
            var json = sReader.ReadToEnd();
            _stock = JsonConvert.DeserializeObject<Dictionary<string, int>>(json);
            sReader.Close();
        }

        public void SetStock(string itemId, int quantity)
        {
            if (Exists(itemId))
            {
                _stock[itemId] = quantity;
                File.WriteAllText(@"C:\Users\gteam\source\repos\Etapa2\HeavyMetalBakeSale-Project\src\MetalBandBakery.InventoryWCF\App_Code\Archives\Stock.json",
                        JsonConvert.SerializeObject(_stock));
            }
        }

        public bool CheckStock(string itemId)
        {
            if (!Exists(itemId))
                return false;
            return _stock[itemId] > 0;
        }

        public List<OrderLine> GetAllStock()
        {
            List<OrderLine> orderList = new List<OrderLine>();
            OrderLine oLine;
            foreach (var stockItem in _stock)
            {
                oLine = new OrderLine(stockItem.Key);
                oLine.Amount = stockItem.Value;
                orderList.Add(oLine);
            }
            return orderList;
        }

        public int GetStock(string itemId)
        {
            if (!Exists(itemId))
                return -1;
            return _stock[itemId];
        }

        public void ReduceStock(string itemId)
        {
            if (Exists(itemId))
                _stock[itemId]--;
        }

        private bool Exists(string itemId)
        {
            return _stock.ContainsKey(itemId);
        }
    }
}