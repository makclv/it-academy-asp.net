using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using ThirdHomeWork.BLL.Interfaces.Repository;
using ThirdHomeWork.BLL.Interfaces.Services;
using ThirdHomeWork.BLL.Repository;
using ThirdHomeWork.BLL.Services;

namespace ThirdHomeWork.Utils
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            builder.RegisterType<UserService>().As<IUserService>();
            builder.RegisterType<FakeRepository>().As<IFakeRepository>();

            var container = builder.Build();

            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}