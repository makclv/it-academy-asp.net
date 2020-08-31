using HW3.Domain.Models;
using HW3.Domain.Repositories;
using System;
using System.Collections.Generic;

namespace HW3.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private List<User> users;
        private List<Country> countries;
        private List<City> cities;

        public UserRepository()
        {
            users = new List<User>();

            countries = new List<Country>()
            {
                new Country(){Id = Guid.NewGuid(), Name = "Belarus"},
                new Country(){Id = Guid.NewGuid(), Name = "Russia"},
                new Country(){Id = Guid.NewGuid(), Name = "Ukraine"},
                new Country(){Id = Guid.NewGuid(), Name = "Poland"},
                new Country(){Id = Guid.NewGuid(), Name = "Lituania"},
                new Country(){Id = Guid.NewGuid(), Name = "Latvia"},
                new Country(){Id = Guid.NewGuid(), Name = "USA"},
                new Country(){Id = Guid.NewGuid(), Name = "Germany"},
                new Country(){Id = Guid.NewGuid(), Name = "China"},
                new Country(){Id = Guid.NewGuid(), Name = "France"},
                new Country(){Id = Guid.NewGuid(), Name = "Great Britain"},
            };

            cities = new List<City>()
            {
                new City(){Id = Guid.NewGuid(), Name = "Minsk"},
                new City(){Id = Guid.NewGuid(), Name = "Gomel"},
                new City(){Id = Guid.NewGuid(), Name = "Vitebsk"},
                new City(){Id = Guid.NewGuid(), Name = "Mogilev"},
                new City(){Id = Guid.NewGuid(), Name = "Grodno"},
                new City(){Id = Guid.NewGuid(), Name = "Brest"},
                new City(){Id = Guid.NewGuid(), Name = "Moscow"},
                new City(){Id = Guid.NewGuid(), Name = "Saint Petersburg"},
                new City(){Id = Guid.NewGuid(), Name = "Novosibirsk"},
                new City(){Id = Guid.NewGuid(), Name = "Kiev"},
                new City(){Id = Guid.NewGuid(), Name = "Kharkiv"},
                new City(){Id = Guid.NewGuid(), Name = "Odessa"},
                new City(){Id = Guid.NewGuid(), Name = "Warsaw"},
                new City(){Id = Guid.NewGuid(), Name = "Krakow"},
                new City(){Id = Guid.NewGuid(), Name = "Lodz"},
                new City(){Id = Guid.NewGuid(), Name = "Vilnius"},
                new City(){Id = Guid.NewGuid(), Name = "Riga"},
                new City(){Id = Guid.NewGuid(), Name = "NY"},
                new City(){Id = Guid.NewGuid(), Name = "Los Angeles"},
                new City(){Id = Guid.NewGuid(), Name = "Chicago"},
                new City(){Id = Guid.NewGuid(), Name = "Berlin"},
                new City(){Id = Guid.NewGuid(), Name = "Hamburg"},
                new City(){Id = Guid.NewGuid(), Name = "Munich"},
                new City(){Id = Guid.NewGuid(), Name = "Chongqing"},
                new City(){Id = Guid.NewGuid(), Name = "Shanghai"},
                new City(){Id = Guid.NewGuid(), Name = "Beijing"},
                new City(){Id = Guid.NewGuid(), Name = "Paris"},
                new City(){Id = Guid.NewGuid(), Name = "Marseilles"},
                new City(){Id = Guid.NewGuid(), Name = "Lyons"},
                new City(){Id = Guid.NewGuid(), Name = "London"},
                new City(){Id = Guid.NewGuid(), Name = "Birmingham"},
                new City(){Id = Guid.NewGuid(), Name = "Leeds"},
            };
        }

        public void CreateUser(User user)
        {
            users.Add(user);
        }

        public User ReadUser(Guid id)
        {
            return users.Find(x => x.Id.Equals(id));
        }

        public void UpdateUser(User user)
        {
            users[users.FindIndex(x => x.Id.Equals(user.Id))] = user;
        }

        public void DeleteUser(Guid id)
        {
            users.RemoveAt(users.FindIndex(x => x.Id.Equals(id)));
        }

        public List<User> AllUsers()
        {
            return users;
        }


        public Country ReadCountry(Guid id)
        {
            return countries.Find(x => x.Id.Equals(id));
        }

        public List<Country> AllCountries()
        {
            return countries;
        }


        public City ReadCity(Guid id)
        {
            return cities.Find(x => x.Id.Equals(id));
        }

        public List<City> AllCities()
        {
            return cities;
        }
    }
}
