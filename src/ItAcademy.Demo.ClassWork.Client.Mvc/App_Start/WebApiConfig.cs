using System.Web.Http;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // GlobalConfiguration.Configuration.Formatters.Clear();
            // GlobalConfiguration.Configuration.Formatters.Add(new JsonMediaTypeFormatter());

            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional });
        }
    }
}