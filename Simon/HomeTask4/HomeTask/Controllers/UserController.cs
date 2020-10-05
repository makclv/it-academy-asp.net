using AutoMapper;
using HomeTask.MappingProfile;
using HomeTask.Models;
using HomeTask.Models.ViewModel;
using HomeTask.Services;
using HomeTask.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HomeTask.Controllers
{
    public class UserController : Controller
    {
        private readonly ICountryService countryService;
        private readonly IUsersService usersService;
        private readonly ICityService cityService;
        public MappingProfiles mappingProfile = new MappingProfiles();
        public UserController(IUsersService usersService, ICountryService countryService, ICityService cityService)
        {
            this.cityService = cityService;
            this.countryService = countryService;
            this.usersService = usersService;
        }

        public ActionResult Create(CreateViewModel user)
        {
            var country = countryService.GetAllCountry();
            var city = cityService.GetAllCity();
            user.Countrys = country;
            user.Citys = city;
            return View(user);
        }

        public ActionResult AddUser(CreateViewModel user)
        {
            if (!ModelState.IsValid)
            {
                var country = countryService.GetAllCountry();
                var city = cityService.GetAllCity();
                user.Countrys = country;
                user.Citys = city;
                return View("Create", user);
            }
            var res = mappingProfile._mapper.Map<CreateViewModel, User>(user);
            usersService.AddUser(res);
            return RedirectToAction("Users");
        }

        public ActionResult Delete(int id)
        {
            usersService.DeleteUser(id);
            return RedirectToAction("Users");
        }

        public ActionResult EditUser(EditViewModel user)
        {
             if (!ModelState.IsValid)
                {
                var country = countryService.GetAllCountry();
                var city = cityService.GetAllCity();
                user.Countrys = country;
                user.Citys = city;
                return View("Edit",user);
             }
            var res = mappingProfile._mapper.Map<EditViewModel, User>(user);
            usersService.EditUser(res);
            return RedirectToAction("Users");
        }

        public ActionResult Edit(EditViewModel editView)
        {
            var country = countryService.GetAllCountry();
            var city = cityService.GetAllCity();
            editView.Citys = city;
            editView.Countrys = country;
            return View(editView);
        }

        public ActionResult Users()
        {
            var Users = usersService.GetAllUsers();
            var UsersView = mappingProfile._mapper.Map<IEnumerable<User>, List<UserViewModel>>(Users);
            var countries = countryService.GetAllCountry();
            var citys = cityService.GetAllCity();
            UsersViewModel result = new UsersViewModel()
            {
                Cities = citys,
                Countries = countries,
                UserViewModels = UsersView
            };
            return View(result);
        }
    }
}