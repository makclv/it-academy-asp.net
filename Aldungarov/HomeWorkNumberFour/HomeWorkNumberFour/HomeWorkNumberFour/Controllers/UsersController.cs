using HomeWorkNumberFour.BLL.Enum;
using HomeWorkNumberFour.Services.Interfaces;
using HomeWorkNumberFour.ViewModels;
using System.Web.Mvc;

namespace HomeWorkNumberFour.Controllers
{
    public class UsersController : Controller
    {
        private IUsersService _userService;

        public UsersController(IUsersService userEditService)
        {
            this._userService = userEditService;
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
            return View(_userService.GetUsersList());
        }

        #region Add User
        [HttpGet]
        public ActionResult UserCreate()
        {
            //var userViewModel = new UserViewModel
            //{
            //    FirstName = "Джерри",
            //    LastName = "Брукхаймер",
            //    Title = Title.Dr,
            //    Phone = "+375-11-111-11-11",
            //    Email = "Testing1@gmail.com",
            //    //Address = new Address() { CountryName = "USA", CityName = "Hasselhoff" },
            //    Comments = "Some comment 1."
            //};

            //_userService.AddUser(userViewModel);

            return View(_userService.GetUserById(0));
        }

        [HttpPost]
        public ActionResult UserCreate(UserViewModel userViewModel)
        {
            _userService.AddUser(userViewModel);

            return RedirectToAction("UserList");
        }
        #endregion

        #region Edit User
        [HttpGet]
        public ActionResult UserEdit(int id)
        {
            return View(_userService.GetUserById(id));
        }

        [HttpPost]
        public ActionResult UserEdit(UserViewModel userViewModel)
        {
            _userService.UpdateUser(userViewModel);

            return RedirectToAction("UserList");
        }
        #endregion

        #region Delete User
        [HttpGet]
        public ActionResult UserDelete(int id)
        {
            return View(_userService.GetUserById(id));
        }

        [HttpPost]
        public ActionResult UserDelete(UserViewModel userViewModel)
        {
            _userService.DeleteUser(userViewModel.Id);

            return RedirectToAction("UserList");
        }
        #endregion
    }
}