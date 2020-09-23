using Home.Users.Demo.Domain.Entities;
using System.Collections.Generic;


namespace Home.Users.Demo.Domain.Repositories
{
    public interface IUserRepository
    {
        List<User> SelectAllUsers();

        List<City> GetCities();

        List<Country> GetCountries();

        User SelectUserById(int id);

        User SelectUserByIdWithCountryandCity(int id);

        void InsertUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);

    }
}
