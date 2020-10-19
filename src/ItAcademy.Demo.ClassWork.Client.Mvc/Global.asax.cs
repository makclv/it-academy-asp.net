using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using FluentValidation.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.App_Start;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Binders;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.Security;

namespace ItAcademy.Demo.ClassWork.Client.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //AuthenticateRequest += Application_AuthenticateRequest;

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());

            AutofacContainer.Register();

            Mapper.Initialize(cfg =>
            {
                AutoMapperConfig.Configure(cfg);
            });

            //FluentValidationModelValidatorProvider.Configure();
        }

        //private void Application_AuthenticateRequest(object sender, EventArgs e)
        //{
        //    if (Context.Request.IsAuthenticated)
        //    {
        //        Context.User = new ApplicationUser(Context.User.Identity.Name);
        //    }
        //}
    }
}
