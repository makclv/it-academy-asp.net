using Domain.Entites;
using System.Collections.Generic;

namespace Domain.Repository
{
    public interface ISityRepository : IBaseRepository<Sity>
    {
        List<User> GetUsersBySity(string sity);
    }
}
