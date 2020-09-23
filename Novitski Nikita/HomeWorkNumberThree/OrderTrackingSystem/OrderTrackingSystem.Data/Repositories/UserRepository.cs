using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using OrderTrackingSystem.Domain.OtherModels;

namespace OrderTrackingSystem.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IUnitOfWork unitOfWork;
        public UserRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool IsExistsUser(int id)
        {
            return GetQueryableItems().Any(c => c.Id == id);

        }

        public User GetUserWithAllAttachments(object id)
        {
      
            var entityUser = Get(id);
            unitOfWork.Entry(entityUser).Reference(c => c.City).Load();
            unitOfWork.Entry(entityUser).Reference(c => c.Country).Load();

            return entityUser;

        }

        public List<User> GetAllWithAllAttachments()
        {
            return GetQueryableItems()
                .Include(c => c.City)
                .Include(c => c.Country)
                .ToList();

        }

        public bool IsUniquePhone(string phone)
        {
            return !GetQueryableItems().Any(c => c.Phone == phone);

        }

        public bool IsUniqueEmail(string email)
        {
            return !GetQueryableItems().Any(c => c.Email == email);

        }

        public  List<UserFullName> GetFullNames()
        {
            return GetQueryableItems().Select(c => new UserFullName
            {
                FirstName = c.FirstName,
                LastName = c.LastName
            }).ToList();

        }
        
    }
}
