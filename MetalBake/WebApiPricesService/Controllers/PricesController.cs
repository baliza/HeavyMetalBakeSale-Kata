using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPricesService.Repositories;

namespace WebApiPricesService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PricesController : ControllerBase
    {
        private readonly ILogger<PricesController> _logger;
        private IPriceRepository _priceRepository;

        public PricesController(ILogger<PricesController> logger)
        {
            _logger = logger;
            _priceRepository = new PriceRepository();
        }

        [HttpGet]
        public List<ItemPrice> GetAllPrices()
        {
            return _priceRepository.GetAllPrices();
        }

        [HttpGet("{itemId}")]
        public ItemPrice GetItemPrice(string itemId)
        {
            return _priceRepository.GetItemPrice(itemId);
        }

        [Route("updatePrice")]
        [HttpPost]
        public bool UpdateItemPrice(ItemPrice item)
        {
            return _priceRepository.UpdateItemPrice(item);
        }

        //Post Jesús
        [HttpPost("setPrice")]
        public bool SetPrice([FromBody] ItemPrice item)
        {
            return _priceRepository.UpdateItemPrice(item);
        }
    }
}