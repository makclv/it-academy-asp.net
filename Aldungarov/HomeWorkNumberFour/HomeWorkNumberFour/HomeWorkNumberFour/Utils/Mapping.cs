using HomeWorkNumberFour.BLL.Models;
using HomeWorkNumberFour.ViewModels;
using System;

namespace HomeWorkNumberFour.Utils
{
    public static class Mapping
    {
        public static UserViewModel ToUserViewModel(User user)
        {
            var userViewModel = new UserViewModel()
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Title2 = user.Title,
                CountryName = user.Address.CountryName,
                CityName = user.Address.CityName,
                Phone = user.Phone,
                Email = user.Email,
                Comments = user.Comments
            };

            return userViewModel;
        }

        public static User ToUserModel(UserViewModel viewUser)
        {
            var userModel = new User()
            {
                Id = viewUser.Id,
                FirstName = viewUser.FirstName,
                LastName = viewUser.LastName,
                Title = viewUser.Title2,
                Address = new Address()
                {
                    CountryName = viewUser.CountryName,
                    CityName = viewUser.CityName
                },
                Phone = viewUser.Phone,
                Email = viewUser.Email,
                Comments = viewUser.Comments
            };

            return userModel;
        }
    }
}