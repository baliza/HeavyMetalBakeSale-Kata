using MetalBake.Interfaces;
using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBlake.Test
{
    [TestClass]
    public class StockServiceTest
    {
        public IStockService GetSut()
        {
            return new StockService();
        }

        [TestMethod]
        public void Test_Check_Stock_Zero()
        {
            string itemId = "B";
            IStockService stockService = GetSut();
            while (stockService.GetItemStock(itemId) > 0)
            {
                stockService.ReduceItemStock(itemId);
            }
            Assert.AreEqual(-1, stockService.GetItemStock(itemId));
        }

        [TestMethod]
        public void Test_Check_Reduce_Stock()
        {
            string itemId = "C";
            IStockService stockService = GetSut();
            int previousStock = stockService.GetItemStock(itemId);
            stockService.ReduceItemStock(itemId);
            int actualStock = stockService.GetItemStock(itemId);
            Assert.AreEqual(previousStock - 1, actualStock);
        }
    }
}