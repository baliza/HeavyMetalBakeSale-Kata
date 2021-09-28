using Metal_Bake.Infra.WcfPriceReference;
using MetalBake.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metal_Bake.Infra.HTTP
{
    public class SoapPriceService : IPriceService
    {
        WcfPriceReference.IService _pvc;
        public SoapPriceService()
        {
            _pvc = new WcfPriceReference.ServiceClient();
        }

        public decimal CalculateOrderPrice(Dictionary<string, int> orderList)
        {
            return _pvc.CalculateOrderPrice(orderList);
        }

        public void SetPrice(ItemPrice item)
        {
            _pvc.SetPrice(item);
        }
        public decimal GetPrice(string key)
        {
            return _pvc.GetPrice(key);
        }

        public List<ItemPrice> GetAllStock()
        {
            return _pvc.GetAllPrices().Select(x => new ItemPrice() { ItemId = x.ItemId, Price = x.Price }).ToList();
        }

        public List<MetalBake.core.Models.ItemPrice> GetAllPrices()
        {
            throw new NotImplementedException();
        }

        public decimal SetPrice(MetalBake.core.Models.ItemPrice item)
        {
            throw new NotImplementedException();
        }
    }
}
