using System.Collections.Generic;
using ThirdHomeWork.BLL.Models;

namespace ThirdHomeWork.BLL.Interfaces.Services
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
