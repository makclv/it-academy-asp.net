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

        public void EditUser(User user)
        {
            Edit(user);
        }

        public User GetById(int Id)
        {
            return Get(Id);
        }

        public List<User> GetUserByLastName(string name)
        {
            return GetItems().Where(m => m.LastName.Equals(name)).ToList();
        }

        public List<User> GetAll()
        {

            return GetAllFromDb().Include(u => u.Country).Include(u => u.City).ToList();
        }
        public void CreateUser (User user)
        {
            Create(user);
        }
    }
}
