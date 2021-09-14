using MetalBake.Models;
using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace MetalBlake.Test
{
    [TestClass]
    public class FactoryTest
    {

        [TestMethod]
        public void Test_Create_Item()
        {
            Item item = ItemsFactory.CreateItem('B');
            Assert.IsInstanceOfType(item, typeof(Item));
        }  
        
        
        [TestMethod]
        public void Test_Create_Item_Fail()
        {
            Assert.ThrowsException<KeyNotFoundException>(() => ItemsFactory.CreateItem('H'));
        }
    }
}
