using MetalBake.frm.ServiceReference1;
using MetalBake.frm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalBake.frm
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var orderManagerService = new OrderManagerService();
            try
            {
                orderManagerService.MakeAnOrder();
                Console.ReadLine();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}