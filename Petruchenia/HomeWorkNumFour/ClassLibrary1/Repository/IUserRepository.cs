using Domain.Entites;
using System.Collections.Generic;

namespace Domain.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetUserByLastName(string name);

        User GetById(int Id);

        void EditUser(User user);

        List<User> GetAll();

        void CreateUser(User user);
    }
}
