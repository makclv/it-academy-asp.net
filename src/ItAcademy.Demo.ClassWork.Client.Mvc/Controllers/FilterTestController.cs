using System;
using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Infrastructure.Filters;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.ActionFilterTest;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public partial class FilterTestController : Controller
    {
        [CustomResultFilter]
        public virtual ActionResult Index()
        {
            return View(new Sum { Value = 3 });
        }

        [CustomActionFilter]
        public virtual ActionResult Sum(int a, int b)
        {
            return Json(new Sum { Value = a + b });
        }

        public virtual ActionResult TestException()
        {
            throw new ApplicationException("IT Academy");
        }

        [OutputCache(Duration = 600)]
        public virtual ActionResult GetCurrentTime()
        {
            return Content(DateTime.Now.ToString());
        }

        public virtual ActionResult GetCurrentTimeNoCache()
        {
            return Content(DateTime.Now.ToString());
        }
    }
}