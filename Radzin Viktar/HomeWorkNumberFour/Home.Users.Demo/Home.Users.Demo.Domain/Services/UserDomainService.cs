using Home.Users.Demo.Domain.Entities;
using Home.Users.Demo.Domain.Repositories;
using Home.Users.Demo.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Home.Users.Demo.Domain.Services
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository userRepository;

        public UserDomainService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void DeleteUser(int id)
        {
            userRepository.DeleteUser(id);
        }

        public List<City> GetCities()
        {
            return userRepository.GetCities();
        }

        public List<Country> GetCountries()
        {
            return userRepository.GetCountries();
        }

        public void InsertUser(User user)
        {
            userRepository.InsertUser(user);
        }

        public bool IsUniqueFirstName(string firstname)
        {
            return userRepository.SelectAllUsers().Any(x => x.FirstName == firstname);
        }

        public bool IsUniqueLastName(string lastname)
        {
            return userRepository.SelectAllUsers().Any(x => x.LastName == lastname);
        }

        public bool IsUniqueMail(string mail)
        {
            return userRepository.SelectAllUsers().Any(x => x.Email == mail);
        }

        public bool IsUniquePhone(string phone)
        {
            return userRepository.SelectAllUsers().Any(x => x.Phone == phone);
        }

        public List<User> SelectAllUsers()
        {
            return userRepository.SelectAllUsers();
        }

        public User SelectUserById(int id)
        {
            return userRepository.SelectUserById(id);
        }

        public User SelectUserByIdWithCountryandCity(int id)
        {
            return userRepository.SelectUserByIdWithCountryandCity(id);
        }

        public void UpdateUser(User user)
        {
            userRepository.UpdateUser(user);
        }


    }
}
