using Domain.Entites;
using Domain.Repository;
using Domain.UnitOfWork;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository (IUnitOfWork unitOfWork) : base (unitOfWork)
        {

        }
        
        public List<User> GetUserByLastName(string name)
        {
            return GetItems().Where(m => m.LName.Equals(name)).ToList();
        }
    }
}
