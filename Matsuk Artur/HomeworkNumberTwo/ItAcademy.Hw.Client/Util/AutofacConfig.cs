
using System.Web.Mvc;
using Autofac;
using Autofac.Integration.Mvc;
using ItAcademy.Hw.Data.Repositories;
using ItAcademy.Hw.Data.Repositories.Interfaces;
using ItAcademy.Hw.Domain.DomainServices;
using ItAcademy.Hw.Domain.DomainServices.Interfaces;

namespace ItAcademy.Hw.Client.Util
{
    public class AutofacConfig
    {
        public static void ConfigureContainer()
        {
            // получаем экземпляр контейнера
            var builder = new ContainerBuilder();

            // регистрируем контроллер в текущей сборке
            builder.RegisterControllers(typeof(MvcApplication).Assembly);

            // регистрируем споставление типов
            builder.RegisterType<BookDomainService>().As<IBookDomainService>();
            builder.RegisterType<BookRepository>().As<IBookRepository>();
            builder.RegisterType<OrderRepository>().As<IOrderRepository>();

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}