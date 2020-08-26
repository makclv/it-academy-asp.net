using ItAcademy.Hw.Users.Data.Models;
using ItAcademy.Hw.Users.Domain.Models;

namespace ItAcademy.Hw.Users.Domain.Infrastructure
{
   public static class Mapper
    {
        public static User UserDataToUser(UserData UserData)
        {
            return new User
            {
                Id = UserData.Id,
                City = UserData.City,
                Country = UserData.Country,
                Email = UserData.Email,
                Name = UserData.Name,
                Phone = UserData.Phone,
                Surname = UserData.Surname,
                Title = UserData.Title,
                Comments = UserData.Comments
                

            };
        }

        public static UserData UserToUserData(User User)
        {
            return new UserData
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
    }
}
