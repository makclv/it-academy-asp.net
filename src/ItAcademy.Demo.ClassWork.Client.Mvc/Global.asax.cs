﻿using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using FluentValidation.Mvc;
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
    }
}
