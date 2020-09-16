using Home.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Home.Users.Repository
{
    public class UserRepository : IUserRepository
    {
        public void DeleteUser(int id)
        {
            UserList.DeleteEmployeeList(id);
        }

        public int GetLastInsertedId()
        {
            int lastIndex = UserList.GetLastInsertedId();
            return lastIndex;
        }

        public void InsertUser(User user)
        {
            UserList.InsertUserList(user);
        }

        public List<User> SelectAllUsers()
        {
            return UserList.SelectUserList();
        }

        public User SelectUserById(int id)
        {
            return UserList.SelectUserList().Find(x => x.UserID == id);
        }

        public void UpdateUser(User user)
        {
            UserList.UpdateUserList(user);
        }

       
    }
}