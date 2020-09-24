using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface ISityRepository : IBaseRepository<Sity>
    {
        List<User> GetUsersBySity(string sity);
    }
}
