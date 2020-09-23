using HomeTask.Models;
using HomeTask.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace HomeTask.Date
{
    public class UserRepository : DbContext, IUserRepository
    {
       // public List<User> Users = new List<User>();

        public UserRepository()
           : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
    
    public List<User> Add(User user)
        {
            using (UserRepository db = new UserRepository())
            {
                db.Users.Add(user);
                db.SaveChanges();
                var users = db.Users;
                return users.ToList<User>();
            }
        }

        public  void Delete(int id)
        {
            using (UserRepository db = new UserRepository())
            {
                var user = db.Users.Where(x => x.Id == id).First();
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public List<User> Edit(User user)
        {
            using (UserRepository db = new UserRepository())
            {
                var userSwap = db.Users.Where(x => x.Id == user.Id).First();
                db.Users.Remove(userSwap);
                db.Users.Add(user);
                db.SaveChanges();
                return Users.ToList<User>();

            }
        }

        public List<User> GetAllUsers()
        {
            using (UserRepository db = new UserRepository())
            {
                return db.Users.ToList<User>();
            }
        }
    }
}