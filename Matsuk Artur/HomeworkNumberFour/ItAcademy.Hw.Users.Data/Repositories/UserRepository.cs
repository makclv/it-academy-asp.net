using ItAcademy.Hw.Users.Data.Models;
using ItAcademy.Hw.Users.Data.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ItAcademy.Hw.Users.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        public static List<UserData> Users;

     public UserRepository()
        {
            if(Users==null)
            {
                Users = new List<UserData>
            {
                new UserData {Id=0, Name = "Artem", Surname = "Petrov",Title=Title.TitleOne, City = City.Moscow, Country = Country.Russia, Phone = "123-456-789", Email = "mail@mail.com" },
                new UserData {Id=1, Name = "Artur", Surname = "Matsuk",Title=Title.TitleTwo, City = City.NewYork, Country = Country.USA, Phone = "123-456-789", Email = "mail@mail.com" },
                new UserData {Id=2, Name = "Vlad", Surname = "Surname",Title=Title.TitleThree, City = City.Berlin, Country = Country.Germany, Phone = "123-456-789", Email = "mail@mail.com" }
            };
            }
        }
       
        public void ChangeUser( UserData UserData)
        {
            Users[Users.FindIndex(ind => ind.Id == UserData.Id)] = UserData;
           
        }

        public void DeleteUser(int a)
        {
           
            Users.Remove(FindUser(a));
        }

        public UserData FindUser(int a)
        {
            return Users.Find(i=>i.Id==a);
        }

        public List<UserData> GetUsers()
        {
            return Users;
        }

        void IUserRepository.AddUser(UserData UserData)
        {
            UserData.Id = Users.Last<UserData>().Id +1;
            Users.Add(UserData);
            
        }

        



    }
    
}
