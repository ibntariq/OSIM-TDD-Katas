using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OSIM.Common.Models;

namespace OSIM.Services.Contract
{
    public interface IItemRepository
    {
        List<Item> GetAll();
        void Add(Item item);
    }
}
