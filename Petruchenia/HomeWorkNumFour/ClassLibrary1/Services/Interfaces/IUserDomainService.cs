using Domain.Entites;
using System.Collections.Generic;

namespace ClassLibrary1.Services.Interfaces
{
    public interface IUserDomainService : IBaseDomainService
    {
        List<User> GetUserByLastName(string name);
        void Create(User user);
        User GetById(int Id);
        void EditUser(User user);
        List<User> GetAll();
        void DeleteUser(int id);
    }
}
