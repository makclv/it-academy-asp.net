using HW4.Domain.Models;

namespace HW4.Domain.Repositories.Interfaces
{
    public interface ICountryRepository : IBaseRepository<Country>
    {
        bool CheckingThePresenceOfCityInTheCountry(int countryId, int cityId);
    }
}
