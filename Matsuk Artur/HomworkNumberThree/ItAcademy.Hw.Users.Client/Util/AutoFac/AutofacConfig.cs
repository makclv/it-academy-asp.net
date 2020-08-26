using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using ItAcademy.Hw.Users.Data.Repositories;
using ItAcademy.Hw.Users.Data.Repositories.Interfaces;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.DomainServices;

namespace ItAcademy.Hw.Users.Client.Util.AutoFac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
           
            var builder = new ContainerBuilder();

           
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            
            builder.RegisterType<UserDomainService>().As<IUserDomainService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
           

           
            var container = builder.Build();

            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}