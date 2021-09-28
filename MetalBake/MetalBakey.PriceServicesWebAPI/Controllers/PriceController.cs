using MetalBakey.PriceServicesWebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MetalBakey.PriceServicesWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PriceController : ControllerBase
    {
        private IPriceRepository repository = new PriceRepository();

        [HttpGet("/prices")]
        public List<ItemPrice> Get()
        {
            return repository.GetAllPrices();
        }
        [HttpGet("/prices/{itemId}")]
        public decimal Get(string itemId)
        {
            return repository.GetPrice(itemId);
        }
        [Route("setPrice")]
        [HttpPost]
        public decimal Prices(ItemPrice item)
        {
            repository.SetPrice(item);
            return repository.GetPrice(item.ItemId);
        }
    }
}
