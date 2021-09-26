using MetalBandBakery.PriceServicesWebAPI.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace MetalBandBaket.PriceServicesWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PricesController : ControllerBase
    {
        private readonly ILogger<PricesController> _logger;

        public PricesController(ILogger<PricesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<ItemPrice> Get()
        {
            IItemPriceRepository repository = new ItemPriceRepository();
            var p = repository.GetAll();
            return p;
        }

        [HttpGet("{itemId}")]
        public ItemPrice Get(string itemId)
        {
            IItemPriceRepository repository = new ItemPriceRepository();
            var itemPrice = repository.Get(itemId);
            return itemPrice;
        }
    }
}