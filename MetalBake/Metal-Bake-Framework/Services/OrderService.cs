using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Services
{
    class OrderService : IOrderable
    {
        public List<Tuple<char, int>> MakeOrder(string lectura)
        {
            int b=0; int m=0; int c=0; int w=0;
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
            List<Tuple<char, int>> orderList = new List<Tuple<char, int>>();
            orderList.Add(new Tuple<char,int>('B', b));
            orderList.Add(new Tuple<char, int>('M', m));
            orderList.Add(new Tuple<char, int>('C', c));
            orderList.Add(new Tuple<char, int>('W', w));
            return orderList;
        }                
    }
}
