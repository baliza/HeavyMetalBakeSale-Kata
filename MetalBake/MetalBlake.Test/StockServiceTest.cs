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
            char key = 'B';
            while (GetSut().GetItemStock(itemId) > 0)
            {
                GetSut().ReduceItemStock(itemId);
            }
            Assert.ThrowsException<Exception>(() => GetSut().CheckItemStock(itemId));
        }

        [TestMethod]
        public void Test_Check_Reduce_Stock()
        {
            char key = 'C';

            int previousStock = GetSut().GetItemStock(itemId);
            GetSut().ReduceItemStock(itemId);
            int actualStock = GetSut().GetItemStock(itemId);
            Assert.AreEqual(previousStock - 1, actualStock);
        }
    }
}