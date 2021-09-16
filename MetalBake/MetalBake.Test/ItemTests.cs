using MetalBake.Models;
using MetalBake.Services;
using NUnit.Framework;
using System.Linq;

namespace MetalBake.Test
{
    public class Tests
    {
        Inventory inventory;
        [SetUp]
        public void Setup()
        {
            inventory = new Inventory();
        }
        [Test]
        public void Test_Item_With_Correct_Price()
        {
            Item item = new Item('1',"2",1);

            foreach(var copyItem in inventory.ItemList)
            {
                if(copyItem.Code == 'M')
                {
                    item = copyItem;
                }
            }
            Assert.AreEqual(1.20,PieMarketService.GetPrice(item));
        }
        [Test]
        public void Test_Item_Correct_ToString()
        {
            Item expectedItem = new Item('M', "Muffin", 2);
            var actual = from n in inventory.ItemList where n.Code.Equals('M') select n;
            Item item = new Item('1', "2", 1);
            foreach (var item2 in actual)
            {
                item = item2;
            }
            Assert.AreEqual(expectedItem.ToString(), item.ToString());
        }
    }
}