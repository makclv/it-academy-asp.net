using ItAcademy.Hw.Users.Client.Models;
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
        // GET: User
        public UserController(IUserDomainService userDomainService)
        {
            this.userDomainService = userDomainService;
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

        public ViewResult Edit(int id)
        {
            UserView UserView = Mapper.UserToUserView(userDomainService.FindUser(id));
            return View("Edit",UserView);
        }

        [HttpPost]
        public ActionResult Edit(UserView UserView)
        {


            userDomainService.ChangeUser(Mapper.UserViewToUser(UserView));

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
             userDomainService.DeleteUser(id);

            return Redirect("/User/Index"); 
            
        }

        public ActionResult Add()
        {
            UserView UserView = new UserView();
            return View("Edit", UserView);
        }

        [HttpPost]
        public ActionResult Add(UserView UserView)
        {
            userDomainService.AddUser(Mapper.UserViewToUser(UserView));
            return RedirectToAction("Index");
        }
    }
}