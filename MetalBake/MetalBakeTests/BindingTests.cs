using MetalBake.Models;
using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MetalBakeTests
{
    [TestClass]
    public class BindingTests
    {
        [TestMethod]
        public void GetProductShort_Ok()
        {
            BinddingProductService binddingProductService = new BinddingProductService();
            char expected = 'B';
            char actual = binddingProductService.GetProductShort(PickUpProductService._currentProducts['B']);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetProductShort_Fail()
        {
            BinddingProductService binddingProductService = new BinddingProductService();
            char expected = 'C';
            char actual = binddingProductService.GetProductShort(PickUpProductService._currentProducts['B']);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void GetProductShort_Null()
        {
            BinddingProductService binddingProductService = new BinddingProductService();
            Assert.ThrowsException<ArgumentNullException>(
                () => binddingProductService.GetProductShort(null)
                );
            /*
            char expected = 'B';
            try
            {
                char actual = binddingProductService.GetProductShort(null);
                Assert.AreEqual(expected, actual);
                Assert.Fail("no exception thrown");
            } catch (Exception ex)
            {
                Assert.IsTrue(ex is ArgumentNullException);
            }
            */
        }
    }
}
