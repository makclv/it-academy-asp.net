using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.OtherModels;
using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.Repositories
{
    public interface IUserRepository : IBaseRepository<User>
    {
        bool IsExistsUser(int id);
        bool IsUniquePhone(string phone);
        bool IsUniquePhone(int id,string phone);
        bool IsUniqueEmail(int id,string email);
        bool IsUniqueEmail(string email);
        List<UserFullName> GetFullNames();
        User GetUserWithAllAttachments(object id);
        List<User> GetAllWithAllAttachments();
        bool IsUniqueFullName(int id, string firstName, string lastName);

    }
}
