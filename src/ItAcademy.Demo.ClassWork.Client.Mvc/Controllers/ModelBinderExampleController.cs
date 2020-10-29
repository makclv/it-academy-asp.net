using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public partial class ModelBinderExampleController : Controller
    {
        // val -> 123.4
        // val -> 123,4
        // val -> 123dot4
        public virtual ActionResult Index(decimal val)
        {
            return Json(val, JsonRequestBehavior.AllowGet);
        }
    }
}