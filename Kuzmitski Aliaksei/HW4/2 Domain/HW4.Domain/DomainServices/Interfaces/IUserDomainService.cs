using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices.Interfaces
{
    public interface IUserDomainService : IBaseDomainService
    {
        List<User> GetAllUsers();
        void AddUser(User user);
        User GetUser(int id);
        void EditUser();
        void DeleteUser(int userId);
        bool UniquenessOfFullName(int id, string firstName, string lastName);
        bool UniquenessOfPhone(int id, string phone);
        bool UniquenessOfEmail(int id, string email);

    }
}
