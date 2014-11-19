using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Moq;
using Ninject;
using NUnit.Framework;
using OSIM.Client.Controllers;
using OSIM.Client.DIModule;
using OSIM.Common.Models;
using OSIM.Services.Contract;
using OSIM.Services.DIModule;

namespace OSIM.Tests.OSIM.Client.Tests
{
    [TestFixture]
    public class ItemControllerTests
    {
        private Mock<IItemService> _itemService;
        private ItemController _itemController;

        [SetUp]
        public void SetUpTests()
        {
            _itemService = new Mock<IItemService>();
            _itemService.Setup(s => s.GetAll()).Returns(
               new List<Item>
                {
                    new Item(), new Item(), new Item() 
                });

            _itemController = new ItemController(_itemService.Object);
        }

        [Test]
        public void Should_Return_Instance_Of_Item_Controller_Using_Ninject()
        {
            ItemController actual;
            var kernel = new StandardKernel(new ClientModule(), new OSIMModule());

            actual = kernel.Get<ItemController>();

            Assert.IsNotNull(actual);
        }

        [Test]
        public void Should_Return_List_Of_Items()
        {
            var result = _itemController.List() as ViewResult;
            var model = result.Model as IEnumerable<Item>;

            Assert.AreEqual(3, model.Count());
        }

        [Test]
        public void Should_Redirect_To_List_Action_If_Model_State_Is_Valid()
        {
            Item item = new Item{ Name = "Table" , Quantity = 340};
            string expectedAction = "List";
            _itemController.ModelState.Clear();

            var result = _itemController.Add(item) as RedirectToRouteResult;

            Assert.AreEqual(expectedAction, result.RouteValues["action"], "Item Could Not Be Inserted.");
        }

        [Test]
        public void Should_Render_Add_View_With_Data_If_Model_State_Is_Invalid()
        {
            Item item = new Item();
            string expectedView = "Add";
            _itemController.ModelState
                .AddModelError("Model Error", "Model State is not valid");

            var result = _itemController.Add(item) as ViewResult;

            Assert.IsNotNull(result.Model, "Model was returned to the view.");
        }
    }
}
