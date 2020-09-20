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
                FIO = $"{user.FirstName} {user.LastName}",
                Title = user.Title,
                CountryName = user.Address.CountryName,
                CityName = user.Address.CityName,
                Phone = user.Phone,
                Email = user.Email,
                Comments = user.Comments//,
                //CountryList = user.CountryList,
                //CityList = user.CityList
            };

            return userViewModel;
        }

        public static User ToUserModel(UserViewModel viewUser)
        {
            var splitFIO = viewUser.FIO.Split(new Char[] { ' ' });
            var userModel = new User()
            {
                Id = viewUser.Id,
                FirstName = splitFIO[0],
                LastName = splitFIO[1],
                Title = viewUser.Title,
                Address = new Address()
                {
                    CountryName = viewUser.CountryName,
                    CityName = viewUser.CityName
                },
                Phone = viewUser.Phone,
                Email = viewUser.Email,
                Comments = viewUser.Comments//,
                //CountryList = viewUser.CountryList,
                //CityList = viewUser.CityList
            };

            return userModel;
        }
    }
}