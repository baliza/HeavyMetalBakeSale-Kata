using MetalBake.Interfaces;
using MetalBake.Models;
using MetalBake.Services;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;
using ServiceReference1;

namespace MetalBake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var service = new ServiceClient();

            var container = new Container().Build();
            var orderManagerService = container.GetService<IOrderManagerService>();
            try
            {
                orderManagerService.MakeAnOrder();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}