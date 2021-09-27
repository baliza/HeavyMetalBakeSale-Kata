using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PricesController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

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

        [Route("setPrice")]
        [HttpPost]
        public void SetItemPrice([FromBody] ItemPrice item)
        {
            ItemPriceRepository repository = new ItemPriceRepository();
            repository.PostUpdatePrice(item);
        }
    }
}