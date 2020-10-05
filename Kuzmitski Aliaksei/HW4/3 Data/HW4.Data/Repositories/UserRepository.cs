using HW4.Domain.Models;
using HW4.Domain.Models.Other;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace HW4.Data.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public UserRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public List<User> GetAllUsers()
        {
            return GetSelectedInfo()
                .Include(x => x.Country)
                .Include(x => x.City)
                .ToList();
        }

        public User GetUser(int id)
        {
            var user = Get(id);
            unitOfWork.Entry(user).Reference(x => x.Country).Load();
            unitOfWork.Entry(user).Reference(x => x.City).Load();
            return user;
        }

        public bool UniquenessOfEmail(int id, string email)
        {
            if (!id.Equals(0))
            {
                if (Get(id).Email.Equals(email))
                {
                    return true;
                }
                else
                {
                    return !GetSelectedInfo().Any(x => x.Email.Equals(email));
                }
            }
            else
            {
                return !GetSelectedInfo().Any(x => x.Email.Equals(email));
            }
        }

        public bool UniquenessOfPhone(int id, string phone)
        {
            if (!id.Equals(0))
            {
                if (Get(id).Phone.Equals(phone))
                {
                    return true;
                }
                else
                {
                    return !GetSelectedInfo().Any(x => x.Phone.Equals(phone));
                }
            }
            else
            {
                return !GetSelectedInfo().Any(x => x.Phone.Equals(phone));
            }
        }

        public bool UniquenessOfFullName(int id, string firstName, string lastName)
        {
            if (!id.Equals(0))
            {
                var user = Get(id);
                if (user.FirstName.Equals(firstName) && user.LastName.Equals(lastName))
                {
                    return true;
                }
                else
                {
                    return !GetSelectedInfo().Any(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));
                }
            }
            else
            {
                return !GetSelectedInfo().Any(c => c.FirstName.Equals(firstName) && c.LastName.Equals(lastName));
            }
        }
    }
}