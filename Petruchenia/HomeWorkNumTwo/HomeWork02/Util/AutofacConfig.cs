using Autofac;
using Autofac.Integration.Mvc;
using System.Web.Mvc;
using ClassLibrary2.Repositories;
using ClassLibrary2.Models;

namespace HomeWork02.Util
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
            builder.RegisterType<BookRepository>().As<IBookRepository>()
                .WithParameter("context", new BookContext());
            
            builder.RegisterType<BookRepository>()
                .As<IBookRepository>().WithProperty("Context", new BookContext());

            // создаем новый контейнер с теми зависимостями, которые определены выше
            var container = builder.Build();

            // установка сопоставителя зависимостей
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}