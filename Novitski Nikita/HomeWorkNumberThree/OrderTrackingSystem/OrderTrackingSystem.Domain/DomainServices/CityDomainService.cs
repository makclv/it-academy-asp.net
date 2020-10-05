using OrderTrackingSystem.Domain.DomainServices.Interfaces;
using OrderTrackingSystem.Domain.Models;
using OrderTrackingSystem.Domain.Repositories;
using OrderTrackingSystem.Domain.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderTrackingSystem.Domain.DomainServices
{
    public class CityDomainService : ICityDomainService
    {
        private readonly ICityRepository cityRepository;
        private readonly IUnitOfWork unitOfWork;

        public CityDomainService(ICityRepository cityRepository, IUnitOfWork unitOfWork)
        {
            this.cityRepository = cityRepository;
            this.unitOfWork = unitOfWork;
        }

        public List<City> GetCitys()
        {
            return cityRepository.GetAll();
        }

        public City GetCity(int id)
        {
            return cityRepository.Get(id);
        }

        public City GetCityWithCountry(int id)
        {
            return cityRepository.GetCityWithCountry(id);
        }

        public bool CityIdIsExists(int cityId)
        {
            return cityRepository.IsExistsCity(cityId);
        }

    }
}
