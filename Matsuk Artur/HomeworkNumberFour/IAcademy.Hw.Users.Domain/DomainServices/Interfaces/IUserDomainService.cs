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
        bool IsUniquePhone(string phone);
        bool IsUniqueEmail(string email);
        bool IsUniqueName(string Name, string Surname);
        bool IsCityBelongsToCountry(User user);
        User GetUser(int id);
    }
}
