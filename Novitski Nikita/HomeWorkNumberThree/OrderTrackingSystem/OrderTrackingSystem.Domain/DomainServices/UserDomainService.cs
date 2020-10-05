using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.UnitOfWork;
using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.DomainServices
{
    public class UserDomainService : IUserDomainService
    {
        private readonly IUserRepository userRepository;
        private readonly ICityDomainService cityDomainService;
        private readonly ICountryDomainService countryDomainService;
        private readonly IUnitOfWork unitOfWork;

        public UserDomainService(IUserRepository userRepository, IUnitOfWork unitOfWork, ICityDomainService cityDomainService, ICountryDomainService countryDomainService)
        {
            this.userRepository = userRepository;
            this.cityDomainService = cityDomainService;
            this.countryDomainService = countryDomainService;
            this.unitOfWork = unitOfWork;

        }

        public List<User> GetUsersWithAllAttachments()
        {
            return userRepository.GetAllWithAllAttachments();

        }

        public void AddUser(User user)
        {
            userRepository.Add(user);
            unitOfWork.SaveChanges();

        }

        public bool VerificationUserId(int id)
        {
            return userRepository.IsExistsUser(id);

        }

        public void EditUser()
        {
            unitOfWork.SaveChanges();

        }

        public User GetUserWithAllAttachments(int id)
        {
            return userRepository.GetUserWithAllAttachments(id);

        }

        public void DeleteUser(int userId)
        {
            userRepository.DeleteById(userId);
            unitOfWork.SaveChanges();

        }

        public bool IsUniquePhone(string phone)
        {
            return userRepository.IsUniquePhone(phone);

        }

        //public bool IsUniquePhoneNotCheckingYourself(string phone)
        //{
        //    if(phone == oldUserData.Phone)
        //    {
        //        return true;
        //    }
        //    return userRepository.IsUniquePhone(phone);
        //}

        public bool IsUniquePhoneNotCheckingYourself(int id, string phone)
        {
            return userRepository.IsUniquePhone(id, phone);
        }

        public bool IsUniqueEmailNotCheckingYourself(int id,string email)
        {
            return userRepository.IsUniqueEmail(id,email);
        }

        public bool IsUniqueEmail(string email)
        {
            return userRepository.IsUniqueEmail(email);

        }

        public bool IsUniqueFullName(string fullName)
        {
            List<string> allFullNames = new List<string>();
            userRepository.GetFullNames()
                .ForEach(c => allFullNames.Add($"{c.FirstName}+{c.LastName}"));

            return !allFullNames.Contains(fullName);

        }

        public bool IsUniqueFullName(int id,string firstName, string lastName)
        {

            return userRepository.IsUniqueFullName(id, firstName, lastName);

        }

        //public bool IsUniqueFullNameNotCheckingYourself(string fullName)
        //{
        //    if(GetUserFullName() == fullName)
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        List<string> allFullNames = new List<string>();
        //        userRepository.GetFullNames()
        //            .ForEach(c => allFullNames.Add($"{c.FirstName}+{c.LastName}"));

        //        return !allFullNames.Contains(fullName);
        //    }    
        //}

        //private string GetUserFullName()
        //{
        //    return  $"{oldUserData.FirstName}+{oldUserData.LastName}";
        //}

        public bool IsCityBelongsCountry(int countryId, int cityId)
        {
            return countryDomainService.IsCityBelongsCountry(countryId, cityId);

        }
    }
}
