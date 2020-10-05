using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Services.interfaces
{
   public interface IUsersService
    {
        List<User> AddUser(User user);

        void DeleteUser(int id);

        List<User> EditUser(User user);

        List<User> GetAllUsers();

        bool VerificationUserId(int userId);

        bool IsUniqueEmail(string email);

        bool IsUniquePhone(string phone);


    }
}
