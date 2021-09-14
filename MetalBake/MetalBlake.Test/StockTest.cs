using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBlake.Test
{
    [TestClass]
    public class StockTest
    {
        StockService service = new StockService();
     
        [TestMethod]
        public void Test_Check_Stock_Zero()
        {
            char key = 'B';
            while(service.GetItemStock(key) > 0)
            {
                service.ReduceItemStock(key);
            }
            Assert.ThrowsException<Exception>(() => service.CheckItemStock(key));
        } 
        
        [TestMethod]
        public void Test_Check_Reduce_Stock()
        {
            char key = 'C';

            int previousStock = service.GetItemStock(key);
            service.ReduceItemStock(key);
            int actualStock = service.GetItemStock(key);
            Assert.AreEqual(previousStock - 1, actualStock);
        }

    }
}
