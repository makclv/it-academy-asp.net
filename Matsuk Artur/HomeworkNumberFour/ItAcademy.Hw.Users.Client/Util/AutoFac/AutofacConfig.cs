using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using ItAcademy.Hw.Users.Data.Repositories;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.DomainServices;
using ItAcademy.Hw.Users.Domain.Repositories;
using ItAcademy.Hw.Users.Client.PresentationServices;
using ItAcademy.Hw.Users.Client.PresentationServices.Interfaces;
using ItAcademy.Hw.Users.Domain.UnitOfWork;
using ItAcademy.Hw.Users.Data.UnitOfWork;
using ItAcademy.Hw.Users.Data.Context;

namespace ItAcademy.Hw.Users.Client.Util.AutoFac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
           
            var builder = new ContainerBuilder();

           
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            
            builder.RegisterType<UserDomainService>().As<IUserDomainService>();
            builder.RegisterType<CountryDomainService>().As<ICountryDomainService>();
            builder.RegisterType<CityDomainService>().As<ICityDomainService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CityRepository>().As<ICityRepository>();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>();
            builder.RegisterType<UserPresentationServices>().As<IUserPresentationServices>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            builder.RegisterType<MyDbContext>().As<IMyDbContext>();
            


            var container = builder.Build();

            
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}