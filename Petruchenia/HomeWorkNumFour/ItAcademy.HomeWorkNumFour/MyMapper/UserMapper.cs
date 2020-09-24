using Domain.Entites;
using ItAcademy.HomeWorkNumFour.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ItAcademy.HomeWorkNumFour.MyMapper
{
    public class UserMapper
    {
        public User UserViewModelToUser (UserViewModel uwm)
        {
            return new User
            {
                FName = uwm.FName,
                LName = uwm.LName,
                Phone = uwm.Phone,
                Email = uwm.Email,
                Title = (Title)uwm.Title,
                Comment = uwm.Comment
            };
        }
    }
}