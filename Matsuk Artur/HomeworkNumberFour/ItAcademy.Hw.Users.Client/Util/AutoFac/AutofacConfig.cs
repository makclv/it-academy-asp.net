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
using FluentValidation;
using ItAcademy.Hw.Users.Client.Validators;
using FluentValidation.Mvc;
using ItAcademy.Hw.Users.Client.App_Start.Core;

namespace ItAcademy.Hw.Users.Client.Util.AutoFac
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
           
            var builder = new ContainerBuilder();

           
            builder.RegisterControllers(typeof(MvcApplication).Assembly);


            builder.RegisterType<UserDomainService>().As<IUserDomainService>().InstancePerDependency();
            builder.RegisterType<CountryDomainService>().As<ICountryDomainService>().InstancePerDependency();
            builder.RegisterType<CityDomainService>().As<ICityDomainService>().InstancePerDependency();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerDependency();
            builder.RegisterType<CityRepository>().As<ICityRepository>().InstancePerDependency();
            builder.RegisterType<CountryRepository>().As<ICountryRepository>().InstancePerDependency();
            builder.RegisterType<UserPresentationServices>().As<IUserPresentationServices>().InstancePerDependency();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<MyDbContext>().As<IMyDbContext>().InstancePerLifetimeScope();

            AssemblyScanner.FindValidatorsInAssemblyContaining<UserValidator>()
                                   .ForEach(result =>
                                   {
                                       builder.RegisterType(result.ValidatorType)
                                       .Keyed<IValidator>(result.InterfaceType)
                                       .As<IValidator>();
                                   });

            AssemblyScanner.FindValidatorsInAssemblyContaining<CreateUserValidator>()
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