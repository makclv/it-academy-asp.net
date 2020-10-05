using HW4.Domain.DomainServices.Interfaces;
using HW4.Domain.Models;
using HW4.Domain.Repositories.Interfaces;
using System.Collections.Generic;

namespace HW4.Domain.DomainServices
{
    public class CityDomainService : BaseDomainService, ICityDomainService
    {
        private readonly ICityRepository cityRepository;

        public CityDomainService(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public List<City> GetAllCities()
        {
            return cityRepository.GetAll();
        }

        public City GetCity(int id)
        {
            return cityRepository.Get(id);
        }
    }
}
