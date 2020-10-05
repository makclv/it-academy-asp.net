using HW4.Client.Models.ViewModels;
using HW4.Client.PresentationServices.Interfaces;
using HW4.Client.Util;
using HW4.Domain.DomainServices.Interfaces;
using HW4.Domain.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace HW4.Client.PresentationServices
{
    public class UserPresentationService : IUserPresentationService
    {
        private readonly IUserDomainService userDomainService;
        private readonly ICountryDomainService countryDomainService;
        private readonly ICityDomainService cityDomainService;
        private readonly IMapper mapper;

        public UserPresentationService(IUserDomainService userDomainService, ICountryDomainService countryDomainService,
            ICityDomainService cityDomainService, IMapper mapper)
        {
            this.userDomainService = userDomainService;
            this.countryDomainService = countryDomainService;
            this.cityDomainService = cityDomainService;
            this.mapper = mapper;
        }

        public void AddUser(CreateUserViewModel user)
        {
            User newUser = mapper.CreateUserViewModelMapping(user);
            newUser.City = cityDomainService.GetCity(user.CityId);
            newUser.Country = countryDomainService.GetCountry(user.CountryId);
            userDomainService.AddUser(newUser);
        }

        public CreateUserViewModel CreateUserViewModel()
        {
            return new CreateUserViewModel
            {
                ListOfCities = new SelectList(cityDomainService.GetAllCities(), "Id", "Name"),
                ListOfCountries = new SelectList(countryDomainService.GetAllCountries(), "Id", "Name"),
            };
        }

        public CreateUserViewModel GetCreatedUserViewModel(CreateUserViewModel user)
        {
            user.ListOfCities = new SelectList(cityDomainService.GetAllCities(), "Id", "Name");
            user.ListOfCountries = new SelectList(countryDomainService.GetAllCountries(), "Id", "Name");
            return user;
        }

        public List<AllUsersViewModel> AllUsers()
        {
            List<User> allUsers = userDomainService.GetAllUsers();
            List<AllUsersViewModel> allUsersView = new List<AllUsersViewModel>();

            foreach (var x in allUsers)
            {
                allUsersView.Add(mapper.AllUsersViewModelMapping(x));
            }
            return allUsersView;
        }

        public EditUserViewModel GetEditUserViewModel(int id)
        {
            User user = userDomainService.GetUser(id);
            return GetEditUserViewModel(mapper.EditUserViewModelMapping(user));
        }

        public void EditUser(EditUserViewModel user)
        {
            User updateUser = userDomainService.GetUser(user.Id);
            updateUser = mapper.EditUserViewModelMappingToUser(user, updateUser);
            updateUser.City = cityDomainService.GetCity(user.CityId);
            updateUser.Country = countryDomainService.GetCountry(user.CountryId);
            userDomainService.EditUser();
        }

        public DeleteUserViewModel GetDeleteUserView(int id)
        {
            User user = userDomainService.GetUser(id);
            return mapper.DeleteUserViewModelMapping(user);
        }

        public void DeleteUser(int userId)
        {
            userDomainService.DeleteUser(userId);
        }

        public List<Country> AllCountries()
        {
            return countryDomainService.GetAllCountries();
        }

        public List<City> AllCities()
        {
            return cityDomainService.GetAllCities();
        }

        public EditUserViewModel GetEditUserViewModel(EditUserViewModel user)
        {
            user.ListOfCities = new SelectList(cityDomainService.GetAllCities(), "Id", "Name");
            user.ListOfCountries = new SelectList(countryDomainService.GetAllCountries(), "Id", "Name");
            return user;
        }
    }
}