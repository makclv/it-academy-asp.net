using ItAcademy.Hw.Users.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ItAcademy.Hw.Users.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        List<UserData> GetUsers();
        void AddUser(UserData UserData);
        void ChangeUser( UserData UserData);
        void DeleteUser(int a);
        UserData FindUser(int a);
        
    }
}
