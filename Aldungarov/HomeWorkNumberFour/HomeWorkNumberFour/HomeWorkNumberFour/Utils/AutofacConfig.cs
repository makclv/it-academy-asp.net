using Autofac;
using Autofac.Integration.Mvc;
using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Interfaces.Services;
using HomeWorkNumberFour.BLL.Services;
using HomeWorkNumberFour.BLL.UnitOfWork;
using HomeWorkNumberFour.ClientLayer.Context;
using HomeWorkNumberFour.ClientLayer.Repository;
using HomeWorkNumberFour.ClientLayer.UnitOfWork;
using System.Web.Mvc;

namespace HomeWorkNumberFour.Utils
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<CitiesListService>().As<ICitiesListService>();
            builder.RegisterType<CountriesListService>().As<ICountriesListService>();
            builder.RegisterType<UserRepository>().As<IUserRepository>();
            builder.RegisterType<CitiesListRepository>().As<ICitiesListRepository>();
            builder.RegisterType<CountriesListRepository>().As<ICountriesListRepository>();

            builder.RegisterType<DBContext>().As<IDBContext>();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}