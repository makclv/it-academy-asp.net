using Autofac;
using Autofac.Integration.Mvc;
using ClassLibrary1.Services;
using ClassLibrary1.Services.Interfaces;
using Data.Context;
using Data.Repositories;
using Data.UnitOfWork;
using Domain.Repository;
using Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerRequest();
            builder.RegisterType<CoreDbContext>().As<ICoreDbContext>().InstancePerRequest();

            builder.RegisterAssemblyTypes(typeof(BaseRepository<>).Assembly)
                .AsClosedTypesOf(typeof(IBaseRepository<>))
                .AsImplementedInterfaces()
                .InstancePerDependency();
            builder.RegisterFilterProvider();

            builder.RegisterAssemblyTypes(typeof(IBaseDomainService).Assembly)
               .Where(t => typeof(IBaseDomainService).IsAssignableFrom(t))
               .AsImplementedInterfaces()
               .InstancePerDependency();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}