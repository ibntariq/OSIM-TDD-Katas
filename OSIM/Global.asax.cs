using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using Ninject.Web.Common;
using OSIM.Client.DIModule;
using OSIM.Services.DIModule;

namespace OSIM.Client
{
    public class MvcApplication : NinjectHttpApplication
    {
        protected override void OnApplicationStarted()
        {
            base.OnApplicationStarted();

            //WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "id", "username", true);
            AreaRegistration.RegisterAllAreas();
        }

        protected override IKernel CreateKernel()
        {
            var kernel = new StandardKernel(new ClientModule(), new OSIMModule());
            RegisterServices(kernel);

            return kernel;
        }

        private void RegisterServices(IKernel kernel)
        {
            kernel.Load(Assembly.GetExecutingAssembly());
        }
    }
}
