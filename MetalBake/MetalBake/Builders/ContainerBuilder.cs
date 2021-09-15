using MetalBake.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Builders
{
    class ContainerBuilder
    {
        public static IServiceProvider Build()
        {
            var ServiceProvider = new ServiceCollection()
                .AddSingleton<IPickUpProductServiceable, PickUpProductService>()
                .AddSingleton<IStockProductServiceable, StockProductService>()
                .AddSingleton<IPaymentServiceable, PaymentService>()
                .AddSingleton<ICoinsServiceable, CoinsService>()         
                .AddSingleton<IBinddingProductServiceable, BinddingProductService>();

            return ServiceProvider.BuildServiceProvider();
        }
    }
}
