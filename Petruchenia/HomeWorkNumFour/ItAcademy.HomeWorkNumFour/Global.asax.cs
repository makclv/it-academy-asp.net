using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using ItAcademy.HomeWorkNumFour.App_Start;
using ItAcademy.HomeWorkNumFour.Util;
using FluentValidation.Mvc;

namespace ItAcademy.HomeWorkNumFour
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutofacConfig.ConfigureContainer();

            Mapper.Initialize(cfg =>
            {
                AutoMapperConfig.Configure(cfg);
            });

            //FluentValidationModelValidatorProvider.Configure();
        }
    }
}
