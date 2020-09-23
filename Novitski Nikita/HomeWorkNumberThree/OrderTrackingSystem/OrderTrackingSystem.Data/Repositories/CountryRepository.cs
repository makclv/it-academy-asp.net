using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.UnitOfWork;
using System.Data.Entity;
using System.Linq;

namespace OrderTrackingSystem.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public CountryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

       
        public Country GetCountryWithCities(object id)
        {

            var entityCountry = Get(id);
            unitOfWork.Entry(entityCountry).Collection(c => c.Cities).Load();

            return entityCountry;

        }

        public bool IsExistsCountry(int id)
        {
            return GetQueryableItems().Any(c => c.Id == id);
        }

    }
}
