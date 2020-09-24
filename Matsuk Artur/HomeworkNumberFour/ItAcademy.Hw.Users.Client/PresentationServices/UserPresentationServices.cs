using ItAcademy.Hw.Users.Client.Models;
using ItAcademy.Hw.Users.Client.PresentationServices.Interfaces;
using ItAcademy.Hw.Users.Client.Util.Mappers;
using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public void ChangeUser(UserView UserView)
        {
            User user = userDomainService.GetUser(UserView.Id);
            user = Mapper.EditUserViewToUser(UserView, user);
            user.City = cityDomainService.GetCity(UserView.City.Id);
            user.Country = countryDomainService.GetCountry(UserView.Country.Id);

            userDomainService.ChangeUser();
        }
    }
}