/*using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    public class ServiceContainer
    {
        public static IServiceProvider Build()
        {
            var container = new ServiceCollection()
                .AddSingleton<IInventoryService, InventoryService>()
                .AddSingleton<IRepaymentCalculator, RepaymentCalculator>();
            return container.BuildServiceProvider();
        }
    }
}
*/