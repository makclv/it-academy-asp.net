using ItAcademy.Hw.Users.Client.Models;
using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.Hw.Users.Client.Util.Mappers
{
    public static class Mapper
    {
        public static User UserViewToUser(UserView UserView)
        {
            return new User
            {
                Id = UserView.Id,
                City = UserView.City,
                Country = UserView.Country,
                Email = UserView.Email,
                Name = UserView.Name,
                Phone = UserView.Phone,
                Surname = UserView.Surname,
                Title = UserView.Title,
                Comments = UserView.Comments

            };
        }

        public static UserView UserToUserView(User User)
        {
            return new UserView
            {
                Id = User.Id,
                City = User.City,
                Country = User.Country,
                Email = User.Email,
                Name = User.Name,
                Phone = User.Phone,
                Surname = User.Surname,
                Title = User.Title,
                Comments = User.Comments

            };
        }

       public static User EditUserViewToUser (UserView UserView, User user)
        {
            user.Name = UserView.Name;
            user.Surname = UserView.Surname;
            user.Phone = UserView.Phone;
            user.Email = UserView.Email;
            user.Comments = UserView.Comments;
            user.Title = UserView.Title;


            return user;
        }
    }
}