using Autofac;
using Autofac.Integration.Mvc;
using Bookshop.Data.Context;
using Bookshop.Data.Repositories;
using Bookshop.Domain.DomainServices.OrderDomainService;
using Bookshop.Domain.DomainServices.OrderDomainService.OrderInterfaces;
using Bookshop.Domain.DomainServices.ProductDomainService;
using Bookshop.Domain.DomainServices.ProductDomainService.ProductInterfaces;
using Bookshop.Domain.Repositories;
using System.Reflection;
using System.Web.Mvc;

namespace Bookshop.Client.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<BooksDomainService>().As<IBooksDomainService>();
            builder.RegisterType<OrdersDomainService>().As<IOrdersDomainService>();

            builder.RegisterType<ProductRepository>().As<IProductRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();
            builder.RegisterType<VirtualDb>().As<IVirtualDb>().SingleInstance();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}