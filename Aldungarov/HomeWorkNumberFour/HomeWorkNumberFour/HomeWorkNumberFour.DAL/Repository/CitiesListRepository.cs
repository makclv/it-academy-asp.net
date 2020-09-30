using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Models;
using HomeWorkNumberFour.ClientLayer.Context;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkNumberFour.ClientLayer.Repository
{
    public class CitiesListRepository : ICitiesListRepository
    {
        private readonly DBContext _context = new DBContext();

        public List<City> CityList()
        {
            return _context.Cities.ToList();
        }
    }
}
