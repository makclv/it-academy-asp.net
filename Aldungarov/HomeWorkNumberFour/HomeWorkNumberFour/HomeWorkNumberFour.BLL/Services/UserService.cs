using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Interfaces.Services;
using HomeWorkNumberFour.BLL.Models;
using System.Collections.Generic;

namespace HomeWorkNumberFour.BLL.Services
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public void AddUser(User user)
        {
            userRepository.Add(user);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            userRepository.Delete(id);
        }

        public List<User> GetUsers()
        {
            return userRepository.GetUsers();
        }

        public User GetUserById(int id)
        {
            return userRepository.GetUserById(id);
        }
    }
}
