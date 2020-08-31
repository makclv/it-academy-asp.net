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
    }
}