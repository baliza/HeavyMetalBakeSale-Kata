using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    class OrderService : IOrderable
    {
        public List<Tuple<string, int>> MakeOrder(string lectura)
        {
            int b = 0; int m = 0; int c = 0; int w = 0;
            string[] splitOrder = lectura.Split(',');
            foreach (var item in splitOrder)
            {
                switch (item)
                {
                    case "B": b++;
                        break;
                    case "M": m++;
                        break;
                    case "C": c++;
                        break;
                    case "W": w++;
                        break;
                }
            }
            List<Tuple<string, int>> orderList = new List<Tuple<string, int>>();
            orderList.Add(new Tuple<string, int>("B", b));
            orderList.Add(new Tuple<string, int>("M", m));
            orderList.Add(new Tuple<string, int>("C", c));
            orderList.Add(new Tuple<string, int>("W", w));
            return orderList;
        }
    }
}
