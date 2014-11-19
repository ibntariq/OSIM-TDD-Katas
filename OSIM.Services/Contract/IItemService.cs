using OSIM.Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSIM.Services.Contract
{
    public interface IItemService
    {
        List<Item> GetAll();
        void Add(Item item);
    }
}
