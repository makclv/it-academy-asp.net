using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackingSystem.Domain.DomainServices
{
    public class UserDomainService : IUserDomainService
    {
        IUserRepository repository;
        public UserDomainService(IUserRepository repository)
        {
            this.repository = repository;
        }

        public List<User> GetUsers()
        {
            return repository.GetUsers();
        }

        public List<City> GetCitys()
        {
            return repository.GetCitys();
        }
        public List<Country> GetCountrys()
        {
            return repository.GetCountrys();
        }

        public void AddUser(User user)
        {
            repository.AddUser(user);
        }

        public City GetCity(Guid id)
        {
            return repository.GetCity(id);
        }
        public Country GetCountry(Guid id)
        {
            return repository.GetCountry(id);
        }

        public bool VerificationUserId(Guid id)
        {
            return repository.IsExistsUser(id);
        }
        public User GetUser(Guid id)
        {
            return repository.GetUser(id);
        }

        public void EditUser(User user)
        {
            repository.EditUser(user);
        }

        public void DeleteUser(Guid userId)
        {
            repository.DeleteUser(userId);
        }
    }
}
