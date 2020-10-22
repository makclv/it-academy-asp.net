using System;
using System.Web.Mvc;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public partial class RouteDemoController : Controller
    {
        // datetime/getcurrentdate?shiftDays=5&shiftYears=4
        // datetime/getcurrentdate/5_4
        public virtual ActionResult GetCurrentDate(int shiftDays, int shiftYears)
        {
            return Content(
                DateTime.Now
                    .AddDays(shiftDays)
                    .AddYears(shiftYears)
                    .ToString());
        }

        // datetime/getcurrentdatev2/5_4
        [Route("datetime/getcurrentdatev2/{shiftDays:range(1,5)}_{shiftYears}")]
        public virtual ActionResult GetCurrentDateV2(int shiftDays, int shiftYears)
        {
            return Content(
                DateTime.Now
                    .AddDays(shiftDays)
                    .AddYears(shiftYears)
                    .ToString());
        }
    }
}