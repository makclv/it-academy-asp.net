using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.UnitOfWork;
using System.Data.Entity;
using System.Linq;

namespace OrderTrackingSystem.Data.Repositories
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public CityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }


        public City GetCityWithCountry(object id)
        {
            var entityCity = Get(id);
            unitOfWork.Entry(entityCity).Reference(c => c.Country).Load();

            return entityCity;

        }

        public bool IsExistsCity(int id)
        {
            return GetQueryableItems().Any(c => c.Id == id);

        }
    }
}
