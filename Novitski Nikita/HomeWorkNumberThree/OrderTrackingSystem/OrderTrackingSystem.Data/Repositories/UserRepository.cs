using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackingSystem.Data.Repositories
{
    public class UserRepository : IUserRepository 
    {
        public UserRepository()
        {
            // users = new List<User> { new User() { Id = SetId(), FirsName = "", LastName = "", Phone = "+375(33)123-12-32", Email = "asd@mail.ru", Title = Title.Dr, City = new City() {Id = SetId(),Name ="" }  } };
            cities = new List<City>() 
            {                            
                new City() {Id = SetId(),Name = "Минск" },
                new City() {Id = SetId(),Name = "Брест" },
                new City() {Id = SetId(),Name = "Москва" },
                new City() {Id = SetId(),Name = "Гродно" },
                new City() {Id = SetId(),Name = "Нью-Йорк" },
                new City() {Id = SetId(),Name = "Вншингтон" },
                new City() {Id = SetId(),Name = "Париж" },
                new City() {Id = SetId(),Name = "Лондон" },
                new City() {Id = SetId(),Name = "Гаага" },
                new City() {Id = SetId(),Name = "Санкт-Петербург" },
                new City() {Id = SetId(),Name = "Марсель" }
            };

            countries = new List<Country>()
            {
                new Country() {Id = SetId(),Name = "Беларусь"},
                new Country() {Id = SetId(),Name = "Россия"},
                new Country() {Id = SetId(),Name = "США"},
                new Country() {Id = SetId(),Name = "Великобритания"},
                new Country() {Id = SetId(),Name = "Франция"},
                new Country() {Id = SetId(),Name = "Нидерланды"},
            };

            users = new List<User>();

        }

        private List<User> users;
        private List<City> cities;
        private List<Country> countries;
        private Title title;

        public List<User> GetUsers()
        {
            return users;
        }

        public List<City> GetCitys()
        {
            return cities;
        }

        public List<Country> GetCountrys()
        {
            return countries;
        }

        private Guid SetId()
        {
            return Guid.NewGuid();
        }

        public void AddUser(User user)
        {
            users.Add(user);
        }

        public City GetCity(Guid id)
        {
            return cities.Find(c => c.Id == id);
        }

        public Country GetCountry(Guid id)
        {
            return countries.Find(c => c.Id == id);
        }

        public bool IsExistsUser(Guid id)
        {
           return users.Any(c => c.Id == id);
        }

        public User GetUser(Guid id)
        {
            return users.Find(c => c.Id == id);
        }

        public void EditUser(User user)
        {
            users[users.FindIndex(i => i.Id == user.Id)] = user;
        }

        public void DeleteUser(Guid userId)
        {
            users.RemoveAt(users.FindIndex(u => u.Id == userId));
        }
    }
}
