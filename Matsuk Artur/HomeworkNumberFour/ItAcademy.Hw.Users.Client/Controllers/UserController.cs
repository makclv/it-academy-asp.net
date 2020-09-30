using ItAcademy.Hw.Users.Client.Models;
using ItAcademy.Hw.Users.Client.PresentationServices.Interfaces;
using ItAcademy.Hw.Users.Client.Util.Mappers;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.Hw.Users.Client.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserDomainService userDomainService;
       private readonly IUserPresentationServices userPresentationServices;
        private readonly ICityDomainService cityDomainService;
        private readonly ICountryDomainService countryDomainService;
        public UserController(IUserDomainService userDomainService, IUserPresentationServices userPresentationServices, ICityDomainService cityDomainService, ICountryDomainService countryDomainService)
        {
            this.userDomainService = userDomainService;
            this.userPresentationServices = userPresentationServices;
            this.cityDomainService = cityDomainService;
            this.countryDomainService = countryDomainService;
        }
        public ActionResult Index()
        {
           
            var UserList = userDomainService.GetUsers();
            List<UserView> UserViewList = new List<UserView>();
            foreach (var a in UserList)
            {
                UserViewList.Add(Mapper.UserToUserView(a));
            }
            
            return View("View",UserViewList );
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            CreateUserView CreateUserView = new CreateUserView
            {
                SelectListCities = new SelectList(cityDomainService.GetCities(), "Id", "Name"),
                SelectListCountries = new SelectList(countryDomainService.GetCountries(), "Id", "Name")
            };
            CreateUserView = Mapper.UserViewToCreateUserView(Mapper.UserToUserView(userDomainService.FindUser(id)),CreateUserView);
            return View("Edit",CreateUserView);
            
        }

        [HttpPost]
        public ActionResult Edit(CreateUserView CreateUserView)
        {

            if (ModelState.IsValid)
            {

                userPresentationServices.ChangeUser(CreateUserView);
                return RedirectToAction("Index");
            }

            return View("Edit", CreateUserView);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            userDomainService.DeleteUser(id);

            return Redirect("/User/Index"); 
            
        }

        [HttpGet]
        public ActionResult Add()
        {
            
            return View("Edit", userPresentationServices.CreateEmptyUser());
        }

        [HttpPost]
        public ActionResult Add(CreateUserView CreateUserView)
        {
            if (ModelState.IsValid)
            {
                userPresentationServices.AddUser(CreateUserView);
                return RedirectToAction("Index");
            }
            return View("Edit", userPresentationServices.CreateEmptyUser());

        }
        [HttpGet]
        public JsonResult GetCitiesByCountry(int id)
        {
            return Json(cityDomainService.GetCitiesByCountry(id), JsonRequestBehavior.AllowGet);
        }
    }
}