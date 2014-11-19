using Moq;
using Ninject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSIM.Common.Models;
using OSIM.Services.Contract;
using OSIM.Services.DIModule;
using OSIM.Services.Logic;

namespace OSIM.Tests.OSIM.Services.Tests
{
    [TestFixture]
    public class ItemServiceTests
    {
        private Mock<IItemRepository> _itemRepository;
        private ItemService _itemService;


        [SetUp]
        public void SetTests()
        {
            _itemRepository = new Mock<IItemRepository>();
            _itemService = new ItemService(_itemRepository.Object);
        }

        [Test]
        public void Should_Return_Instance_Of_Item_Service_Using_Ninject()
        {
            ItemService actual;
            var kernel = new StandardKernel(new OSIMModule());
            actual = kernel.Get<ItemService>();

            Assert.IsNotNull(actual, "Failed to instantiate ItemService");
        }

        [Test]
        public void Should_Return_List_Of_Items()
        {
            _itemRepository.Setup(ir => ir.GetAll()).Returns(
                new List<Item>()
                {
                    new Item(), new Item(), new Item()
                });

            var items = _itemService.GetAll();

            Assert.AreEqual(3, items.Count, "Items were not returned.");
        }
    }
}
