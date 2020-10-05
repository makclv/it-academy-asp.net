using Autofac;
using Autofac.Integration.Mvc;
using FluentValidation;
using FluentValidation.Mvc;
using HW4.Client.App_Start.FluentApi;
using HW4.Client.PresentationServices.Interfaces;
using HW4.Client.Util;
using HW4.Client.Util.Mapper;
using HW4.Client.Validators;
using HW4.Data.Context;
using HW4.Data.Context.Interfaces;
using HW4.Data.Repositories;
using HW4.Data.UnitOfWork;
using HW4.Domain.DomainServices.Interfaces;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Reflection;
using System.Web.Mvc;

namespace HW4.Client.App_Start
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(Assembly.GetExecutingAssembly());

            builder.RegisterAssemblyTypes(typeof(IUserPresentationService).Assembly)
                .Where(t => typeof(IUserPresentationService).IsAssignableFrom(t))
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

            builder.RegisterType<Mapper>().As<IMapper>().SingleInstance();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            builder.RegisterType<DatabaseContext>().As<IDatabaseContext>().InstancePerLifetimeScope();

            AssemblyScanner.FindValidatorsInAssemblyContaining<CreateUserViewModelValidator>()
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