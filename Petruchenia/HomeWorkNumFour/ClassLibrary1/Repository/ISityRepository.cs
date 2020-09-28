using Domain.Entites;
using System.Collections.Generic;

namespace Domain.Repository
{
    public interface ISityRepository : IBaseRepository<Sity>
    {
        List<Sity> GetAll();
    }
}
