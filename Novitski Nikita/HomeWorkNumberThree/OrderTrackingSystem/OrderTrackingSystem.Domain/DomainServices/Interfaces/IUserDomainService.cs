﻿using OrderTrackingSystem.Domain.Models;
using System.Collections.Generic;

namespace OrderTrackingSystem.Domain.DomainServices.Interfaces
{
    public interface IUserDomainService : IBaseDomainService
    {
        List<User> GetUsersWithAllAttachments();
        void AddUser(User user);
        bool VerificationUserId(int id);
        User GetUserWithAllAttachments(int id);
        void DeleteUser(int userId);
        void EditUser();
        bool IsUniquePhone(string phone);
        bool IsUniqueEmail(string email);
        bool IsUniqueFullName(string fullName);
        //bool IsUniqueFullNameNotCheckingYourself(string fullName);
        bool IsUniqueFullName(int id, string firstName, string lastName);
        bool IsCityBelongsCountry(int countryId, int cityId);
        //bool IsUniquePhoneNotCheckingYourself(string phone);
        bool IsUniqueEmailNotCheckingYourself(int id,string email);
        bool IsUniquePhoneNotCheckingYourself(int id, string phone);

    }
}
