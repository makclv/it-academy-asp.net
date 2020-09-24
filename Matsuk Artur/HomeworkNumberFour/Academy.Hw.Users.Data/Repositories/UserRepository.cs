using ItAcademy.Hw.Users.Domain.Models;
using ItAcademy.Hw.Users.Domain.Repositories;
using ItAcademy.Hw.Users.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Data.Repositories
{
   public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        public User GetUser(object id)
        {

            var entityUser = Get(id);
            unitOfWork.Entry(entityUser).Reference(c => c.City).Load();
            unitOfWork.Entry(entityUser).Reference(c => c.Country).Load();

            return entityUser;

        }
    }
}
