using HomeWorkNumberFour.BLL.Models;
using System.Collections.Generic;

namespace HomeWorkNumberFour.BLL.Interfaces.Services
{
    public interface IUserService
    {
        List<User> GetUsers();

        User GetUserById(int id);

        void AddUser(User user);

        void UpdateUser(User user);

        void DeleteUser(int id);
    }
}
