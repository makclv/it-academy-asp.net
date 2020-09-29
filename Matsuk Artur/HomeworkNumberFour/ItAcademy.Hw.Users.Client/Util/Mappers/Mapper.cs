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

       public static User EditCreateUserViewToUser (CreateUserView CreateUserView, User user)
        {
            user.Name = CreateUserView.Name;
            user.Surname = CreateUserView.Surname;
            user.Phone = CreateUserView.Phone;
            user.Email = CreateUserView.Email;
            user.Comments = CreateUserView.Comments;
            user.Title = CreateUserView.Title;


            return user;
        }

        public static CreateUserView UserViewToCreateUserView(UserView UserView, CreateUserView CreateUserView)
        {
            CreateUserView.Id = UserView.Id;
            CreateUserView.City = UserView.City;
            CreateUserView.Country = UserView.Country;
            CreateUserView.Email = UserView.Email;
            CreateUserView.Name = UserView.Name;
            CreateUserView.Phone = UserView.Phone;
            CreateUserView.Surname = UserView.Surname;
            CreateUserView.Title = UserView.Title;
            CreateUserView.Comments = UserView.Comments;

            return CreateUserView;
        }

        public static UserView CreateUserViewToUserView(CreateUserView CreateUserView)
        {
            return new UserView 
            {
                Id = CreateUserView.Id,
                City = CreateUserView.City,
                Country = CreateUserView.Country,
                Email = CreateUserView.Email,
                Name = CreateUserView.Name,
                Phone = CreateUserView.Phone,
                Surname = CreateUserView.Surname,
                Title = CreateUserView.Title,
                Comments = CreateUserView.Comments
            };
            
        }

        public static User CreateUserViewToUser(CreateUserView CreateUserView)
        {
            return new User
            {
                Id = CreateUserView.Id,
                City = CreateUserView.City,
                Country = CreateUserView.Country,
                Email = CreateUserView.Email,
                Name = CreateUserView.Name,
                Phone = CreateUserView.Phone,
                Surname = CreateUserView.Surname,
                Title = CreateUserView.Title,
                Comments = CreateUserView.Comments
            };
            
        }
    }
}