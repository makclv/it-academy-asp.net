using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public CountryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public List<Country> GetAll()
        {
            return GetAllFromDb().ToList();
        }

        public Country GetCountryById(int id)
        {
            return Get(id);
        }

        public Country GetCountryWithCities(int id)
        {
            var obj = Get(id);
            unitOfWork.Entry(obj).Collection(c => c.Cities).Load();

            return obj;
        }
    }
}
