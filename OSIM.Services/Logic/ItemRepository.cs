using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OSIM.Common.Models;
using OSIM.Services.Contract;
using OSIM.Services.DbEntities;

namespace OSIM.Services.Logic
{
    public class ItemRepository : IItemRepository
    {
        private OSIMDb _osimDb;
        public ItemRepository(OSIMDb osimDb)
        {
            _osimDb = osimDb;
        }

        public List<Item> GetAll()
        {
            return _osimDb.Items.ToList();
        }

        public void Add(Item item)
        {
            var addedItemID = _osimDb.Items.Add(item);
            _osimDb.SaveChanges();
        }
    }
}
