using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    [Authorize]
    public partial class HomeController : Controller
    {
        [AllowAnonymous]
        public virtual ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, User")]
        public virtual ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public virtual ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}