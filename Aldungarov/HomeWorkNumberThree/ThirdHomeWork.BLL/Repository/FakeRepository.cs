using System.Collections.Generic;
using System.Linq;
using ThirdHomeWork.BLL.Enum;
using ThirdHomeWork.BLL.Interfaces.Repository;
using ThirdHomeWork.BLL.Models;

namespace ThirdHomeWork.BLL.Repository
{
    public class FakeRepository : IFakeRepository
	{
        public static List<User> Users;

        public FakeRepository()
        {
            if (Users == null)
            {
                Users = new List<User>
                    {
                        new User
                        {
                            Id = 1,
                            FirstName = "Джерри",
                            LastName = "Брукхаймер",
                            Title = Title.Dr,
                            Phone = "+375-11-111-11-11",
                            Email = "Testing1@gmail.com",
                            Address = new Address() { CountryName = "USA", CityName = "Hasselhoff" },
                            Comments = "Some comment 1."
                        },
                        new User
                        {
                            Id = 2,
                            FirstName = "Джордж",
                            LastName = "Лукас",
                            Title = Title.Mr,
                            Phone = "+375-22-222-22-22",
                            Email = "Testing2@gmail.com",
                            Address = new Address() { CountryName = "USA", CityName = "Hasselhoff" },
                            Comments = "Some comment 2."
                        },
                        new User
                        {
                            Id = 3,
                            FirstName = "Майкл",
                            LastName = "Бэй",
                            Title = Title.Dr,
                            Phone = "+375-33-333-33-33",
                            Email = "Testing3@gmail.com",
                            Address = new Address() { CountryName = "USA", CityName = "Danch Wood" },
                            Comments = "Some comment 3."
                        },
                        new User
                        {
                            Id = 4,
                            FirstName = "Тайлер",
                            LastName = "Перри",
                            Title = Title.Mr,
                            Phone = "+375-44-444-44-44",
                            Email = "Testing_4@gmail.com",
                            Address = new Address() { CountryName = "Russia", CityName = "Moscow" },
                            Comments = "Some comment 4."
                        },
                        new User
                        {
                            Id = 5,
                            FirstName = "Стивен",
                            LastName = "Спилберг",
                            Title = Title.Dr,
                            Phone = "+375-55-555-55-55",
                            Email = "Testing1@gmail.com",
                            Address = new Address() { CountryName = "Russia", CityName = "Moscow" },
                            Comments = "Some comment."
                        }
                    };
            }
        }

        public void Add(User user)
        {
            Users.Add(user);
        }

        public void Update(User user)
        {
            var changedItem = Users.Find(x => x.Id == user.Id);
            
            changedItem.FirstName = user.FirstName;
            changedItem.LastName = user.LastName;
            changedItem.Title = user.Title;
            changedItem.Phone = user.Phone;
            changedItem.Email = user.Email;
            changedItem.Address.CountryName = user.Address.CountryName;
            changedItem.Address.CityName = user.Address.CityName;
            changedItem.Comments = user.Comments;
        }

        public void Delete(int id)
        {
            Users.Remove(Users.Find(x => x.Id == id));
        }

        public List<User> GetUsers()
        {
            return Users.ToList<User>();
        }

        public User GetUserById(int id)
        {
            return Users.Find(x => x.Id == id);
        }
    }
}
