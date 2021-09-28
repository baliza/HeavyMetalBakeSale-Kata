//using MetalBake.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Metal_Bake_Tests
//{
//    [TestClass]
//    public class StockTests
//    {
//        StockService service = new StockService();
//        private Dictionary<char, int> _inventory = new Dictionary<char, int>
//        { {'B', 5 } };

//        [TestMethod]
//        public void Test_Check_NoStock()
//        {
//            char key = 'B';
//            while (_inventory[key] > 0)
//            {
//                service.ReduceStock(key,1);
//            }
//            Assert.ThrowsException<Exception>(()=>service.CheckStock(key,1));
//        }
//        [TestMethod]
//        public void Test_Check_Reduce_Stock()
//        {
//            char key = 'B';
//            int previousStock = _inventory[key];
//            service.ReduceStock(key, 1);
//            int actualStock = _inventory[key];
//            Assert.AreEqual(previousStock - 1, actualStock);
//        }
//    }
//}