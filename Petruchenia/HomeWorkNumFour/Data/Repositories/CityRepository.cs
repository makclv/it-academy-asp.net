using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class CityRepository : BaseRepository <City>, ICityRepository
    {
        public CityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<City> GetAll()
        {
            return GetAllFromDb().ToList(); ;
        }

        public City GetCityById(int id)
        {
            return Get(id);
        }
    }
}
