using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.UnitOfWork;
using System.Collections.Generic;
using System.Linq;

namespace OrderTrackingSystem.Domain.DomainServices
{
    public class CountryDomainService : ICountryDomainService
    {

        private readonly ICountryRepository countryRepository;
        private readonly IUnitOfWork unitOfWork;

        public CountryDomainService(ICountryRepository countryRepository, IUnitOfWork unitOfWork)
        {
            this.countryRepository = countryRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<Country> GetCountrys()
        {
            return countryRepository.GetAll();
        }

        public Country GetCountry(int id)
        {
            return countryRepository.Get(id);

        }

        public Country GetCountryWithCities(int id)
        {
            return countryRepository.GetCountryWithCities(id);

        }

        public bool IsCityBelongsCountry(int countryId, int cityId)
        {
            return countryRepository
                .GetCountryWithCities(countryId)
                .Cities
                .Any(c => c.Id == cityId);

        }

        public bool CountryIdIsExists(int countryId)
        {
            return countryRepository.IsExistsCountry(countryId);

        }

    }
}
