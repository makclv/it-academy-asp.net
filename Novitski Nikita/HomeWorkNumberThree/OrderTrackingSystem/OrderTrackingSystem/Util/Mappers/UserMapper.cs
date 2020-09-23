using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.ViewModels.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OrderTrackingSystem.Util.Mappers
{
    public static class UserMapper
    {

        public static User CreateUsersVmToUser(CreateUsersViewModel userVm)
        {
            return new User
            {
                Id =Guid.NewGuid(),
                FirsName = userVm.FirsName,
                LastName = userVm.LastName,
                Phone = userVm.Phone,
                Email =userVm.Email,
                Comments = userVm.Comments,
                CityId =userVm.CityId,
                CountryId=userVm.CountryId,
                Title= userVm.Title

            };
        }

        public static GetUsersViewModel UserToGetUserVm(User user)
        {
            return new GetUsersViewModel
            {
                Id = user.Id,
                Name = $"{user.FirsName} {user.LastName}",
                Title = user.Title,
                Country = user.Country,
                City = user.City,
                Phone = user.Phone,
                Email = user.Email

            };
        }

        
        public static EditUsersViewModel UserToEditUsersVm(User user)
        {
            return new EditUsersViewModel
            {
                Id =user.Id,
                FirsName = user.FirsName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email,
                Comments = user.Comments,
                CityId = user.CityId,
                CountryId = user.CountryId,
                Title = user.Title

            };
        }

        
        public static User EditUsersVmToUser(EditUsersViewModel userVm)
        {
            return new User
            {
                Id = userVm.Id,
                FirsName = userVm.FirsName,
                LastName = userVm.LastName,
                Phone = userVm.Phone,
                Email = userVm.Email,
                Comments = userVm.Comments,
                CityId = userVm.CityId,
                CountryId = userVm.CountryId,
                Title = userVm.Title,

            };
        }

        public static DeleteUsersViewModel UserToDeleteUsersVm(User user)
        {
            return new DeleteUsersViewModel
            {
                Id = user.Id,
                Name = $"{user.FirsName} {user.LastName}",
                Phone = user.Phone,
                Email = user.Email,
                Comments = user.Comments,
                City = user.City,
                Country = user.Country,
                Title = user.Title

            };
        }

        
    }
}