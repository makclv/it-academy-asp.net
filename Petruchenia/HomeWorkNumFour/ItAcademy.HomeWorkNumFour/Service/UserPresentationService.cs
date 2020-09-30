using AutoMapper;
using ClassLibrary1.Services;
using ClassLibrary1.Services.Interfaces;
using Domain.Entites;
using Domain.UnitOfWork;
using ItAcademy.HomeWorkNumFour.Models.CRUD;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.Service.Interface
{
    public class UserPresentationService : IUserPresentationService
    {
        private readonly IUserDomainService userDomainService;
        private readonly ICountryDomainService countryDomainService;
        private readonly ICityDomainService cityDomainService;
        public UserPresentationService (IUserDomainService userDomainService,
            ICountryDomainService countryDomainService,
            ICityDomainService cityDomainService)
        {
            this.userDomainService = userDomainService;
            this.countryDomainService = countryDomainService;
            this.cityDomainService = cityDomainService;
        }
        public List<UserViewModel> GetUserByLastName(string name)
        {
            var users = userDomainService.GetUserByLastName(name);

            var usersViewModel = Mapper.Map<List<UserViewModel>>(users);

            return usersViewModel;
        }
        public CreateUser AddToView ()
        {
            CreateUser createUser = new CreateUser();
            createUser.CountriesDDL = countryDomainService.GetAllCountries();
            createUser.CitiesDDL = cityDomainService.GetAllCities();
            return createUser;
        }

        public void AddToDb(CreateUser createUser)
        {
            User user = Mapper.Map<CreateUser, User>(createUser);

            user.City = cityDomainService.GetCityById(createUser.CityId);
            user.Country = countryDomainService.GetCountryById(createUser.CountryId);

            userDomainService.Create(user);
        }

        public EditUser EditToView(int id)
        {
            EditUser editUser = Mapper.Map<User, EditUser>
                   (userDomainService.GetById(id));

            editUser.CountriesDDL = countryDomainService.GetAllCountries();
            editUser.CitiesDDL = cityDomainService.GetAllCities();
            return editUser;
        }

        public void EditToDb(EditUser editUser)
        {
            User user = Mapper.Map<EditUser, User>(editUser);

            user.City = cityDomainService.GetCityById(editUser.CityId);
            user.Country = countryDomainService.GetCountryById(editUser.CountryId);

            userDomainService.EditUser(user);
        }

        public List<UserViewModel> GetUsersViewList()
        {
            List<User> AllUsers = userDomainService.GetAll();
            List<UserViewModel> userViewModels = new List<UserViewModel>();
            foreach (var item in AllUsers)
            {
                userViewModels.Add(Mapper.Map<User, UserViewModel>(item));
            }
            return userViewModels;
        }

        public DeleteUser GetUserByIdToDelete(int id)
        {
            DeleteUser deleteUser = Mapper.Map<User, DeleteUser>
                (userDomainService.GetById(id));
            return deleteUser;
        }

        public void DeleteUserById(int id)
        {
            userDomainService.DeleteUser(id);
        }
    }
}