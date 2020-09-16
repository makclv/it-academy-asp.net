using HW3.Domain.DomainServices.Interfaces;
using HW3.Domain.Models;
using HW3.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace HW3.Domain.DomainServices
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository userRepository;

        public UserDomainService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void CreateUser(User user)
        {
            userRepository.CreateUser(user);
        }

        public User ReadUser(Guid id)
        {
            return userRepository.ReadUser(id);
        }

        public void UpdateUser(User user)
        {
            userRepository.UpdateUser(user);
        }

        public void DeleteUser(Guid id)
        {
            userRepository.DeleteUser(id);
        }

        public List<User> AllUsers()
        {
            return userRepository.AllUsers();
        }

        public Country ReadCountry(Guid id)
        {
            return userRepository.ReadCountry(id);
        }

        public List<Country> AllCountries()
        {
            return userRepository.AllCountries();
        }

        public City ReadCity(Guid id)
        {
            return userRepository.ReadCity(id);
        }

        public List<City> AllCities()
        {
            return userRepository.AllCities();
        }

    }
}
