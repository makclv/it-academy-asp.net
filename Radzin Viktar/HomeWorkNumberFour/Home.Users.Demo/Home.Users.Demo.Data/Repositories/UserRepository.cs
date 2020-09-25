using AutoMapper;
using Home.Users.Demo.Data.Context;
using Home.Users.Demo.Domain.Entities;
using Home.Users.Demo.Domain.Repositories;
using Home.Users.Demo.Domain.UnitOfWork;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Home.Users.Demo.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private IUnitOfWork unitOfWork;
       
        public UserRepository(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void DeleteUser(int id)
        {
            var RemoveUser = DbSet().Where(x => x.UserId == id).First();
            DbSet().Remove(RemoveUser);
            unitOfWork.SaveChanges();
        }

        public List<City> GetCities()
        {
            return DbSetCity().ToList();
        }

        public List<Country> GetCountries()
        {
            return DbSetCountry().ToList();
        }

        public void InsertUser(User user)
        {
            user.Country = DbSetCountry().Where(x => x.CountryId == user.Country.CountryId).First();
            user.City = DbSetCity().Where(x => x.CityId == user.City.CityId).First();
            DbSet().Add(user);
            unitOfWork.SaveChanges();
            
        }

        public List<User> SelectAllUsers()
        {
            return DbSet()
                .Include(x => x.Country)
                .Include(x => x.City)
                .ToList();
        }

        public User SelectUserByIdWithCountryandCity(int id)
        {
            return DbSet()
                .Include(x => x.Country)
                .Include(x => x.City)
                .Where(x => x.UserId == id).First();
        }

        public User SelectUserById(int id)
        {
            return DbSet().Where(x => x.UserId == id).First();
        }

        public void UpdateUser(User user)
        {
            user.Country = DbSetCountry().Where(x => x.CountryId == user.Country.CountryId).First();
            user.City = DbSetCity().Where(x => x.CityId == user.City.CityId).First();
            unitOfWork.SaveChanges();
        }

        private DbSet<User> DbSet()
        {
            return unitOfWork.Set<User>();
        }

        private DbSet<Country> DbSetCountry()
        {
            return unitOfWork.Set<Country>();
        }

        private DbSet<City> DbSetCity()
        {
            return unitOfWork.Set<City>();
        }
    }
}
