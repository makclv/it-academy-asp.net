using Autofac;
using Autofac.Integration.Mvc;
using FluentValidation;
using FluentValidation.Mvc;
using HomeTask.Date;
using HomeTask.Repository;
using HomeTask.Services;
using HomeTask.Services.interfaces;
using HomeTask.Validation;
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
            builder.RegisterType<DbContextUserRepository>().As<IUserRepository>();
            builder.RegisterType<CountryService>().As<ICountryService>();
            builder.RegisterType<DbContextUserRepository>().As<ICountryRepository>();
            builder.RegisterType<CityService>().As<ICityService>();
            builder.RegisterType<DbContextUserRepository>().As<ICityRepository>();

            AssemblyScanner.FindValidatorsInAssemblyContaining<CreateValidation>()
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

