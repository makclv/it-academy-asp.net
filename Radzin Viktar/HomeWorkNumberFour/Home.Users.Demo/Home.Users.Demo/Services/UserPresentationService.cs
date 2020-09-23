using AutoMapper;
using Home.Users.Demo.Domain.Entities;
using Home.Users.Demo.Domain.Services.Interfaces;
using Home.Users.Demo.Models;
using Home.Users.Demo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static System.Net.Mime.MediaTypeNames;

namespace Home.Users.Demo.Services
{
    public class UserPresentationService : IUserPresentationService
    {
        private readonly IUserDomainService userDomainService;

        public UserPresentationService(IUserDomainService userDomainService)
        {
            this.userDomainService = userDomainService;
        }

        public void DeleteUser(int id)
        {
            userDomainService.DeleteUser(id);
        }

        public List<CityViewModel> GetCities()
        {
            var cities = userDomainService.GetCities();
            var cityViewModel = Mapper.Map<List<CityViewModel>>(cities);
            return cityViewModel;
        }

        public List<CountryViewModel> GetCountries()
        {
            var countries = userDomainService.GetCountries();
            var countryViewModel = Mapper.Map<List<CountryViewModel>>(countries);
            return countryViewModel;
        }

        public void InsertUser(UserViewModel user)
        {
            var insertUser = Mapper.Map<UserViewModel,User>(user);
            userDomainService.InsertUser(insertUser);
        }

        public bool IsUniqueFirstName(string firstname)
        {
            return userDomainService.IsUniqueFirstName(firstname);
        }

        public bool IsUniqueLastName(string lastname)
        {
            return userDomainService.IsUniqueLastName(lastname);
        }

        public bool IsUniqueMail(string mail)
        {
            return userDomainService.IsUniqueMail(mail);
        }

        public bool IsUniquePhone(string phone)
        {
            return userDomainService.IsUniquePhone(phone);
        }

        public List<UserViewModel> SelectAllUsers()
        {
            var users = userDomainService.SelectAllUsers();
            var userViewModel = Mapper.Map<List<UserViewModel>>(users);
            return userViewModel;
        }

        public UserViewModel SelectUserById(int id)
        {
            var user = userDomainService.SelectUserById(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);
            return userViewModel;
        }

        public UserViewModel SelectUserByIdWithCountryandCity(int id)
        {
            var user = userDomainService.SelectUserByIdWithCountryandCity(id);
            var userViewModel = Mapper.Map<User, UserViewModel>(user);
            return userViewModel;
        }

        public void UpdateUser(UserViewModel user)
        {
            var UserFromDataBase = userDomainService.SelectUserById(user.UserId);
            Mapper.Map(user, UserFromDataBase);
            userDomainService.UpdateUser(UserFromDataBase);
        }
    }
}