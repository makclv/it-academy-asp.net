using HW4.Domain.Models;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;

namespace HW4.Data.Repositories
{
    public class CityRepository : BaseRepository<City>, ICityRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public CityRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
    }
}
