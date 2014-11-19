using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OSIM.Common.Models;
using OSIM.Services.Contract;

namespace OSIM.Client.Controllers
{
    public class ItemController : Controller
    {
        private IItemService _itemService;

        public ItemController(IItemService itemService)
        {
            _itemService = itemService;
        }

        public ActionResult List()
        {
            return View(_itemService.GetAll().AsEnumerable());
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Item item)
        {
            if (ModelState.IsValid)
            {
                _itemService.Add(item);

                return RedirectToAction("List");
            }
            else
            {
                return View(item);
            }
        }
    }
}