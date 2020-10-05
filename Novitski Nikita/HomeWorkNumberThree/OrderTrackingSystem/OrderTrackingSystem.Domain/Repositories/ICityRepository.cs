using OrderTrackingSystem.Domain.Models;

namespace OrderTrackingSystem.Domain.Repositories
{
    public interface ICityRepository : IBaseRepository<City>
    {
        City GetCityWithCountry(object id);
        bool IsExistsCity(int id);
    }
}
