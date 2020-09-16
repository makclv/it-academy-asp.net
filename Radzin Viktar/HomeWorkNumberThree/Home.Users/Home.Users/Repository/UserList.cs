using Home.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Users.Repository
{
    public class UserList
    {
        static List<User> usrList = null;
        static UserList()
        {
            usrList = new List<User>(){
            new User()
            {
                UserID = 1,
                FirstName = "Ahmed",
                LastName = "Salahuddin",
                Phone = "375296152596",
                Email = "mahamed@outlook.com",
                Title = Title.Dr,
                Country = new Country("Belarus"),
                City = new City("Soligorsk")
            },
            new User()
            {
                UserID = 2,
                FirstName = "Alexandr",
                LastName = "Podgor",
                Phone = "375296152596",
                Email = "mahamed@outlook.com",
                Title = Title.Dr,
                Country = new Country("Belarus"),
                City = new City("Soligorsk")
            }
            };
        }
        public static List<User> SelectUserList()
        {
            return usrList;
        }

        public static int GetLastInsertedId() 
        {
            int lastIndex = (from x in usrList select x.UserID).Max();
            return lastIndex;
        }

        public static void InsertUserList(User user)
        {
            usrList.Add(user);
        }

        public static void UpdateUserList(User user)
        {
            User userUpdate = usrList.Find(x => x.UserID == user.UserID);
            userUpdate.FirstName = user.FirstName;
            userUpdate.LastName = user.LastName;
            userUpdate.Phone = user.Phone;
            userUpdate.Email = user.Email;
            userUpdate.Country.Name = user.Country.Name;
            userUpdate.City.Name = user.City.Name;
            userUpdate.Title = user.Title;
            userUpdate.Comments = user.Comments;
        }
        public static void DeleteEmployeeList(int id)
        {
            User userDelete = usrList.Find(x => x.UserID == id);
            usrList.Remove(userDelete);
        }

    }
}