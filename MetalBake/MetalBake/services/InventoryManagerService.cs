using MetalBake.models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBake.services
{
    class InventoryManagerService
    {
        private CakePop _cakePop;
        private Muffin _muffin;
        private Water _water;
        private Brownie _brownie;

        public InventoryManagerService(CakePop cakePop, Muffin muffin, Water water, Brownie brownie)
        {
            _cakePop = cakePop;
            _muffin = muffin;
            _water = water;
            _brownie = brownie;
        }

        public decimal SumItemPrices(char[] totalItems)
        {
            decimal total = 0;
            foreach (var item in totalItems)
            {
                if (item.Equals('C'))
                {
                    if (_cakePop.stock > 0)
                    {
                        total += _cakePop.price;
                        _cakePop.stock--;
                    }
                    else
                    {
                        Console.WriteLine("No queda stock de Cake Pop");
                    }
                }
                else if (item.Equals('B'))
                {
                    if (_brownie.stock > 0)
                    {
                        total += _brownie.price;
                        _brownie.stock--;
                    }
                    else
                    {
                        Console.WriteLine("No queda stock de Brownie");
                    }
                }
                else if (item.Equals('M'))
                {
                    if(_muffin.stock > 0)
                    {
                        total += _muffin.price;
                        _muffin.stock--;
                    }
                    else
                    {
                        Console.WriteLine("No queda stock de Brownie");
                    }
                }
                else if (item.Equals('W'))
                {
                    if (_water.stock > 0)
                    {
                        total += _water.price;
                        _water.stock--;
                    } else
                    {
                        Console.WriteLine("No queda stock de Brownie");
                    }
                }
                else
                {
                    Console.WriteLine($"El producto {item} no existe");
                }
            }
            return total;
        }
    }

}
