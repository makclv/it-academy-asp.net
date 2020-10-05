using HW4.Domain.Models;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices.Interfaces
{
    public interface ICityDomainService : IBaseDomainService
    {
        List<City> GetAllCities();
        City GetCity(int id);
    }
}
