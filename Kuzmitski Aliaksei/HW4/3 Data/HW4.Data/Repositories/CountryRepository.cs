using HW4.Domain.Models;
using HW4.Domain.Repositories.Interfaces;
using HW4.Domain.UnitOfWork.Interfaces;
using System.Linq;

namespace HW4.Data.Repositories
{
    public class CountryRepository : BaseRepository<Country>, ICountryRepository
    {
        private readonly IUnitOfWork unitOfWork;

        public CountryRepository(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public bool CheckingThePresenceOfCityInTheCountry(int countryId, int cityId)
        {
            return GetCountryFilledWithCities(countryId)
                .Cities
                .Any(x => x.Id.Equals(cityId));
        }

        private Country GetCountryFilledWithCities(int id)
        {

            var country = Get(id);
            unitOfWork.Entry(country).Collection(x => x.Cities).Load();
            return country;

        }
    }
}
