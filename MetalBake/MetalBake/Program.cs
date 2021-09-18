using MetalBake.Interfaces;
using MetalBake.Models;
using MetalBake.Services;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection;

namespace MetalBake
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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