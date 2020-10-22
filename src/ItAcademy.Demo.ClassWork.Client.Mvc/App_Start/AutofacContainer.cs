using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using FluentValidation;
using FluentValidation.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.App_Start.Core;
using ItAcademy.Demo.ClassWork.Client.Mvc.Services.Interfaces;
using ItAcademy.Demo.ClassWork.Client.Mvc.Validators;
using ItAcademy.Demo.ClassWork.Domain.Repositories;
using ItAcademy.Demo.ClassWork.Domain.Services.Interfaces;
using ItAcademy.Demo.ClassWork.Domain.UnitOfWork;
using ItAcademy.Demo.ClassWork.Infrastructure.Data.Context;
using ItAcademy.Demo.ClassWork.Infrastructure.Data.Repositories;
using ItAcademy.Demo.ClassWork.Infrastructure.Data.UnitOfWork;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.App_Start
{
    public static class AutofacContainer
    {
        public static void Register()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<CoreDbContext>().As<ICoreDbContext>().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(IBasePresentationService).Assembly)
               .Where(t => typeof(IBasePresentationService).IsAssignableFrom(t))
               .AsImplementedInterfaces()
               .InstancePerDependency();

            builder.RegisterAssemblyTypes(typeof(IBaseDomainService).Assembly)
               .Where(t => typeof(IBaseDomainService).IsAssignableFrom(t))
               .AsImplementedInterfaces()
               .InstancePerDependency();

            builder.RegisterAssemblyTypes(typeof(BaseRepository<>).Assembly)
                .AsClosedTypesOf(typeof(IBaseRepository<>))
                .AsImplementedInterfaces()
                .InstancePerDependency();
            builder.RegisterFilterProvider();

            //// Register the API Validators(the custome validators used for FluentValidation)
            AssemblyScanner.FindValidatorsInAssemblyContaining<UserValidator>()
                                    .ForEach(result =>
                                    {
                                        builder.RegisterType(result.ValidatorType)
                                        .AsImplementedInterfaces()
                                        .InstancePerLifetimeScope();
                                    });

            var container = builder.Build();

            var dependencyResolver = new AutofacDependencyResolver(container);
            DependencyResolver.SetResolver(dependencyResolver);
            //// FluentValidationModelValidatorProvider.Configure();
            FluentValidationModelValidatorProvider.Configure(config =>
            {
                config.ValidatorFactory = new AutofacValidatorFactory(dependencyResolver);
            });
        }
    }
}
