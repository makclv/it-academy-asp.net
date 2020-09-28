using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        public CountryRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<Country> GetAll()
        {
            return GetAllFromDb().ToList();
        }
    }
}
