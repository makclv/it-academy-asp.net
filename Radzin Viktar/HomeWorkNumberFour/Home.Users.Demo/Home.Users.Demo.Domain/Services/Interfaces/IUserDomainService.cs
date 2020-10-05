using Home.Users.Demo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Users.Demo.Domain.Services.Interfaces
{
    public interface IUserDomainService
    {
        List<User> SelectAllUsers();

        List<City> GetCities();

        List<Country> GetCountries();

        User SelectUserById(int id);

        User SelectUserByIdWithCountryandCity(int id);

        void InsertUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);

        bool ifCityOfCountry(int cityId, int countryId);

        bool IsUniqueMail(string mail);

        bool IsUniquePhone(string phone);

        bool IsUniqueFirstName(string firstname);

        bool IsUniqueLastName(string lastname);


    }
}
