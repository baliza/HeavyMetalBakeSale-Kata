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
            while (GetSut().GetItemStock(key) > 0)
            {
                GetSut().ReduceItemStock(key);
            }
            Assert.ThrowsException<Exception>(() => GetSut().CheckItemStock(key));
        }

        [TestMethod]
        public void Test_Check_Reduce_Stock()
        {
            char key = 'C';

            int previousStock = GetSut().GetItemStock(key);
            GetSut().ReduceItemStock(key);
            int actualStock = GetSut().GetItemStock(key);
            Assert.AreEqual(previousStock - 1, actualStock);
        }
    }
}