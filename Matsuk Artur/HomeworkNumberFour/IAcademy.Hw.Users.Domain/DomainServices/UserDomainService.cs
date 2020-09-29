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
        private readonly ICountryDomainService countryDomainService;
        public UserDomainService(IUserRepository UserRep, IUnitOfWork unitOfWork, ICountryDomainService countryDomainService)
        {
            this.UserRep = UserRep;
            this.unitOfWork = unitOfWork;
            this.countryDomainService = countryDomainService;

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
            unitOfWork.SaveChanges();
        }

        public List<User> GetUsers()
        {
            return UserRep.GetAllWithAllAttachments();
           

        }

        public User FindUser(int a)
        {
            return UserRep.Get(a);
        }

        public User GetUser(int id)
        {
            return UserRep.GetUser(id);
        }

        public bool IsUniquePhone(string phone, int id)
        {
            return !UserRep.GetQueryableItems().Any(c => c.Phone == phone&&c.Id!=id);

        }

        public bool IsUniqueEmail(string email, int id)
        {
           return !UserRep.GetQueryableItems().Any(c => c.Email == email && c.Id != id);

        }

        public bool IsUniqueName(string Name, string Surname, int id)
        {
            var Users = UserRep.GetAll();
            foreach(var a in Users)
            {
                if (a.Name == Name && a.Id!=id)
                    if (a.Surname == Surname)
                        return false;
            }

            return true;

        }

        public bool IsCityBelongsToCountry(int countryId, int cityId)
        {
            return countryDomainService.IsCityBelongsToCountry(countryId, cityId);
        }
    }
}
