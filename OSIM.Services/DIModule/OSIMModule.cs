using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using OSIM.Services.Contract;
using OSIM.Services.Logic;

namespace OSIM.Services.DIModule
{
    public class OSIMModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IItemRepository>().To<ItemRepository>();
        }
    }
}
