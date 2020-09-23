using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.PresentationServices.Interfaces;
using OrderTrackingSystem.Util.Mappers;
using OrderTrackingSystem.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderTrackingSystem.PresentationServices
{
    public class UsersPresentationServices : IUsersPresentationServices
    {
        public UsersPresentationServices(IUserDomainService domainService)
        {
            this.domainService = domainService;
        }

        IUserDomainService domainService;

        public List<GetUsersViewModel> GetUsers()
        {
            List<User> allUsers = domainService.GetUsers();
            List<GetUsersViewModel> allUsersVm = new List<GetUsersViewModel>();

            foreach (var user in allUsers)
            {
                allUsersVm.Add(UserMapper.UserToGetUserVm(user));
            }
            
            return allUsersVm;
        }


        public List<City> GetCitys()
        {
            return domainService.GetCitys();
        }

        public List<Country> GetCountrys()
        {
            return domainService.GetCountrys();
        }

        public void AddUser(CreateUsersViewModel userVm)
        {

            User user = UserMapper.CreateUsersVmToUser(userVm);
            user.City = domainService.GetCity(userVm.CityId);
            user.Country = domainService.GetCountry(userVm.CountryId);

            domainService.AddUser(user);
        }

        public bool VerificationUserId(Guid id)
        {
            return domainService.VerificationUserId(id);
        }

        public EditUsersViewModel GetEditUsersVm(Guid id)
        {
            User user = domainService.GetUser(id);
            return UserMapper.UserToEditUsersVm(user);
        }

        public void EditUser(EditUsersViewModel userVm)
        {
            User user = UserMapper.EditUsersVmToUser(userVm);
            user.City = domainService.GetCity(userVm.CityId);
            user.Country = domainService.GetCountry(userVm.CountryId);

            domainService.EditUser(user);
        }

        public DeleteUsersViewModel GetDeleteUsersVm(Guid id)
        {
            User user = domainService.GetUser(id);
            return UserMapper.UserToDeleteUsersVm(user);
        }

        public void DeleteUser(Guid userId)
        {
            domainService.DeleteUser(userId);
        }
    }
}