using ItAcademy.Hw.Users.Domain.DomainServices.Interfaces;
using ItAcademy.Hw.Users.Domain.Models;
using ItAcademy.Hw.Users.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItAcademy.Hw.Users.Domain.DomainServices
{
   public class CityDomainService : ICityDomainService
    {
        private readonly ICityRepository cityRepository;

        public CityDomainService(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }
        public List<City> GetCities()
        {
            return cityRepository.GetAll();
        }

        public City GetCity(int id)
        {
            return cityRepository.Get(id);
        }
    }
}
