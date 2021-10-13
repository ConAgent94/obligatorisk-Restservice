using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Restservice.Managers;
using Restservice.Models;

namespace RestserviceTests.Managers
{
    [TestClass()]
    public class ItemsManagerTests
    {
        

        [TestMethod()]
        public void GetAllTest()
        {
            ItemsManager manager = new ItemsManager();
            List<Item> all = manager.GetAll();
            Assert.AreEqual(2, all.Count);

            Item ny = new Item() { Id = 2 };
            Item ny3 = new Item() {Id = 3, };
            manager.Add(ny3);
            Item ny2 = manager.Add(ny);
            Assert.AreEqual(ny.Id, ny2.Id);
            Assert.AreEqual(2, ny2.Id);
        }

        //[TestMethod()]
        //public void GetByIdTest()
        //{
        //    ItemsManager manager = new ItemsManager();
        //}

        //[TestMethod()]
        //public void AddTest()
        //{
        //    Assert.Fail();
        //}

    }
}
