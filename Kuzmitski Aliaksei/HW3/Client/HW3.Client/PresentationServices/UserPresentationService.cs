using HW3.Client.Models;
using HW3.Client.PresentationServices.Interfaces;
using HW3.Client.Util;
using HW3.Domain.DomainServices.Interfaces;
using HW3.Domain.Models;
using System;
using System.Collections.Generic;

namespace HW3.Client.PresentationServices
{
    public class UserPresentationService : Mapper, IUserPresentationService
    {
        private readonly IUserDomainService domainService;

        public UserPresentationService(IUserDomainService domainService)
        {
            this.domainService = domainService;
        }

        public void AddUser(CreateUserViewModel user)
        {
            User newUser = CreateUserViewModelMapping(user);
            newUser.City = domainService.ReadCity(user.CityId);
            newUser.Country = domainService.ReadCountry(user.CountryId);
            domainService.CreateUser(newUser);
        }

        public List<AllUsersViewModel> AllUsers()
        {
            List<User> allUsers = domainService.AllUsers();
            List<AllUsersViewModel> allUsersView = new List<AllUsersViewModel>();

            foreach (var x in allUsers)
            {
                allUsersView.Add(AllUsersViewModelMapping(x));
            }
            return allUsersView;
        }

        public EditUserViewModel GetEditUserView(Guid id)
        {
            User user = domainService.ReadUser(id);
            return EditUserViewModelMapping(user);
        }

        public void EditUser(EditUserViewModel user)
        {
            User updateUser = EditUserViewModelMappingToUser(user);
            updateUser.City = domainService.ReadCity(user.CityId);
            updateUser.Country = domainService.ReadCountry(user.CountryId);
            domainService.UpdateUser(updateUser);
        }

        public DeleteUserViewModel GetDeleteUserView(Guid id)
        {
            User user = domainService.ReadUser(id);
            return DeleteUserViewModelMapping(user);
        }

        public void DeleteUser(Guid userId)
        {
            domainService.DeleteUser(userId);
        }

        public List<Country> AllCountries()
        {
            return domainService.AllCountries();
        }

        public List<City> AllCities()
        {
            return domainService.AllCities();
        }
    }
}