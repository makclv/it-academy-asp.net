using HW3.Client.Models;
using HW3.Domain.Models;
using System;

namespace HW3.Client.Util
{
    public class Mapper
    {
        public User CreateUserViewModelMapping(CreateUserViewModel user)
        {
            return new User
            {
                Id = Guid.NewGuid(),
                FirstName = user.FirstName,
                LastName = user.LastName,
                Title = user.Title,
                Phone = user.Phone,
                Email = user.Email,
                Comments = user.Comments,
                CountryId = user.CountryId,
                CityId = user.CityId,
            };
        }

        public AllUsersViewModel AllUsersViewModelMapping(User user)
        {
            return new AllUsersViewModel
            {
                Id = user.Id,
                Name = $"{user.FirstName} {user.LastName}",
                Title = user.Title,
                Country = user.Country,
                City = user.City,
                Phone = user.Phone,
                Email = user.Email
            };
        }

        public EditUserViewModel EditUserViewModelMapping(User user)
        {
            return new EditUserViewModel
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email,
                Title = user.Title,
                CountryId = user.CountryId,
                CityId = user.CityId,
                Comments = user.Comments,
            };
        }

        public User EditUserViewModelMappingToUser(EditUserViewModel user)
        {
            return new User
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.Phone,
                Email = user.Email,
                Title = user.Title,
                CountryId = user.CountryId,
                CityId = user.CityId,
                Comments = user.Comments,
            };
        }

        public DeleteUserViewModel DeleteUserViewModelMapping(User user)
        {
            return new DeleteUserViewModel
            {
                Id = user.Id,
                Name = $"{user.FirstName} {user.LastName}",
            };
        }
    }
}