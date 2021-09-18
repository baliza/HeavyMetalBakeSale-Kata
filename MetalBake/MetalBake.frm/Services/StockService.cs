using MetalBake.frm.Interfaces;
using MetalBake.frm.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm.Services
{
    public class StockService : IStockService
    {
        private ServiceClient _serviceWCF = new ServiceClient();

        public int GetItemStock(string itemId)
        {
            return _serviceWCF.GetItemStock(itemId);
        }

        public void ReduceItemStock(string itemId)
        {
            _serviceWCF.ReduceItemStock(itemId);
        }
    }
}