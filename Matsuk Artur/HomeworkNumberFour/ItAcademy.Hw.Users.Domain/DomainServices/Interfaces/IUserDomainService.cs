using ItAcademy.Hw.Users.Domain.Models;

using System.Collections.Generic;

namespace ItAcademy.Hw.Users.Domain.DomainServices.Interfaces
{
    public interface IUserDomainService
    {
        List<User> GetUsers();
        void AddUser(User User);
        void ChangeUser( User User);
        void DeleteUser(int a);
        User FindUser(int a);
    }
}
