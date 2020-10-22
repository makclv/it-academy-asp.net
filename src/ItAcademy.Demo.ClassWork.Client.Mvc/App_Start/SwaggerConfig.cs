using System;
using System.IO;
using System.Web.Http;
using ItAcademy.Demo.ClassWork.Client.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.App_Start;
using Swashbuckle.Application;
using WebActivatorEx;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ItAcademy.Demo.ClassWork.Client.Mvc
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "IT Academy Swagger");
                        c.IncludeXmlComments(GetXmlCommentsPath());
                    })
                .EnableSwaggerUi(c =>
                    {
                        c.DocumentTitle("IT Academy Swagger UI");
                    });
        }

        private static string GetXmlCommentsPath()
        {
            return Path.Combine(
                AppDomain.CurrentDomain.RelativeSearchPath,
                $"{typeof(WebApiConfig).Assembly.GetName().Name}.xml");
        }
    }
}
