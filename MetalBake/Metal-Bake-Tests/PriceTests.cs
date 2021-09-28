//using MetalBake.Services;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using System;
//using System.Collections.Generic;
//using System.Text;

//namespace Metal_Bake_Tests
//{
//    [TestClass]
//    public class PriceTests
//    {
//        PriceService service = new PriceService();
//        private Dictionary<char, decimal> _listPrices = new Dictionary<char, decimal>
//        { {'B', 0.65m } };
//        [TestMethod]
//        public void Test_Get_Item_Price()
//        {
//            char key = 'B';
//            Assert.AreEqual(1, _listPrices[key]);
//        }

//        [TestMethod]
//        public void Test_No_Item_Price()
//        {
//            char key = '@';
//            Assert.ThrowsException<KeyNotFoundException>(() => _listPrices[key]);
//        }
//    }
//}
