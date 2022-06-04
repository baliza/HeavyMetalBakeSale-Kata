using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiPricesService.Repositories
{
    public interface IPriceRepository
    {
        ItemPrice GetItemPrice(string itemId);

        List<ItemPrice> GetAllPrices();

        bool UpdateItemPrice(ItemPrice item);
    }
}