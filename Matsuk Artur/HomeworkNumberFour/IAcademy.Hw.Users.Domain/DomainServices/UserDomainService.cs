using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.Models;
using ItAcademy.Hw.Users.Domain.Repositories;
using ItAcademy.Hw.Users.Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;


namespace ItAcademy.Hw.Users.Domain.DomainServices
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository UserRep;
        private readonly IUnitOfWork unitOfWork;
        public UserDomainService(IUserRepository UserRep)
        {
            this.UserRep = UserRep;
        }
        public void AddUser(User User)
        {
            UserRep.Add(User);
            unitOfWork.SaveChanges();

        }

        public void ChangeUser()
        {
           
            unitOfWork.SaveChanges();
        }

        public void DeleteUser(int a)
        {
            UserRep.DeleteById(a);
        }

        public List<User> GetUsers()
        {
            return UserRep.GetAll();
           

        }

        public User FindUser(int a)
        {
            return UserRep.Get(a);
        }

        public User GetUser(int id)
        {
            return UserRep.GetUser(id);
        }

        public bool IsUniquePhone(string phone)
        {
            return !UserRep.GetQueryableItems().Any(c => c.Phone == phone);

        }

        public bool IsUniqueEmail(string email)
        {
           return !UserRep.GetQueryableItems().Any(c => c.Email == email);

        }

        public bool IsUniqueName(string Name, string Surname)
        {
            var Users = UserRep.GetAll();
            foreach(var a in Users)
            {
                if (a.Name == Name)
                    if (a.Surname == Surname)
                        return false;
            }

            return true;

        }

        public bool IsCityBelongsToCountry(User user)
        {
            return user.Country.Cities.Contains(user.City);
        }
    }
}
