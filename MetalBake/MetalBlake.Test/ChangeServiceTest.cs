using MetalBake.Interfaces;
using MetalBake.Models;
using MetalBake.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetalBlake.Test
{
    [TestClass]
    public class ChangeServiceTest
    {
        public IChangeService GetSut()
        {
            return new ChangeService();
        }

        [TestMethod]
        public void Test_Get_Change()
        {
            Assert.AreEqual(2, GetSut().GetChange(4, 6));
        }

        [TestMethod]
        public void Test_Get_Change_Without_Enougth_Money()
        {
            Assert.AreEqual(-1, GetSut().GetChange(4, 2));
        }
    }
}