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
            if (userRepository.SelectAllUsers().Any(x => x.FirstName == firstname))
            { 
                return false;
            }
            else 
            { 
                return true;
            }
        }
    
        public bool IsUniqueLastName(string lastname)
        {
            if(userRepository.SelectAllUsers().Any(x => x.LastName == lastname))
            { 
                return false; 
            }
            else 
            {
                return true;
            }
        }

        public bool IsUniqueMail(string mail)
        {
            if(userRepository.SelectAllUsers().Any(x => x.Email == mail))
            { 
                return false; 
            }
            else 
            {
                return true;
            }
        }

        public bool IsUniquePhone(string phone)
        {
            if(userRepository.SelectAllUsers().Any(x => x.Phone == phone))
            { 
                return false; 
            }
            else 
            {
                return true;
            }
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
