using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace Data.Repositories
{
    public class SityRepository : BaseRepository <Sity>, ISityRepository
    {
        public SityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<Sity> GetAll()
        {
            return GetAllFromDb().ToList(); ;
        }
    }
}
