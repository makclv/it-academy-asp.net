﻿using System.Web.Mvc;
using ItAcademy.Demo.ClassWork.Client.Mvc.Models.EntityFramework;
using ItAcademy.Demo.ClassWork.Client.Mvc.Services.Interfaces;

namespace ItAcademy.Demo.ClassWork.Client.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserPresentationService userPresentationService;

        public UserController(IUserPresentationService userPresentationService)
        {
            this.userPresentationService = userPresentationService;
        }

        public ActionResult Index()
        {
            return View();
        }


        public JsonResult GetByNameWithRole(string name)
        {
            return Json(userPresentationService.GetByNameWithRole(name), JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View(new UserViewModel());
        }

        [HttpPost]
        public ActionResult Create(UserViewModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName))
            {
                ModelState.AddModelError("FirstName", "First Name is required.");
            }

            if (model.FirstName?.Length > 10)
            {
                ModelState.AddModelError("FirstName", "First Name can have a max of 10 characters.");
            }

            if (string.IsNullOrEmpty(model.LastName))
            {
                ModelState.AddModelError("LastName", "Last Name is required.");
            }

            if (model.FirstName?.Length > 15)
            {
                ModelState.AddModelError("FirstName", "Last Name can have a max of 15 characters.");
            }

            if (ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return View("CreateV2", model);
            }
        }

        [HttpGet]
        public ActionResult CreateV2()
        {
            return View("CreateV2Client", new UserViewModelV2());
        }

        [HttpPost]
        public ActionResult CreateV2(UserViewModelV2 model)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return View("CreateV2Client", model);
            }
        }

        public JsonResult NoWhiteSpacesValidate(string LastName)
        {
            if (LastName.Contains(" "))
            {
                return Json("Last Name must not contain spaces.", JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(true, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpGet]
        public ActionResult CreateV3()
        {
            return View("CreateV3", new UserViewModelV3());
        }

        [HttpPost]
        public ActionResult CreateV3(UserViewModelV3 model)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return View("CreateV3", model);
            }
        }

        [HttpGet]
        public ActionResult CreateAjax()
        {
            return View(new UserViewModelV2());
        }

        [HttpPost]
        public ActionResult CreateAjax(UserViewModelV2 model)
        {
            if (ModelState.IsValid)
            {
                return View("Index");
            }
            else
            {
                return PartialView("CreateAjaxPartial", model);
            }
        }
    }
}