using Domain.Entites;
using System.Collections.Generic;

namespace Domain.Repository
{
    public interface ICityRepository : IBaseRepository<City>
    {
        List<City> GetAll();
        City GetCityById(int id);
    }
}
