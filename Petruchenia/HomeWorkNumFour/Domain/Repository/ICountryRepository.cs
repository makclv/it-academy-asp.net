using Domain.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Repository
{
    public interface ICountryRepository : IBaseRepository<ICountryRepository>
    {
        List<User> GetUsersByCountry(string country);
    }
}
