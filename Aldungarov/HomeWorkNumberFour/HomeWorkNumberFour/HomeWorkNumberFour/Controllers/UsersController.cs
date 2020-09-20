using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Interfaces.Services;
using HomeWorkNumberFour.Utils;
using HomeWorkNumberFour.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HomeWorkNumberFour.Controllers
{
    public class UsersController : Controller
    {
        private IUserService _userService;
        
        private ICitiesListService _cityListService;

        private ICountriesListService _countriesListService;

        public UsersController(IUserService userService, ICitiesListService cityListService, ICountriesListService countriesListService)
        {
            this._userService = userService;
            this._cityListService = cityListService;
            this._countriesListService = countriesListService;
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

            foreach (var user in _userService.GetUsers())
            {
                usersViewModelList.Add(Mapping.ToUserViewModel(user));
            }

            return View(usersViewModelList);
        }

        #region Add User
        [HttpGet]
        public ActionResult UserCreate()
        {
            UserViewModel newUserViewModel = new UserViewModel();
            
            newUserViewModel.CitiesList = _cityListService.CityList();
            
            newUserViewModel.CountriesList = _countriesListService.CountriesList();

            return View(newUserViewModel);
        }

        [HttpPost]
        public ActionResult UserCreate(UserViewModel userViewModel)
        {
            _userService.AddUser(Mapping.ToUserModel(userViewModel));

            return RedirectToAction("UserList");
        }
        #endregion

        #region Edit User
        [HttpGet]
        public ActionResult UserEdit(int id)
        {
            var existUserViewModel = Mapping.ToUserViewModel(_userService.GetUserById(id));
            
            existUserViewModel.CitiesList = _cityListService.CityList();
            
            existUserViewModel.CountriesList = _countriesListService.CountriesList();
            
            return View(existUserViewModel);
        }

        [HttpPost]
        public ActionResult UserEdit(UserViewModel userViewModel)
        {
            _userService.UpdateUser(Mapping.ToUserModel(userViewModel));

            return RedirectToAction("UserList");
        }
        #endregion

        #region Delete User
        [HttpGet]
        public ActionResult UserDelete(int id)
        {
            return View(Mapping.ToUserViewModel(_userService.GetUserById(id)));
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