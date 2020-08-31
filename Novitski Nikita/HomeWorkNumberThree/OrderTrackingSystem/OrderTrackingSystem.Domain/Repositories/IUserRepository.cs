using OrderTrackingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackingSystem.Domain.Repositories
{
    public interface IUserRepository
    {
        List<User> GetUsers();

        List<City> GetCitys();
        List<Country> GetCountrys();

        void AddUser(User user);
        City GetCity(Guid id);
        User GetUser(Guid id);
        Country GetCountry(Guid id);
        bool IsExistsUser(Guid id);
        void EditUser(User user);
        void DeleteUser(Guid userId);


    }
}
