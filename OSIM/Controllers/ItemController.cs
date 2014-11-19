using System.Linq;
using System.Web.Mvc;
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
    }
}