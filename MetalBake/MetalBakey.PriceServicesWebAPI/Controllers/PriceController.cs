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

        [HttpGet("/prices")]
        public List<ItemPrice> Get()
        {
            IPriceRepository repository = new PriceRepository();
            return repository.GetAllPrices();
        }
        [HttpGet("/prices/{itemId}")]
        public decimal Get(string itemId)
        {
            IPriceRepository repository = new PriceRepository();
            return repository.GetPrice(itemId);
        }
        [HttpPost("/{itemId}/{itemPrice}")]
        public decimal SetPrice(string itemId, decimal itemPrice)
        {
            IPriceRepository repository = new PriceRepository();
            repository.SetPrice(itemId, itemPrice);
            return repository.GetPrice(itemId);
        }
    }
}
