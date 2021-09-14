using MetalBake.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.Models
{
    class Order
    {
        public List<Tuple<char, int>> orderList;
        public List<Tuple<char, int>> MakeOrder(string lectura)
        {
            int b=0; int m=0; int c=0; int w=0;
            string[] splitOrder = lectura.Split(@",");
            foreach (var item in splitOrder)
            {
                if (item.Equals("B"))
                {
                    b++;
                }
                if (item.Equals("M"))
                {
                    m++;
                }
                if (item.Equals("C"))
                {
                    c++;
                }
                if (item.Equals("W"))
                {
                    w++;
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
