using ItAcademy.Hw.Users.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Domain.Repositories
{
   public interface ICountryRepository : IBaseRepository<Country>
    {

        Country GetCountryWithCities(object id);
    }
}
