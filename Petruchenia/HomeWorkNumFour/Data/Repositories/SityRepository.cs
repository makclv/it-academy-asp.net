using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class SityRepository : BaseRepository <Sity>, ISityRepository
    {
        public SityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public List<User> GetUsersBySity(string sity)
        {
            throw new NotImplementedException();
        }
    }
}
