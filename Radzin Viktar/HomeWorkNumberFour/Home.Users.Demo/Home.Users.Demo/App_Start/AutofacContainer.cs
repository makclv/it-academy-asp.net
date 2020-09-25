using Autofac;
using Autofac.Integration.Mvc;
using FluentValidation;
using FluentValidation.Mvc;
using Home.Users.Demo.Data.Context;
using Home.Users.Demo.Data.Repositories;
using Home.Users.Demo.Data.UnitOfWork;
using Home.Users.Demo.Domain.Repositories;
using Home.Users.Demo.Domain.Services;
using Home.Users.Demo.Domain.Services.Interfaces;
using Home.Users.Demo.Domain.UnitOfWork;
using Home.Users.Demo.Services;
using Home.Users.Demo.Services.Interfaces;
using Home.Users.Demo.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;

namespace Home.Users.Demo.App_Start
{
    public class AutofacContainer
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<UserDbContext>().As<IUserDbContext>().InstancePerLifetimeScope();
            builder.RegisterType<UserPresentationService>().As<IUserPresentationService>().InstancePerDependency();
            builder.RegisterType<UserPresentationService>().As<IUserPresentationService>().InstancePerDependency();
            builder.RegisterType<UserDomainService>().As<IUserDomainService>().InstancePerDependency();
            builder.RegisterType<UserRepository>().As<IUserRepository>().InstancePerDependency();
            builder.RegisterFilterProvider();


            AssemblyScanner.FindValidatorsInAssemblyContaining<UserValidator>()
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
            
        
