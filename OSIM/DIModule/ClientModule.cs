using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ninject.Modules;
using OSIM.Services.Contract;
using OSIM.Services.Logic;

namespace OSIM.Client.DIModule
{
    public class ClientModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IItemService>().To<ItemService>();
        }
    }
}