using HomeWorkNumberFour.BLL.Interfaces.Repository;
using HomeWorkNumberFour.BLL.Models;
using HomeWorkNumberFour.ClientLayer.Context;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkNumberFour.ClientLayer.Repository
{
    public class CountriesListRepository : ICountriesListRepository
    {
        private readonly DBContext _context = new DBContext();

        public List<Country> CountriesList()
        {
            return _context.Countries.ToList();
        }
    }
}