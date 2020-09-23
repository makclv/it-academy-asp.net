using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.PresentationServices.Interfaces;
using OrderTrackingSystem.Util.Mappers;
using OrderTrackingSystem.ViewModels.Users;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Linq;


namespace OrderTrackingSystem.PresentationServices
{
    public class UsersPresentationServices : IUsersPresentationServices
    {
        public UsersPresentationServices(IUserDomainService userDomainService , ICountryDomainService countryDomainService,ICityDomainService cityDomainService)
        {
            this.userDomainService = userDomainService;
            this.countryDomainService = countryDomainService;
            this.cityDomainService = cityDomainService;
        }

        private readonly IUserDomainService userDomainService;
        private readonly ICountryDomainService countryDomainService;
        private readonly ICityDomainService cityDomainService;


        public List<GetUsersViewModel> GetUsers()
        {
            List<User> allUsers = userDomainService.GetUsersWithAllAttachments();
            List<GetUsersViewModel> allUsersVm = new List<GetUsersViewModel>();

            allUsers.ForEach(user => allUsersVm.Add(UserMapper.UserToGetUserVm(user)));

            return allUsersVm;
        }


        public List<City> GetCitys()
        {
            return cityDomainService.GetCitys();
        }

        public List<Country> GetCountrys()
        {
            return countryDomainService.GetCountrys();

        }

        public void AddUser(CreateUsersViewModel userVm)
        {
            User user = UserMapper.CreateUsersVmToUser(userVm);
            user.City = cityDomainService.GetCity(userVm.CityId);
            user.Country = countryDomainService.GetCountry(userVm.CountryId);

            userDomainService.AddUser(user);

        }

        public EditUsersViewModel GetEditUsersVm(int id)
        {
            User user = userDomainService.GetUserWithAllAttachments(id);
            return GetEditUsersVm(UserMapper.UserToEditUsersVm(user));

        }

        public void EditUser(EditUsersViewModel userVm)
        {
            User user = userDomainService.GetUserWithAllAttachments(userVm.Id);
            user = UserMapper.EditUsersVmToUser(userVm, user);
            user.City = cityDomainService.GetCity(userVm.CityId);
            user.Country = countryDomainService.GetCountry(userVm.CountryId);

            userDomainService.EditUser();

        }

        public DeleteUsersViewModel GetDeleteUsersVm(int id)
        {
            User user = userDomainService.GetUserWithAllAttachments(id);
            return UserMapper.UserToDeleteUsersVm(user);
        }

        public void DeleteUser(int userId)
        {
            userDomainService.DeleteUser(userId);

        }

        public CreateUsersViewModel GetCreateUsersVm()
        {
            return  new CreateUsersViewModel
            {
                SelectListCitys = GetCitiesSelectList(),
                SelectListCountries = GetCountrysSelectList()
            };
        }

        public CreateUsersViewModel GetCreateUsersVm(CreateUsersViewModel userVm)
        {
            userVm.SelectListCitys = GetCitiesSelectList();
            userVm.SelectListCountries = GetCountrysSelectList();
            return userVm;

        }

        public EditUsersViewModel GetEditUsersVm(EditUsersViewModel userVm)
        {
            userVm.SelectListCitys = GetCitiesSelectList();
            userVm.SelectListCountries = GetCountrysSelectList();
            return userVm;

        }

        private SelectList GetCitiesSelectList()
        {
            return new SelectList(cityDomainService.GetCitys(), "Id", "Name");

        }

        private SelectList GetCountrysSelectList()
        {
            return new SelectList(countryDomainService.GetCountrys(), "Id", "Name");

        }
    }
}