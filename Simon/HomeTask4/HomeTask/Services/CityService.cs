using HomeTask.Models;
using HomeTask.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeTask.Services.interfaces
{
    public class CityService : ICityService
    {
        private readonly ICityRepository cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            this.cityRepository = cityRepository;
        }

        public List<City> GetAllCity()
        {
            return cityRepository.GetAllCity();
        }
    }
}