using Home.Users.Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Home.Users.Demo.Services.Interfaces
{
    public interface IUserPresentationService
    {
        List<CityViewModel> GetCities();

        List<CountryViewModel> GetCountries();

        List<UserViewModel> SelectAllUsers();

        UserViewModel SelectUserById(int id);

        UserViewModel SelectUserByIdWithCountryandCity(int id);

        void InsertUser(UserViewModel user);

        void UpdateUser(UserViewModel user);

        void DeleteUser(int id);

        bool IsUniqueFirstName(string firstname);

        bool IsUniqueLastName(string lastname);

        bool IsUniquePhone(string phone);

        bool IsUniqueMail(string mail);


    }
}
