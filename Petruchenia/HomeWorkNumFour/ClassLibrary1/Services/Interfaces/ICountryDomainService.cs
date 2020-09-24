using Domain.Entites;
using System.Collections.Generic;

namespace ClassLibrary1.Services.Interfaces
{
    public interface ICountryDomainService : IBaseDomainService
    {
        List<User> GetUsersByCountry(string country);
    }
}
