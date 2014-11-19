using OSIM.Common.Models;
using OSIM.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIM.Services.Logic
{
    public class ItemService : IItemService
    {
        private IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }
        public List<Item> GetAll()
        {
            return _itemRepository.GetAll();
        }

        public void Add(Item item)
        {
           _itemRepository.Add(item);
        }
    }
}
