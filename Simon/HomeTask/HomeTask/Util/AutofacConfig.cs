using Autofac;
using Autofac.Integration.Mvc;
using HomeTask.Date;
using HomeTask.Repository;
using HomeTask.Services;
using HomeTask.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeTask.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(typeof(MvcApplication).Assembly);
            builder.RegisterType<UserService>().As<IUsersService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}

