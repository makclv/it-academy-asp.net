using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using ItAcademy.Demo.ClassWork.Client.Mvc.App_Start;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Binders;

namespace ItAcademy.Demo.ClassWork.Client.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());

            GlobalConfiguration.Configure(AutofacContainer.Register);

            Mapper.Initialize(cfg =>
            {
                AutoMapperConfig.Configure(cfg);
            });
        }
    }
}
