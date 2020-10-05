using HomeTask.Models;
using HomeTask.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
namespace HomeTask.Date
{
    public class DbContextUserRepository : DbContext, IUserRepository, ICountryRepository, ICityRepository
    {
        public DbContextUserRepository()
           : base("DbConnection1")
        {
            Database.SetInitializer(new DBInitializer());
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Country> Countrys { get; set; }

        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
            .HasMany(p => p.Cities)
            .WithRequired(p => p.Country);
        }

        public List<User> Add(User user)
        {
            using (DbContextUserRepository db = new DbContextUserRepository())
            {
                db.Users.Add(user);
                db.SaveChanges();
                var users = db.Users;
                return users.ToList<User>();
            }
        }

        public void Delete(int id)
        {
            using (DbContextUserRepository db = new DbContextUserRepository())
            {
                var user = db.Users.Where(x => x.Id == id).First();
                db.Users.Remove(user);
                db.SaveChanges();
            }
        }

        public List<User> Edit(User user)
        {
            using (DbContextUserRepository db = new DbContextUserRepository())
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
            using (DbContextUserRepository db = new DbContextUserRepository())
            {
                return db.Users.ToList<User>();
            }
        }

        public List<Country> GetAllCountry()
        {
            using (DbContextUserRepository db = new DbContextUserRepository())
            {
                return db.Countrys.ToList<Country>();
            }
        }

        public List<City> GetAllCity()
        {
            using (DbContextUserRepository db = new DbContextUserRepository())
            {
                return db.Cities.ToList<City>();
            }

        }

        public Country GetById(int id)
        {
            throw new NotImplementedException();
        }

        public User GetUser(int id)
        {
            using (DbContextUserRepository db = new DbContextUserRepository())
            {
                return db.Users.Single(x=>x.Id==id);
            }
        }
    }
}