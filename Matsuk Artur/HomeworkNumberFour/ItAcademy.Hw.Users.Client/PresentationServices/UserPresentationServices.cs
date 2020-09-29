using ItAcademy.Hw.Users.Client.Models;
using ItAcademy.Hw.Users.Client.PresentationServices.Interfaces;
using ItAcademy.Hw.Users.Client.Util.Mappers;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.Hw.Users.Client.PresentationServices
{
    public class UserPresentationServices : IUserPresentationServices
    {
        private readonly IUserDomainService userDomainService;
        private readonly ICountryDomainService countryDomainService;
        private readonly ICityDomainService cityDomainService;

        public UserPresentationServices(IUserDomainService userDomainService, ICountryDomainService countryDomainService, ICityDomainService cityDomainService)
        {
            this.userDomainService = userDomainService;
            this.countryDomainService = countryDomainService;
            this.cityDomainService = cityDomainService;
        }
        public void ChangeUser(CreateUserView CreateUserView)
        {
            User user = userDomainService.GetUser(CreateUserView.Id);
            user = Mapper.EditCreateUserViewToUser(CreateUserView, user);
            user.City = cityDomainService.GetCity(CreateUserView.CityId);
            user.Country = countryDomainService.GetCountry(CreateUserView.CountryId);

            userDomainService.ChangeUser();
        }

        public void AddUser(CreateUserView createUserView)
        {
            User user = Mapper.CreateUserViewToUser(createUserView);
            user.City = cityDomainService.GetCity(createUserView.CityId);
            user.Country = countryDomainService.GetCountry(createUserView.CountryId);

            userDomainService.AddUser(user);

        }

        public CreateUserView CreateEmptyUser()
        {
            CreateUserView CreateUserView = new CreateUserView
            {
                SelectListCities = new SelectList(cityDomainService.GetCities(), "Id", "Name"),
                SelectListCountries = new SelectList(countryDomainService.GetCountries(), "Id", "Name")
            };

            return CreateUserView;
        }

      

    }
}