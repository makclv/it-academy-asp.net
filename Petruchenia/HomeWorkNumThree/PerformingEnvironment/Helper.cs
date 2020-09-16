using ItAcademy.HomeWorkNumThree.Models;
using System.Collections.Generic;

namespace PerformingEnvironment
{
    public class Helper
    {
        public List<User> GetList()
        {
            Item item = new Item();
            item.items.Add(new User()
            {
                FirstName = "Artsiom",
                LastName = "Vishenvskii",
                UserTitle = Title.Mr,
                Country = "USA",
                Sity = "California",
                Email = "Artsiom@gmail.com",
                Phone = 88005553555
            });

            item.items.Add(new User()
            {
                FirstName = "Yury",
                LastName = "Petruchenia",
                UserTitle = Title.Mr,
                Country = "USA",
                Sity = "California",
                Email = "Yury@gmail.com",
                Phone = 90934593490
            });

            item.items.Add(new User()
            {
                FirstName = "Mary",
                LastName = "Maryia",
                UserTitle = Title.Mrs,
                Country = "USA",
                Sity = "California",
                Email = "Mary@gmail.com",
                Phone = 904252354
            });

            return item.items;
        }
    }
}
