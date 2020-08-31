using AutoMapper;
using HomeTask.MappingProfile;
using HomeTask.Models;
using HomeTask.Models.ViewModel;
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
        private readonly IUsersService usersService;
        public MappingProfiles mappingProfile = new MappingProfiles();
        public UserController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public ActionResult Create()
        {
            return View();
        }

        public ActionResult AddUser(User user)
        {
            usersService.AddUser(user);
            return RedirectToAction("Users");
        }

        public ActionResult Delete(int id)
        {
            usersService.DeleteUser(id);
            return RedirectToAction("Users");
        }

        public ActionResult EditUser(User user)
        {
            usersService.EditUser(user);
            return RedirectToAction("Users");
        }

        public ActionResult Edit(UserViewModel userView)
        {
             var user = mappingProfile._mapper.Map<UserViewModel, User>(userView); 
            return View(user);
        }

        public ActionResult Users()
        {
            var Users = usersService.GetAllUsers();
            var UsersView = mappingProfile._mapper.Map<IEnumerable<User>, List<UserViewModel>>(Users);
            return View(UsersView);
        }
    }
}