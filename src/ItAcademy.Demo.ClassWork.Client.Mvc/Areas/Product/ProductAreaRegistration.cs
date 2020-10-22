using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Areas.Product
{
    public class ProductAreaRegistration : AreaRegistration
    {
        public override string AreaName => "Product";

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "Product_default",
                "Product/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional });
        }
    }
}