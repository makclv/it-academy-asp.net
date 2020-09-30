using Autofac;
using Autofac.Integration.Mvc;
using ClassLibrary1.Services;
using ClassLibrary1.Services.Interfaces;
using Data.Context;
using Data.Repositories;
using Data.UnitOfWork;
using Domain.Repository;
using Domain.UnitOfWork;
using FluentValidation;
using FluentValidation.Mvc;
using ItAcademy.HomeWorkNumFour.App_Start;
using ItAcademy.HomeWorkNumFour.Service.Interface;
using ItAcademy.HomeWorkNumFour.Validation;
using System.Linq;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<CoreDbContext>().As<ICoreDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<UserDomainService>().As<IUserDomainService>().InstancePerDependency();
            builder.RegisterType<CountryDomainService>().As<ICountryDomainService>().InstancePerDependency();
            builder.RegisterType<CityDomainService>().As<ICityDomainService>().InstancePerDependency();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerDependency();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().InstancePerDependency();
            builder.RegisterType<CityRepository>().As<ICityRepository>().InstancePerDependency();
            builder.RegisterType<UserPresentationService>().As<IUserPresentationService>().InstancePerDependency();

            builder.RegisterAssemblyTypes(typeof(BaseRepository<>).Assembly)
                .AsClosedTypesOf(typeof(IBaseRepository<>))
                .AsImplementedInterfaces()
                .InstancePerDependency();
            builder.RegisterFilterProvider();

            builder.RegisterAssemblyTypes(typeof(IBaseDomainService).Assembly)
               .Where(t => typeof(IBaseDomainService).IsAssignableFrom(t))
               .AsImplementedInterfaces()
               .InstancePerDependency();

            AssemblyScanner.FindValidatorsInAssemblyContaining<UserCreateValidation>()
                                  .ForEach(result =>
                                  {
                                      builder.RegisterType(result.ValidatorType)
                                      .Keyed<IValidator>(result.InterfaceType)
                                      .As<IValidator>();
                                  });

            AssemblyScanner.FindValidatorsInAssemblyContaining<UserEditeValidator>()
                                  .ForEach(result =>
                                  {
                                      builder.RegisterType(result.ValidatorType)
                                      .Keyed<IValidator>(result.InterfaceType)
                                      .As<IValidator>();
                                  });

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));

            FluentValidationModelValidatorProvider.Configure(config =>
            {
                config.ValidatorFactory = new AutofacValidatorFactory(container);
            });
        }
    }
}