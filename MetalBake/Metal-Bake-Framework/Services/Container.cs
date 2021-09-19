using MetalBake.Interfaces;
using MetalBake;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class Container
    {
        public static IServiceProvider Build()
        {
            var container = new ServiceCollection()
                .AddSingleton<IStockService, StockService>()
                .AddSingleton<IOrderable, OrderService>()
                .AddSingleton<IItemService, ItemService>()
                .AddSingleton<IPriceService, PriceService>()
                .AddSingleton<IChangeService, ChangeService>();
            return container.BuildServiceProvider();
        }
    }
}
