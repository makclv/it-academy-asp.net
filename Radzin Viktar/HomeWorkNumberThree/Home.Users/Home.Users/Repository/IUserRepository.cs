using Home.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home.Users.Repository
{
    interface IUserRepository
    {
        List<User> SelectAllUsers();
        User SelectUserById(int id);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
        int GetLastInsertedId();
    }
}
