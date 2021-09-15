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
                .AddSingleton<IStockable, StockService>()
                .AddSingleton<IOrderable, OrderService>()
                .AddSingleton<IItemServable, ItemService>()
                .AddSingleton<IPriceable, PriceService>()
                .AddSingleton<IChangeable, ChangeService>();
            return container.BuildServiceProvider();
        }
    }
}
