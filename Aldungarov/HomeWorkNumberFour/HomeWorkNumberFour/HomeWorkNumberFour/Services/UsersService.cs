using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Interfaces.Services;
using HomeWorkNumberFour.Services.Interfaces;
using HomeWorkNumberFour.Utils;
using HomeWorkNumberFour.ViewModels;
using System.Collections.Generic;

namespace HomeWorkNumberFour.Services
{//UserAppService
    public class UsersService : IUsersService
    {
        private IUserService _userService;

        private ICitiesListService _cityListService;

        private ICountriesListService _countriesListService;

        public UsersService(IUserService userService,
                               ICitiesListService cityListService,
                               ICountriesListService countriesListService)
        {
            this._userService = userService;

            this._cityListService = cityListService;

            this._countriesListService = countriesListService;
        }

        public List<UserViewModel> GetUsersList()
        {
            var usersViewModelList = new List<UserViewModel>();

            foreach (var user in _userService.GetUsers())
            {
                usersViewModelList.Add(Mapping.ToUserViewModel(user));
            }

            return usersViewModelList;
        }

        public UserViewModel GetUserById(int id)
        {
            var userViewModel = new UserViewModel();

            if (id == 0)
            {
                //UserViewModel newUserViewModel = new UserViewModel();

                userViewModel.CitiesList = _cityListService.CityList();

                userViewModel.CountriesList = _countriesListService.CountriesList();

                //return newUserViewModel;
            }
            else
            {
                //var existUserViewModel = Mapping.ToUserViewModel(_userService.GetUserById(id));
                userViewModel = Mapping.ToUserViewModel(_userService.GetUserById(id));

                userViewModel.CitiesList = _cityListService.CityList();

                userViewModel.CountriesList = _countriesListService.CountriesList();

                //return existUserViewModel;
            }
            
            return userViewModel;
        }

        public void AddUser(UserViewModel userViewModel)
        {
            _userService.AddUser(Mapping.ToUserModel(userViewModel));
        }

        public void UpdateUser(UserViewModel userViewModel)
        {
            _userService.UpdateUser(Mapping.ToUserModel(userViewModel));
        }

        public void DeleteUser(int id)
        {
            _userService.DeleteUser(id);
        }
    }
}