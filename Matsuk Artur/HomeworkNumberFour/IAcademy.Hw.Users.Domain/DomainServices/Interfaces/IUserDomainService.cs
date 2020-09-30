using ItAcademy.Hw.Users.Domain.Models;

using System.Collections.Generic;

namespace ItAcademy.Hw.Users.Domain.DomainServices.Interfaces
{
    public interface IUserDomainService
    {
        List<User> GetUsers();
        void AddUser(User User);
        void ChangeUser();
        void DeleteUser(int a);
        User FindUser(int a);
        bool IsUniquePhone(string phone, int id);
        bool IsUniqueEmail(string email,int id);
        bool IsUniqueName(string Name, string Surname, int id);
        User GetUser(int id);
    }
}
