using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace ItAcademy.Demo.ClassWork.Client.Mvc
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.MapMvcAttributeRoutes();

            routes.MapRoute(
                name: "RouteDemo1",
                url: "datetime/getcurrentdate/{shiftDays}_{shiftYears}",
                defaults: new
                {
                    controller = "RouteDemo", action = "GetCurrentDate",
                    shiftDays = UrlParameter.Optional,
                    shiftYears = UrlParameter.Optional
                },
                constraints: new
                {
                    shiftDays = new CompoundRouteConstraint(
                        new List<IRouteConstraint>
                        {
                            new RangeRouteConstraint(1, 15),
                            new IntRouteConstraint()
                        }),
                    shiftYears = new RangeRouteConstraint(1, 15)
                });

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional },
                namespaces: new[] { "ItAcademy.Demo.ClassWork.Client.Mvc.Controllers" });
        }
    }
}
