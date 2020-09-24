using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface IUserRepository : IBaseRepository<User>
    {
        List<User> GetUserByName(string name);
    }
}
