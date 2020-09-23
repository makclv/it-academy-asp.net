using Autofac;
using Autofac.Integration.Mvc;
using FluentValidation;
using FluentValidation.Mvc;
using OrderTrackingSystem.App_Start.Core;
using OrderTrackingSystem.Data.Context;
using OrderTrackingSystem.Data.Repositories;
using OrderTrackingSystem.Data.UnitOfWork;
using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.UnitOfWork;
using OrderTrackingSystem.PresentationServices;
using OrderTrackingSystem.PresentationServices.Interfaces;
using OrderTrackingSystem.Validators;
using System.Reflection;
using System.Web.Mvc;

namespace OrderTrackingSystem.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterType<UsersPresentationServices>().As<IUsersPresentationServices>().InstancePerDependency();

            builder.RegisterAssemblyTypes(typeof(IBaseDomainService).Assembly)
               .Where(t => typeof(IBaseDomainService).IsAssignableFrom(t))
               .AsImplementedInterfaces()
               .InstancePerDependency();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();
            builder.RegisterType<TrackingSystemDbContext>().As<ITrackingSystemDbContext>().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(BaseRepository<>).Assembly)
                .AsClosedTypesOf(typeof(IBaseRepository<>))
                .AsImplementedInterfaces()
                .InstancePerDependency();



            //Register the API Validators(the custome validators used for FluentValidation)
            AssemblyScanner.FindValidatorsInAssemblyContaining<CreateUsersVmValidator>()
                                    .ForEach(result =>
                                    {
                                        builder.RegisterType(result.ValidatorType)
                                        .Keyed<IValidator>(result.InterfaceType)
                                        .As<IValidator>();
                                    });

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
            // FluentValidationModelValidatorProvider.Configure();


            FluentValidationModelValidatorProvider.Configure(config =>
            {
                config.ValidatorFactory = new AutofacValidatorFactory(container);
            });
        }
    }
}