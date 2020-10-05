using HW4.Domain.Models;
using HW4.Domain.Models.Other;
using System.Collections.Generic;

namespace HW4.Domain.Repositories.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetAllUsers();
        User GetUser(int id);
        bool UniquenessOfPhone(int id, string phone);
        bool UniquenessOfEmail(int id, string email);
        bool UniquenessOfFullName(int id, string firstName, string lastName);
    }
}
