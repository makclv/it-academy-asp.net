using System;
using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.TryUpdateModel;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public partial class TryUpdateModelController : Controller
    {
        // GET: TryUpdateModel
        public virtual ActionResult IndexV1(PersonViewModel personViewModel, StudentViewModel studentViewModel)
        {
            return Json(new { personViewModel, studentViewModel }, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult IndexV2()
        {
            var personViewModel = new PersonViewModel
            {
                Age = Convert.ToInt32(Request.QueryString["Age"]),
                Name = Request.QueryString["Name"]
            };

            var studentViewModel = new StudentViewModel
            {
                DataFromDB = "IndexV2",
                University = Request.QueryString["University"],
                Name = Request.QueryString["Name"]
            };

            return Json(new { personViewModel, studentViewModel }, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult IndexV3()
        {
            var personViewModel = new PersonViewModel();
            var studentViewModel = new StudentViewModel
            {
                DataFromDB = "IndexV3"
            };

            TryUpdateModel(personViewModel);
            TryUpdateModel(studentViewModel);

            return Json(new { personViewModel, studentViewModel }, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult IndexInclude([Bind(Include = "University, Name")] StudentViewModel studentViewModel)
        {
            return Json(studentViewModel, JsonRequestBehavior.AllowGet);
        }

        public virtual ActionResult IndexExclude([Bind(Exclude = "University, Name")] StudentViewModel studentViewModel)
        {
            return Json(studentViewModel, JsonRequestBehavior.AllowGet);
        }
    }
}