using Autofac;
using Autofac.Integration.Mvc;
using AutoMapper;
using Data.Repositories;
using DomainLogics.DomainServices;
using DomainLogics.DomainServices.Interface;
using DomainLogics.Models;
using DomainLogics.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();
                builder.RegisterControllers(typeof(MvcApplication).Assembly);
                builder.RegisterType<BookDomainService>().As<IBookDomainService>();
                builder.RegisterType<OrderDomainService>().As<IOrderDomainService>();
                builder.RegisterType<BookRepository>().As<IBookRepository>();
                builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}