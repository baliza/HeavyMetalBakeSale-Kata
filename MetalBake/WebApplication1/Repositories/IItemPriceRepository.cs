using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Repositories
{
    public interface IItemPriceRepository
    {
        ItemPrice Get(string itemId);

        System.Collections.Generic.List<ItemPrice> GetAll();

        void PostUpdatePrice(string item);
    }
}