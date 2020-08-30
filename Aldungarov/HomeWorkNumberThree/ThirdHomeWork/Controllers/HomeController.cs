using System.Collections.Generic;
using System.Web.Mvc;
using ThirdHomeWork.BLL.Interfaces.Services;
using ThirdHomeWork.Utils.Mapping;
using ThirdHomeWork.ViewModels;

namespace ThirdHomeWork.Controllers
{
    public class HomeController : Controller
    {
        private IUserService userService;

        public HomeController(IUserService userService)
        {
            this.userService = userService;
        }

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult UserList()
        {
            var usersViewModelList = new List<UserViewModel>();
            
            foreach (var user in userService.GetUsers()) 
            {
                usersViewModelList.Add(Mapping.ToUserViewModel(user));
            }
            
            return View(usersViewModelList);
        }

        #region Add User
        [HttpGet]
        public ActionResult UserCreate()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserCreate(UserViewModel userViewModel)
        {
            userService.AddUser(Mapping.ToUserModel(userViewModel));

            return View();
        }
        #endregion

        #region Edit User
        [HttpGet]
        public ActionResult UserEdit(int id)
        {
            return View(Mapping.ToUserViewModel(userService.GetUserById(id)));
        }

        [HttpPost]
        public ActionResult UserEdit(UserViewModel userViewModel)
        {
            userService.UpdateUser(Mapping.ToUserModel(userViewModel));
            
            return RedirectToAction("UserList");
        }
        #endregion

        #region Delete User
        [HttpGet]
        public ActionResult UserDelete(int id)
        {
            return View(Mapping.ToUserViewModel(userService.GetUserById(id)));
        }

        [HttpPost]
        public ActionResult UserDelete(UserViewModel userViewModel)
        {
            userService.DeleteUser(userViewModel.Id);

            return RedirectToAction("UserList");
        }
        #endregion
    }
}