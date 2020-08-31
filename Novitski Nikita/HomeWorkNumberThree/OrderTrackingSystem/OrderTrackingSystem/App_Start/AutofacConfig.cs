using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using System.Reflection;
using OrderTrackingSystem.Data.Repositories;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.DomainServices;
using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.PresentationServices.Interfaces;
using OrderTrackingSystem.PresentationServices;

namespace OrderTrackingSystem.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UserRepository>().As<IUserRepository>().SingleInstance(); 
            builder.RegisterType<UserDomainService>().As<IUserDomainService>().SingleInstance(); 
            builder.RegisterType<UsersPresentationServices>().As<IUsersPresentationServices>().SingleInstance();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}