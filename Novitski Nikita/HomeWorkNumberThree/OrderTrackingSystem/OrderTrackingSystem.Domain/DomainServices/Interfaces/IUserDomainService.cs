using OrderTrackingSystem.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackingSystem.Domain.DomainServices.Interfaces
{
    public interface IUserDomainService
    {
         List<User> GetUsers();
         List<City> GetCitys();
         List<Country> GetCountrys();
         void AddUser(User user);
         City GetCity(Guid id);
         Country GetCountry(Guid id);
         bool  VerificationUserId(Guid id);
         User GetUser(Guid id);
         void EditUser(User user);
        void DeleteUser(Guid userId);


    }
}
