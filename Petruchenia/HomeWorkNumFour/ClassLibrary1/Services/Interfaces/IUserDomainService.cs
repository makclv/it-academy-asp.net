using Domain.Entites;
using System.Collections.Generic;

namespace ClassLibrary1.Services.Interfaces
{
    public interface IUserDomainService : IBaseDomainService
    {
        List<User> GetUserByLastName(string name);
        void AddUser(User user);
    }
}
