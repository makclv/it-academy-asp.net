using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Models;
using HomeWorkNumberFour.BLL.UnitOfWork;
using HomeWorkNumberFour.ClientLayer.Repository.Base;
using System.Linq;

namespace HomeWorkNumberFour.ClientLayer.Repository
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork) { }

        public User GetUserById(int id)
        {
            return GetAll()
                .Where(x => x.Id == id)
                .FirstOrDefault();
        }
    }
}
