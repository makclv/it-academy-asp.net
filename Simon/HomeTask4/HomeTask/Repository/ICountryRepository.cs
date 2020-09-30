using HomeTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask.Repository
{
    public interface ICountryRepository
    {
        List<Country> GetAllCountry();

        Country GetById(int id);
    }
}
