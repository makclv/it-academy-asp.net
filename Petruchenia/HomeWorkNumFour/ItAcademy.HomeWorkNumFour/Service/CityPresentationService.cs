using ClassLibrary1.Services.Interfaces;
using ItAcademy.HomeWorkNumFour.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ItAcademy.HomeWorkNumFour.Service
{
    public class CityPresentationService : ICityPresentationService
    {
        private readonly ICityDomainService cityDomainService;

        public CityPresentationService(ICityDomainService cityDomainService)
        {
            this.cityDomainService = cityDomainService;
        }

        public IEnumerable<SelectListItem> GetAllCities()
        {
            return (IEnumerable<SelectListItem>)cityDomainService.GetAllCities();
        }
    }

}