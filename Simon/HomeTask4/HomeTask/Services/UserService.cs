using HomeTask.Models;
using HomeTask.Repository;
using HomeTask.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace HomeTask.Services
{
    public class UserService : IUsersService
    {
        private readonly IUserRepository userRepository;
        private User User; 
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public List<User> AddUser(User user)
        {
           return userRepository.Add(user);
        }

        public void DeleteUser(int id)
        {
             userRepository.Delete(id);
        }

        public List<User> EditUser(User user)
        {
            return userRepository.Edit(user);
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        public bool IsUniqueEmail(string email)
        {
            if (userRepository.GetAllUsers().Where(x => x.Id != User.Id).Select(x => x.Email).Contains(email))
            {
                return false;
            }
            return true;
        }

        public bool IsUniquePhone(string phone)
        {
            if (userRepository.GetAllUsers().Where(x => x.Id != User.Id).Select(x => x.Phone).Contains(phone))
            {
                return false;
            }
            return true;
        }

        public bool VerificationUserId(int userId)
        {
            User = userRepository.GetUser(userId);
            return true;
        }
    }
}