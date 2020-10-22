using System.Web.Http;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(ItAcademy.Demo.ClassWork.Client.Console.Startup))]

namespace ItAcademy.Demo.ClassWork.Client.Console
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            //app.Use<LoggerMiddleware>();

            //app.Run(ctx =>
            //{
            //    return ctx.Response.WriteAsync("Hello World");
            //});

            var configuration = new HttpConfiguration();
            configuration.Routes.MapHttpRoute(
                "DefaultApi",
                "api/{controller}/{id}",
                new { controller = "People", id = RouteParameter.Optional });

            app.UseWebApi(configuration);
        }
    }
}
