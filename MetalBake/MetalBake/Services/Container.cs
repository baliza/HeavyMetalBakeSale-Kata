using MetalBake.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class Container
    {
        public IServiceProvider Build()
        {
            return new ServiceCollection()
                .AddSingleton<IChangeService, ChangeService>()
                .AddSingleton<IStockService, StockService>()
                .AddSingleton<IPriceService, PriceService>()
                .AddSingleton<IOrderManagerService, OrderManagerService>()
                .BuildServiceProvider();
        }
    }
}