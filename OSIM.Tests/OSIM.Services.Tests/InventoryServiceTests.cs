using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace OSIM.Tests.OSIM.Services.Tests
{
    [TestFixture]
    public class InventoryServiceTests
    {
        [Test]
        public void Should_Be_Able_To_Login_Inventory()
        {
            var result = inventoryService.Login(inventoryItem);

            Assert.AreEqual(result, inventoryItem);
        }
    }
}
